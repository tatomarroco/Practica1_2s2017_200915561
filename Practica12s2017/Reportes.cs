using System;
using System.Collections.Generic;
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
    public partial class Reportes : Form
    {
        lstsem ls = new lstsem();
        public Reportes()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            graficar();
        }


        public void graficar()
        {

            using (var cliente = new WebClient()){
                try
                {
                    var respuesta = cliente.DownloadString("http://" + ls.getMyIp() + ":5000/graficar");
                    Console.WriteLine("respuesta: " + respuesta);
                    crearImagen(respuesta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es posible conectar con: " + ls.getMyIp() + "\n Error: " + ex.Message);
                }

                picBox.Image = Image.FromFile(@"C:\\Users\\Estuardo\\Documents\\Visual Studio 2013\\Projects\\Practica12s2017\\Practica12s2017\\img\\cola.jpg");

            }


        }


        public void crearImagen(string archivo)
        {
            var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C dot -Tjpg C:\\Users\\Estuardo\\Documents\\Visual Studio 2013\\Projects\\Practica12s2017\\Practica12s2017\\Server_Flask C:\\Users\\l_enr\\Desktop\\" + archivo + ".txt -o C:\\Users\\Estuardo\\Documents\\Visual Studio 2013\\Projects\\Practica12s2017\\Practica12s2017\\img\\cola.jpg");
        }


    }
}
