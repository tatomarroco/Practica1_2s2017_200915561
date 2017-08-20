using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Collections.Specialized;

namespace Practica12s2017
{
    public partial class Dashboard : Form{

        static Image imgOn = Image.FromFile(@"C:\img\100x20\conect.png");
        static Image imgOff = Image.FromFile(@"C:\img\100x20\noconect.png");
        //Creas un DataTable (Una tabla) la cual a esa vas a ir asignando valores entre cada fila y columna
        DataTable dt = new DataTable("Tabla1");
        //Creamos un DataRow que seran las filas de nuestro DataTable
        DataRow row;

        public static int controldgv=0;

        public static int indice;
        public static string respuesta;

        static  lstsem ls = new lstsem();

        GestionArchivos ga = new GestionArchivos();
        
        //Creamos la instancia del hilo 
        Thread hilo;

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e){
            dt.Columns.Add("nodo");
            dt.Columns.Add("ip");
            dt.Columns.Add("carnet");
            dt.Columns.Add(new DataColumn("estado", typeof(Image)));

            hilo = new Thread(new ThreadStart(verificar));
        }

        private void verificar(){
            while (true){
                Console.WriteLine("Hilo1...");
                conexion();
                Thread.Sleep(20000);

            }
        }

        private void btnCargarJson_Click(object sender, EventArgs e){
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "json files (*.json)|*.json";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                try{
                    if ((myStream = openFileDialog1.OpenFile()) != null){
                        Console.WriteLine(myStream.ToString());
                        using (myStream){
                            ga.LeerArchivo(myStream);
                            Console.WriteLine("Numero de Nodos: "+ls.getControlip().ToString());
                            for (int z = 0; z <= ls.getControlip() - 1; z++){
                                insertarEnDGV();
                                
                            }
                            lblmyip.Text = lblmyip.Text + " " + ls.getMyIp() + " - 200915561";
                            setIP(ls.getMyIp(), ls.getMyMasc());
                            hilo.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Error de Origen: " + ex.Message);
                }
            }
        }


        public void insertarEnDGV(){
            row = dt.NewRow();
            row["nodo"] = "Nodo" + (controldgv+1).ToString();
            row["ip"] = ls.getIps(controldgv);
            row["carnet"] = "";
            row["estado"] = imgOff;
            dt.Rows.Add(row);

            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = dt;
            controldgv++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        //Asignar IP a maquina
        public static void setIP(string ip_address, string subnet_mask){
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC){
                if ((bool)objMO["IPEnabled"]){
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


        public void conexion(){

            for (int x = 0; x <= ls.getControlip() - 1; x++){
                using (var cliente = new WebClient()){
                    try{
                        var respuestaConvertidaString = cliente.DownloadString("http://" + ls.getIps(x) + ":5000/conectado");
                        Console.WriteLine(respuestaConvertidaString);
                        if (dgv1.Rows[x].Cells["carnet"].Value.Equals("")){
                            reasignar(ls.getIps(x), respuestaConvertidaString);
                        }
                        else{
                            Console.WriteLine("else: Carnet Ya se ingreso");
                        }
                        setRespuesta(respuestaConvertidaString);
                        setIndice(x);
                        setDGV();
                    }
                    catch (Exception ex){
                        Console.WriteLine("No es posible conectar con: "+ls.getIps(x) + "\n Error: "+ ex.Message);
                        dgv1.Rows[x].Cells["estado"].Value = imgOff;
                    }      
                }
            }
        }


        public void reasignar(string ip, string carnet){
            using (var clientere = new WebClient()){
                var parametros = new NameValueCollection();
                parametros["ip"] = ip;
                parametros["carnet"] = carnet;
                var respuestaMetodo = clientere.UploadValues("http://" + ls.getMyIp() + ":5000/insertarCarnet", parametros);
                var elString = Encoding.Default.GetString(respuestaMetodo);
                Console.WriteLine(elString);
            }
        }

        public string getRespuesta(){
            return respuesta;
        }

        public static void setRespuesta(string respuestaM){
            respuesta = respuestaM;
        }

        public int getIndice()
        {
            return indice;
        }

        public static void setIndice(int indiceM)
        {
            indice = indiceM;
        }

        
        public void setDGV(){
            dgv1.Rows[getIndice()].Cells["carnet"].Value = getRespuesta();
            dgv1.Rows[getIndice()].Cells["estado"].Value = imgOn;
        }

       /* public string getActualizarDGV(){
            setDGV();
            return "Hecho";
        }    */    
    }
}
