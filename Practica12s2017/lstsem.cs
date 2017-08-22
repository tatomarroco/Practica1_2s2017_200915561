using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Threading;


namespace Practica12s2017
{
    class lstsem  {
        public NodoSem primer;
        public NodoSem ultimo;
        public int longi = 0;

        public static string[] ips = new string[10];
        public static int controlip=0;

        public static string myip;
        public static string mymasc;

        public lstsem(){
           primer = null;
           ultimo = null;
        }

        public string getMyIp(){
            return myip;
        }

        public string getMyMasc()
        {
            return mymasc;
        }


        public int getControlip(){
            return controlip;
        }



        public string getIps(int indice){ 
            return ips[indice];
        }

        public bool estado(){
            if(primer==null){ 
                return true;
            }else{ 
                return false;
            }    
        }

        public void Add(String tok, String valor){
            NodoSem tmp = primer;
            if (estado())
            {
                NodoSem nuevo = new NodoSem(tok, valor);
                primer = nuevo;
                ultimo = nuevo;
            }
            else{
                while (tmp != null){
                    if (tmp.Sig == null){
                        NodoSem nuevo = new NodoSem(tok, valor);
                        ultimo.Sig = nuevo;
                        nuevo.Ant = ultimo;
                        ultimo = nuevo;
                        break;
                    }
                    tmp = tmp.Sig;
                }

            }
            this.longi++;
        }

        public void recorrer(lstsem l){
         NodoSem aux = l.primer;
         
             while(aux !=null){
                 Console.WriteLine(aux.valor);
                 aux = aux.Sig;
             }
        }

        //ASIGNA LOS VALORES DE LAS CADENAS DEL ARCHIVO LEIDO 
        public void Asigna(lstsem l){
            NodoSem aux = l.primer;
            NodoSem auxi;
            NodoSem auxi2;
	        NodoSem ant = null;
            String ip="", mascara="";
            int control=0;
               while (aux != null){
                   if (control == 2){
                       
                       CrearUsuario(ip, mascara);
                       control = 0;
                      
                   }else{
                       /*if(aux.valor.Equals("carnet")){
                          auxi = aux.Sig;
                          carnet = auxi.getvalor();  
                          control++;
                          Console.WriteLine(carnet);
                       } */
                       if(aux.valor.Equals("ip")){
                          auxi = aux.Sig;
                          ip = auxi.getvalor();
                          control++;
                          //Console.WriteLine(ip);
                       }
                       else if(aux.valor.Equals("mascara")){
                          auxi = aux.Sig;
                          mascara = auxi.getvalor();
                          control++;
                          //Console.WriteLine(mascara);
                       }
                       else if(aux.valor.Equals("local")){
                           auxi = aux.Sig;
                           auxi2 = auxi.Sig;
                           myip = auxi.getvalor();
                           auxi = auxi2.Sig;
                           mymasc = auxi.getvalor();
                           setIP(myip, mymasc);
                           Thread.Sleep(5000);
                           changeIPServidor();

                           
                       }
                       else{}
                   }
                   ant = aux;
                   aux = aux.Sig;
               }
            Console.WriteLine("Numero de Nodos: "+ controlip.ToString());
           
        }


        public void CrearUsuario(String ip, String mascara){
            System.Windows.Forms.DialogResult result;
            using (var cliente = new WebClient())
            {
                var variablesEnviar = new NameValueCollection();
                variablesEnviar["ip"] = ip;
                variablesEnviar["mascara"] = mascara;

                var respuestaMetodo = cliente.UploadValues("http://" + getMyIp() + ":5000/CrearUsuario", variablesEnviar);
                var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                result = MessageBox.Show("Usuario Insertado", "Sistema");
                Console.WriteLine(respuestaConvertidaString);
               
               ips[controlip]= respuestaConvertidaString;
               controlip++;
                
            }
        }


        public void changeIPServidor()
        {
            try
            {
                string variable = "app.run(debug=True, host='" + getMyIp() + "')";
                string variable2 = string.Format("\n{0}\t\t{1}", "", variable);
                var arvhivo = "C:\\Server_Flask\\Server.py";
                guardar(variable2, arvhivo);
                var pcsInfo = new System.Diagnostics.ProcessStartInfo("cmd", @"/C python C:\Server_Flask\Server.py");
                var proc = new System.Diagnostics.Process();
                proc.StartInfo = pcsInfo;
                proc.Start();
                //proc.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n Error: " + e.Message);
            }
        }


        public void guardar(string variable, string archivo)
        {
            StreamWriter sw = new StreamWriter(archivo, true);
            sw.WriteLine(variable);
            sw.Close();
        }


        public static void setIP(string ip_address, string subnet_mask)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP = objMO.GetMethodParameters("EnableStatic");
                        newIP["IPAddress"] = new string[] { ip_address };
                        newIP["SubnetMask"] = new string[] { subnet_mask };
                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                    }
                    catch (Exception) { throw; }
                }
            }
        }

        
        

    }
}
