namespace Practica12s2017
{
    partial class AdminMsg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMsg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new ns1.BunifuThinButton2();
            this.btnVerCola = new ns1.BunifuThinButton2();
            this.btnEnviarMsg = new ns1.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 35);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblClose
            // 
            this.lblClose.Image = global::Practica12s2017.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(311, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Ver Respuestas De Mensajes";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 25;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Azure;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(70, 206);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(209, 69);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerCola
            // 
            this.btnVerCola.ActiveBorderThickness = 1;
            this.btnVerCola.ActiveCornerRadius = 20;
            this.btnVerCola.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerCola.ActiveForecolor = System.Drawing.Color.DarkTurquoise;
            this.btnVerCola.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerCola.BackColor = System.Drawing.Color.Maroon;
            this.btnVerCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerCola.BackgroundImage")));
            this.btnVerCola.ButtonText = "Ver Cola de Mensajes";
            this.btnVerCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnVerCola.IdleBorderThickness = 1;
            this.btnVerCola.IdleCornerRadius = 25;
            this.btnVerCola.IdleFillColor = System.Drawing.Color.Azure;
            this.btnVerCola.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnVerCola.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnVerCola.Location = new System.Drawing.Point(70, 143);
            this.btnVerCola.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerCola.Name = "btnVerCola";
            this.btnVerCola.Size = new System.Drawing.Size(209, 55);
            this.btnVerCola.TabIndex = 6;
            this.btnVerCola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerCola.Click += new System.EventHandler(this.btnVerCola_Click);
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.ActiveBorderThickness = 1;
            this.btnEnviarMsg.ActiveCornerRadius = 20;
            this.btnEnviarMsg.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviarMsg.ActiveForecolor = System.Drawing.Color.DarkTurquoise;
            this.btnEnviarMsg.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviarMsg.BackColor = System.Drawing.Color.Maroon;
            this.btnEnviarMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarMsg.BackgroundImage")));
            this.btnEnviarMsg.ButtonText = "Enviar Mensajes";
            this.btnEnviarMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarMsg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnEnviarMsg.IdleBorderThickness = 1;
            this.btnEnviarMsg.IdleCornerRadius = 25;
            this.btnEnviarMsg.IdleFillColor = System.Drawing.Color.Azure;
            this.btnEnviarMsg.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnEnviarMsg.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviarMsg.Location = new System.Drawing.Point(97, 80);
            this.btnEnviarMsg.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(153, 55);
            this.btnEnviarMsg.TabIndex = 5;
            this.btnEnviarMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // AdminMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(344, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.btnVerCola);
            this.Controls.Add(this.btnEnviarMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMsg";
            this.Text = "AdminMsg";
            this.Load += new System.EventHandler(this.AdminMsg_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuThinButton2 btnEnviarMsg;
        private ns1.BunifuThinButton2 btnVerCola;
        private ns1.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;

    }
}