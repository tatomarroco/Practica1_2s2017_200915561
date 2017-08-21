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
    public partial class RespuestaMensajes : Form
    {
        lstsem ls = new lstsem();
        DataTable dt = new DataTable();
        DataRow row;
        public static int control = 0;

        public int getControl(){
            return control;
        }

        public void setControl(int c)
        {
            control = c;
        }


        public RespuestaMensajes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            //dvg.Rows.Clear();
            
            dvg.DataSource = "";
            dvg.Refresh();
            this.Close();
        }

        private void RespuestaMensajes_Load(object sender, EventArgs e)
        {
            if (getControl() == 0){ 
                dt.Columns.Add("carnet");
                dt.Columns.Add("ip");
                dt.Columns.Add("inorden");
                dt.Columns.Add("postorden");
                dt.Columns.Add("resultado");
                setControl(1);
            }

            Obtener();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt.Clear();
            //dvg.Rows.Clear();
            
            dvg.DataSource= "";
            dvg.Refresh();
            this.Close();
        }

        public void Obtener()
        {
            using (var cliente = new WebClient())
            {
                try
                {
                    var respuesta = cliente.DownloadString("http://" + ls.getMyIp() + ":5000/consultar");
                    Console.WriteLine("respuesta: " + respuesta);
                    insertar(respuesta);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es posible conectar con: " + ls.getMyIp() + "\n Error: " + ex.Message);
                }
            }
        }


        public void insertar(string respuesta){
            String[] substrings1 = respuesta.Split('|');


            for (int ej = 0; ej < substrings1.Length - 1; ej++)
            {
                String[] substrings2 = substrings1[ej].Split(',');
                row = dt.NewRow();
                row["carnet"] = substrings2[0];
                row["ip"] = substrings2[1];
                row["inorden"] = substrings2[2];
                row["postorden"] = substrings2[3];
                row["resultado"] = substrings2[4];
                dt.Rows.Add(row);
            }
            dvg.AutoGenerateColumns = false;
            dvg.DataSource = dt;
        }

    }

    }
