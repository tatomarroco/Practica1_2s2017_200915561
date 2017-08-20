using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12s2017
{
    public partial class SendMsgPanel : Form
    {

        string ipDestino;
        string msg;

        public SendMsgPanel()
        {
            InitializeComponent();
        }

        private void SendMsgPanel_Load(object sender, EventArgs e)
        {
            txtDestino.Text = "";
            txtMsg.Text = "";
            txtDestino.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarMsg_Click(object sender, EventArgs e){
            ipDestino = txtDestino.Text;
            msg = txtMsg.Text;
            enviarMsg();
        }



        public void enviarMsg(){
            using (var cliente = new WebClient()){
                try{
                    var variablesEnviar = new NameValueCollection();
                    variablesEnviar["inorden"] = msg;

                    var respuestaMetodo = cliente.UploadValues("http://" + ipDestino + ":5000/mensaje", variablesEnviar);
                    var respuestaConvertidaString = Encoding.Default.GetString(respuestaMetodo);
                    //result = MessageBox.Show("Usuario Insertado", "Sistema");
                    Console.WriteLine("¿Encoló? " + respuestaConvertidaString);
                }
                catch (Exception ex){
                    Console.WriteLine("No es posible conectar con: " + ipDestino + "\n Error: " + ex.Message);
                }
            }
        }


        public void leerXML(string cadena){
            int inicioestado = 0;
            int estadoprincipal = 0;
            char cadenaconcatenar;
            string ip = "";
            string mensaje = "";

            for (inicioestado = 0; inicioestado < cadena.Length; inicioestado++)
            {
                cadenaconcatenar = cadena[inicioestado];

                switch (estadoprincipal)
                {
                    case 0:
                        switch (cadenaconcatenar)
                        {
                            case ' ':
                            case '\r':
                            case '\t':
                            case '\n':
                            case '\b':
                            case '\f':
                                estadoprincipal = 0;
                                break;

                            case '<':
                                estadoprincipal = 1;
                                break;
                        }
                        break;

                    case 1: //Mensaje Nodo
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            if (cadenaconcatenar.Equals('I'))
                            {
                                estadoprincipal = 2;
                            }
                            else
                            {
                                estadoprincipal = 1;
                            }
                        }
                        break;

                    case 2://Ip - Numeros
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('<') || cadenaconcatenar.Equals('>'))
                        {
                            if (cadenaconcatenar.Equals('t'))
                            {
                                estadoprincipal = 3;
                            }
                            else
                            {
                                estadoprincipal = 2;
                            }
                        }
                        else if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('.'))
                        {
                            ip += cadenaconcatenar;
                            estadoprincipal = 2;
                        }
                        else if (cadenaconcatenar.Equals('/'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                msg = mensaje;
                                ipDestino = ip;
                                enviarMsg();
                                //AdminMensajes.AgregaraCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 2;
                        }
                        break;

                    case 3: //texto
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>'))
                        {
                            estadoprincipal = 3;
                        }
                        else if (cadenaconcatenar.Equals('('))
                        {
                            mensaje += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        break;

                    case 4: //TextoMensaje
                        if (char.IsNumber(cadenaconcatenar) || cadenaconcatenar.Equals('+') || cadenaconcatenar.Equals('/') || cadenaconcatenar.Equals('-') || cadenaconcatenar.Equals('*') || cadenaconcatenar.Equals('(') || cadenaconcatenar.Equals(')'))
                        {
                            mensaje += cadenaconcatenar;
                            estadoprincipal = 4;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            if (ip != "" || mensaje != "")
                            {
                                msg = mensaje;
                                ipDestino = ip;
                                enviarMsg();
                                //AdminMensajes.AgregaraCola(ip, mensaje);
                                ip = "";
                                mensaje = "";
                            }
                            estadoprincipal = 5;
                        }
                        break;

                    case 5: //Mensajes
                        if (char.IsLetter(cadenaconcatenar) || cadenaconcatenar.Equals('>') || cadenaconcatenar.Equals('/'))
                        {
                            estadoprincipal = 5;
                        }
                        else if (cadenaconcatenar.Equals('<'))
                        {
                            estadoprincipal = 1;
                        }
                        break;
                }
            }
        }

        private void btnLoadMsgs_Click(object sender, EventArgs e){
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        Console.WriteLine(myStream.ToString());
                        leerXML(File.ReadAllText(openFileDialog1.FileName));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Error de Origen: " + ex.Message);
                }
            }
        }


    }
}
