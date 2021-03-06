﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
            bool x = false;

            using (var cliente = new WebClient()){
                try
                {

                    var respuesta = cliente.DownloadString("http://" + ls.getMyIp() + ":5000/graficar");
                    Console.WriteLine("respuesta: " + respuesta);
                    Thread.Sleep(8000);
                        crearImagen();
                    
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                Thread.Sleep(5000);
                picBox.Image = Image.FromFile(@"C:\img\cola.jpg");

            }


        }


        public void crearImagen()
        {
            try
            {
                var pInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C dot -Tjpg C:\\img\\Cola.txt -o C:\\img\\cola.jpg");
                var proceso = new System.Diagnostics.Process();

                proceso.StartInfo = pInfo;

                proceso.Start();
                Thread.Sleep(3000);
                proceso.WaitForExit();

            }
            catch (Exception x)
            {
                Console.WriteLine(x.ToString());
            }
            }
        }

    }

