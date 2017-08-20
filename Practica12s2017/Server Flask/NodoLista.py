class NodoLista:
    def __init__(self,Ip, Mascara):
        self.ip = Ip
        self.carnet = ""
        self.mascara = Mascara
        self.Sig = None
        
    def RomperEnlaceSigF(self):
        self.Sig = None
    
    
    def getIp(self):
        return self.ip
    
    def setIp(self, Ip):
        self.ip = Ip
        
    #----------------------------------------------------------------------
    def getCarnet(self):
        return self.carnet
    
    #----------------------------------------------------------------------
    def setCarnet(self, Carnet):
        self.carnet = Carnet
        
        