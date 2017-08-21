########################################################################
class NodoLD():
    
    def __init__(self,Carnet,Ip,Inorden,Postorden,Resultado):
        self.ip = Ip
        self.carnet = Carnet
        self.inorden = Inorden
        self.postorden = Postorden
        self.resultado = Resultado
        self.Sig = None
        self.Ant = None
    
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
        
    #----------------------------------------------------------------------
    def getInorden(self):
        return self.inorden
        
    #----------------------------------------------------------------------
    def setInorden(self, Carnet):
        self.carnet = Carnet
        
    #----------------------------------------------------------------------
    def getPostOrden(self):
        return self.postorden
    
    #----------------------------------------------------------------------
    def getResultado(self):
        return self.resultado