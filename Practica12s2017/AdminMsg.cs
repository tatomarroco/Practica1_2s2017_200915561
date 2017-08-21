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
    public partial class AdminMsg : Form
    {

        SendMsgPanel sndmsgpnl = new SendMsgPanel();
        ColaMsg colamsgpnl = new ColaMsg();
        RespuestaMensajes rsptMsg = new RespuestaMensajes();
        public AdminMsg()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEnviarMsg_Click(object sender, EventArgs e)
        {
            sndmsgpnl.StartPosition = FormStartPosition.CenterScreen;
            sndmsgpnl.ShowDialog();
        }

        private void btnVerCola_Click(object sender, EventArgs e){
            colamsgpnl.StartPosition = FormStartPosition.CenterScreen;
            colamsgpnl.ShowDialog();
            //colamsgpnl.Show();
        }

        private void AdminMsg_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            rsptMsg.StartPosition = FormStartPosition.CenterScreen;
            rsptMsg.ShowDialog();
        }
    }
}
