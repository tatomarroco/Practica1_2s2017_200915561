using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica12s2017
{
    public partial class frmMP : Form
    {
        Dashboard frm2 = new Dashboard();
        AdminMsg frm3 = new AdminMsg();
        public frmMP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3.StartPosition = FormStartPosition.CenterScreen;
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.StartPosition = FormStartPosition.CenterScreen;
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMP_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
