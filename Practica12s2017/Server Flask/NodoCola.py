class NodoCola():
    def __init__(self,Ip, Message):
        self.ip = Ip
        self.message = Message
        self.Sig = None
        
    def RomperEnlaceSigF(self):
        self.Sig = None
    
    
    def getIp(self):
        return self.ip
    
    def setIp(self, Ip):
        self.ip = Ip
        
    def getMessage(self):
        return self.message
    
    def setMessege(self, Message):
        self.message = Message