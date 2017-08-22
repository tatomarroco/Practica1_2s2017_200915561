using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12s2017
{
    public partial class ColaMsg : Form
    {
        lstsem ls = new lstsem();
        //AdminMsg admsg = new AdminMsg();
        public ColaMsg(){
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e){
            lstbxEjecucion.Items.Clear();
            lstbxEjecucion.Refresh();
            txtCarnet.Text = "";
            txtInorden.Text = "";
            txtIP.Text = "";
            txtPostorden.Text = "";
            txtResult.Text = "";
            this.Close();
        }

        private void ColaMsg_Load(object sender, EventArgs e){
            lblNumCola.Text = obtenerNumCola();
        }


        public string obtenerNumCola(){
            using (var cliente = new WebClient()){
                try{
                    var respuestaConvertidaString = cliente.DownloadString("http://" + ls.getMyIp() + ":5000/ncola");
                    Console.WriteLine("respuesta de numero de cola: "+respuestaConvertidaString);
                    return respuestaConvertidaString;
                }
                catch (Exception ex){
                    Console.WriteLine("No es posible conectar con: " + ls.getMyIp() + "\n Error: " + ex.Message);
                    return "No Conectado";
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e){
            lstbxEjecucion.Items.Clear();
            lstbxEjecucion.Refresh();
            Operar();
            lblNumCola.Text = obtenerNumCola();
        }

        public void Operar(){
            using (var cliente = new WebClient()){
                try{
                    var respuestaConvertidaString = cliente.DownloadString("http://" + ls.getMyIp() + ":5000/operar");
                    Console.WriteLine("respuesta: " + respuestaConvertidaString);
                    insertar(respuestaConvertidaString);
                }
                catch (Exception ex){
                    Console.WriteLine("No es posible conectar con: " + ls.getMyIp() + "\n Error: " + ex.Message);
                }
            }
        }

        public void insertar(string respuesta){ 
            String[] substrings1 = respuesta.Split(',');
            String[] substrings2 = substrings1[5].Split('|');
            txtCarnet.Text = substrings1[1];
            txtIP.Text = substrings1[0];
            txtResult.Text = substrings1[2];
            txtInorden.Text = substrings1[3];
            txtPostorden.Text = substrings1[4];

            for (int ej = 1; ej <= substrings2.Length - 1; ej++){
                lstbxEjecucion.Items.Add(substrings2[ej]);    
            }

            
                using (var cliente = new WebClient()){
                    try{
                        var parametros = new NameValueCollection();
                        parametros["inorden"] = substrings1[3];
                        parametros["postorden"] = substrings1[4];
                        parametros["resultado"] = substrings1[2];

                        var rserver = cliente.UploadValues("http://" + substrings1[0] + ":5000/respuesta", parametros);
                        var rString = Encoding.Default.GetString(rserver);
                        //result = MessageBox.Show("Usuario Insertado", "Sistema");
                        Console.WriteLine(rString);
                    }
                    catch (Exception ex){
                        Console.WriteLine("No es posible conectar con: " + substrings1[0] + "\n Error: " + ex.Message);
                    }
                
                    
                
            }
            



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
