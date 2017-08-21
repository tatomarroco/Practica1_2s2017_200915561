from NodoLD import NodoLD

########################################################################
class ListaDoble():
    longitud = 0
    
    #----------------------------------------------------------------------
    def __init__(self):
        self.Primero = None
        self.Ultimo = None
        """Constructor"""
        
    #----------------------------------------------------------------------
    def Add(self, Carnet, Ip, Inorden, Postorden, Resultado):
        Nuevo = NodoLD(Carnet, Ip, Inorden, Postorden, Resultado)
        aux = self.Primero
        if (self.Primero == None):
            self.Primero = Nuevo
            self.Ultimo = Nuevo
        else:
            while(aux != None):
                if(aux.Sig == None):
                    self.Ultimo.Sig = Nuevo
                    Nuevo.Ant = self.Ultimo
                    self.Ultimo = Nuevo
                    break
                aux = aux.Sig
        self.longitud +=  1
        """"""
    
    #----------------------------------------------------------------------
    def recorrer(self):
        aux = self.Primero
        ant = None
        contact=""
        if (self.Primero == None):
            return str(contact)
        else:
            while (aux != None):
                    contact+= str(aux.getCarnet()) + "," + str(aux.getIp()) + "," + str(aux.getInorden()) + "," + str(aux.getPostOrden()) + "," + str(aux.getResultado()) + "|"
                    ant = aux
                    aux = aux.Sig
            print contact
            return str(contact)