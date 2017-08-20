from NodoLista import NodoLista

class Lista:
    longitud = 0
    
    def __init__(self):
        self.Primer = None
        self.Ultimo = None
        
        
    def Add(self, Ip, Mascara):
        Nuevo = NodoLista(Ip, Mascara)
        aux = self.Primer
        if self.Primer == None:
            self.Primer = Nuevo
            self.Ultimo = Nuevo
        else:
            self.Ultimo.Sig = Nuevo
            self.Ultimo = Nuevo
    
    def Delete(self, numero):
        num = str(numero)
        aux = self.Primer
        aux2 = self.Primer
        #index = aux.getIndice()
        if aux == None:
            print "No hay elementos en la Lista"
        else:
            if index == num:
                if aux.Sig == None:
                    self.Primer = None
                    self.Ultimo = None
                else:
                    self.Primer = aux.Sig
            else:
                b = True
                while aux.Sig != None and b:
                    aux = aux.Sig
                    index = aux.getIndice()
                    if index == num:
                        aux2.Sig = aux.Sig
                        aux = None
                        b = False
                        break
                    aux2 = aux2.Sig
                if b == True:
                    print "Indice no Encontrado"
                
                
    def Search(self, Ip, Carnet):
        aux = self.Primer
        if self.Primer == None:
            print "Lista Vacia"
            return "Lista Vacia" 
        else:
            while aux != None:
                laIp = aux.getIp()
                if laIp == str(Ip):
                    aux.setCarnet(Carnet)
                    #print "El Dato Se encuentra en el Indice " + str(index)
                    #return "El Dato Se encuentra en el Indice " + str(index)
                    break
                aux = aux.Sig
                
    
            
    def consultar(self, Ip):
        aux = self.Primer
        if self.Primer == None:
            print "Lista Vacia"
            return "Lista Vacia" 
        else:
            while aux != None:
                laIp = aux.getIp()
                if laIp == str(Ip):
                    carnet = aux.getCarnet()
                    print "El Carnet es: " + str(carnet)
                    return str(carnet)
                    break
                aux = aux.Sig
                
                 
    def getLongitud(self):
        return self.longitud
    
    def setLongitud(self, Longitud):
        self.longitud = Longitud
        
    #---------------------GRAFICAR--LISTA-----------------------------------------------------------------
    #def Graficar(self):