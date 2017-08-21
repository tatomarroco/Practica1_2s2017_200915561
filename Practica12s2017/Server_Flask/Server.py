from flask import Flask, request, Response
from Lista import Lista
from colaMsg import colaMsg
from Pila import Pila
from ListaDoble import ListaDoble

app = Flask("Server")

Listaof = Lista()
Colaof = colaMsg()
pSignos = Pila()
pNumeros = Pila()
ListaDob = ListaDoble()

########################################################################
class ServerFlask():
    
    #METODO PARA CONECTADO---------------------------------------------------------------------------------------------------
        @app.route('/conectado',methods=['GET'])
        def conect():
                return "200915561"
        
        
        
    #METODO PARA MENSAJES
        @app.route('/mensaje',methods=['POST'])
        def msg():
                operacion = str(request.form['inorden'])
                ipcatch = str(request.environ['REMOTE_ADDR'])
                Colaof.Encolar(ipcatch, operacion)
                return "true"
        
     #METODO PARA Agregar Usuarios
        @app.route('/CrearUsuario',methods=['POST'])
        def enlistar():
                ip = str(request.form['ip'])
                mascara = str(request.form['mascara'])
                Listaof.Add(ip, mascara)
                return ip
        
        #METODO PARA Agregar Usuarios
        @app.route('/insertarCarnet',methods=['POST'])
        def insertarCar():
                ip = str(request.form['ip'])
                carnet = str(request.form['carnet'])
                Listaof.Search(ip,carnet)
                return "Carnet Insertado"        
        
        #METODO PARA Saber los mensajes en Cola
        @app.route('/ncola',methods=['GET'])
        def tamcola():
                numero = Colaof.getLongitud()
                return str(numero)

        #METODO PARA Operar
        @app.route("/operar", methods=['GET'])
        def ResolverExpresion():
                ip = Colaof.peekIP()
                carnet = Listaof.consultar(ip)
                cadena = Colaof.Desencolar()
                caracter = ""
                pilaEjecucion = ""
                psorden = ""
                valor = ""
                numero1 = ""
                numero2 = ""
                signo = ""
                cantidad = len(cadena)
                for i in range(cantidad):
                        caracter = cadena[i]
                        if caracter in ('/', '*', '-', '+'):
                                pSignos.push(caracter)
                                pNumeros.push(valor)
                                pilaEjecucion = pilaEjecucion + "|" + "push(" + str(valor) + ")"
                                psorden = psorden  + str(valor) + " "
                                valor = ""
                        elif caracter in (' ', '('):
                                valorar = "No hace nada"
                        elif caracter == ')':
                                pNumeros.push(valor)
                                pilaEjecucion = pilaEjecucion + "|" + "push(" + str(valor) + ")"
                                valor = ""
                                numero2 = pNumeros.pop()
                                pilaEjecucion = pilaEjecucion + "|" + "pop()"
                                numero1 = pNumeros.pop()
                                pilaEjecucion = pilaEjecucion + "|" + "pop()"
                                signo = pSignos.pop()
                                psorden = psorden  + str(signo) + " "
                                if signo == '-':
                                        valor = int(numero1) - int(numero2)
                                        pilaEjecucion = pilaEjecucion + "|" + str(numero1) + " - " + str(numero2) + " = " + str(valor) 
                                elif signo == '+':
                                        valor = int(numero1) + int(numero2)
                                        pilaEjecucion = pilaEjecucion + "|" + str(numero1) + " + " + str(numero2) + " = " + str(valor)
                                elif signo == '*':
                                        valor = int(numero1) * int(numero2)
                                        pilaEjecucion = pilaEjecucion + "|" + str(numero1) + " * " + str(numero2) + " = " + str(valor)
                                elif signo == '/':
                                        valor = int(numero1) / int(numero2)
                                        pilaEjecucion = pilaEjecucion + "|" + str(numero1) + " / " + str(numero2) + " = " + str(valor)
                        else:
                                valor = valor + caracter
                pNumeros.push(valor)
                pilaEjecucion = pilaEjecucion + "|" + "push(" + str(valor) + ")"       
                respuesta = str(valor) #pNumeros.pop()
                pilaEjecucion = pilaEjecucion #+"|" + "pop()"
                #resp = str(ip) + "," +  str(respuesta) + "," + str(cadena) + ":" + str(pilaEjecucion)
                respu = str(ip) + "," + str(carnet) + "," +  str(respuesta) + "," + str(cadena) + "," + str(psorden) + "," + str(pilaEjecucion)
                return respu

        #METODO PARA AGREGAR a Lista Doble
        @app.route('/respuesta',methods=['POST'])
        def respuestaLD():
                inord = str(request.form['inorden'])
                psorden = str(request.form['postorden'])
                resultado = str(request.form['resultado'])
                ipcatch = str(request.environ['REMOTE_ADDR'])
                carnet = Listaof.consultar(ipcatch)
                ListaDob.Add(carnet, ipcatch, inord, psorden, resultado)
                print "true"
                return "true"

        #METODO Para consultar la Lista Doble
        @app.route('/consultar',methods=['GET'])
        def consulta():
                resultado = ListaDob.recorrer()
                print resultado
                return str(resultado)
        
        #---------------------GRAFICAR COLA-----------------------------
        @app.route('/graficar',methods=['GET'])
        def graficarCola():
                archivo = Colaof.Graficar()
                return archivo
                

     #CORRE EL SERVIDOR EN
        if __name__ == "__main__":
                app.run(debug=True, host='192.168.1.90')       
    
        
        