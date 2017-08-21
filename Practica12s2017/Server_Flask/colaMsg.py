from NodoCola import NodoCola

class colaMsg():
    longitud = 0 #Longitud de la Cola
    
    def __init__(self):
        self.Cabeza = None
        self.Cola = None
        
        
    def Encolar(self, Ip, Message):
        Nuevo = NodoCola(Ip, Message)
        aux = self.Cabeza
        if self.Cabeza == None:
            self.Cabeza = Nuevo
            self.Cola = Nuevo
            self.longitud = self.longitud + 1
        else:
            self.Cola.Sig = Nuevo
            self.Cola = self.Cola.Sig
            self.longitud = self.longitud + 1
    
    def Desencolar(self):
        aux = self.Cabeza
        if aux == None:
            print "Cola vacia"
            return "Cola Vacia"
        else:
            data = self.Cabeza.getMessage()
            print str(data)
            self.Cabeza = aux.Sig
            aux = None
            self.longitud = self.longitud - 1
            return str(data)
     
    def peekIP(self):
        aux = self.Cabeza
        if aux == None:
            print "Cola vacia"
            return "Cola Vacia"
        else:
            peek = self.Cabeza.getIp()
            print str(peek)
            return str(peek)
        
                 
    def getLongitud(self):
        return self.longitud
    
    def setLongitud(self, Longitud):
        self.longitud = Longitud
        
    #---------------------GRAFICAR--COLA-----------------------------------------------------------------
    def Graficar(self):
        nombreArchivo = None
        cont1 = 0
        cont2 = 0
        corchcierre = "}"
        tempu = self.Cabeza
        tempd = self.Cabeza
        try:
            archivo = open('Cola.txt','w')
            archivo.write("digraph G{ \n")
            
            while (tempu!=None):
                ip = tempu.getDato()
                op = tempu.getMessage()
                archivo.write("n"+str(ip) + "_nodo_" + str(cont1) + " [label="+str(ip)+ "\n"+  str(op)+"] \n")
                cont1 = cont1 + 1
                tempu = tempu.Sig
            
            cont1 = 0
            cont2 = cont1 + 1       
            tempu = self.Cabeza
            tempd = tempu.Sig
            
            while tempu != None:
                if tempd != None:
                    data1 = tempu.getIp
                    data2 = tempd.getIp
                    archivo.write("n"+str(data1) + "_nodo_" + str(cont1) + "->" + "n"+str(data2) +"_nodo_"+str(cont2)+"\n")
                    cont1 = cont1 + 1
                    cont2 = cont2 + 1
                if tempd == None:
                    break 
                else:    
                    tempu = tempu.Sig
                    tempd = tempd.Sig
            archivo.write(corchcierre)            
            archivo.close()
        
        except:
            print "Ocurrio un Error al escribir Archivo"
            return "Ocurrio un Error al escribir Archivo"
        
        nombreArchivo = "Cola"
        return nombreArchivo    