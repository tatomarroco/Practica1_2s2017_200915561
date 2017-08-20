class NodoPila():
    def __init__(self,dato):
        self.Dato = dato
        self.Sig = None
        
    #----------------------------------------------------------------------
    def getDato(self):
        return self.Dato
        
    def setDato(self, dato):
        self.Dato = dato