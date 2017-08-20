from NodoCola import NodoCola

class colaMsg():
    longitud = 0 #Longitud de la Cola
    
    def __init__(self):
        self.Cabeza = None
        self. Cola = None
        
        
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