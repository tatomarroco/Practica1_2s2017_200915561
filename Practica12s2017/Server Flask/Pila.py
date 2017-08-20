from NodoPila import NodoPila

class Pila():
    def __init__(self):
        self.ultimo = None
        
    def push(self, opinorden):
        Nuevo = NodoPila(opinorden)
        if (self.ultimo != None):
            aux = self.ultimo
            self.ultimo = Nuevo
            self.ultimo.Sig = aux
        else:
            self.ultimo = Nuevo
            
    #----------------------------------------------------------------------
    def pop(self):
        if(self.ultimo != None):
            aux = self.ultimo
            self.ultimo = aux.Sig
        return aux.Dato
    
    
        