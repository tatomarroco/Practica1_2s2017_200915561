namespace Practica12s2017
{
    partial class frmMP
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerDash = new System.Windows.Forms.Button();
            this.btnAdminMsg = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pnlPrinc = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlPrinc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerDash
            // 
            this.btnVerDash.Location = new System.Drawing.Point(105, 109);
            this.btnVerDash.Name = "btnVerDash";
            this.btnVerDash.Size = new System.Drawing.Size(121, 23);
            this.btnVerDash.TabIndex = 0;
            this.btnVerDash.Text = "Ver Dashboard";
            this.btnVerDash.UseVisualStyleBackColor = true;
            this.btnVerDash.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdminMsg
            // 
            this.btnAdminMsg.Location = new System.Drawing.Point(105, 153);
            this.btnAdminMsg.Name = "btnAdminMsg";
            this.btnAdminMsg.Size = new System.Drawing.Size(121, 23);
            this.btnAdminMsg.TabIndex = 1;
            this.btnAdminMsg.Text = "Administrar Mensajes";
            this.btnAdminMsg.UseVisualStyleBackColor = true;
            this.btnAdminMsg.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(105, 199);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(121, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Ver Reportes";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlPrinc
            // 
            this.pnlPrinc.BackColor = System.Drawing.Color.Firebrick;
            this.pnlPrinc.Controls.Add(this.lblClose);
            this.pnlPrinc.Location = new System.Drawing.Point(-1, 0);
            this.pnlPrinc.Name = "pnlPrinc";
            this.pnlPrinc.Size = new System.Drawing.Size(329, 35);
            this.pnlPrinc.TabIndex = 3;
            // 
            // lblClose
            // 
            this.lblClose.Image = global::Practica12s2017.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(293, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(327, 317);
            this.Controls.Add(this.pnlPrinc);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdminMsg);
            this.Controls.Add(this.btnVerDash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMP_Load);
            this.pnlPrinc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDash;
        private System.Windows.Forms.Button btnAdminMsg;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pnlPrinc;
        private System.Windows.Forms.Label lblClose;
    }
}

