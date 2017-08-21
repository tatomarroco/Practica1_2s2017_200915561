namespace Practica12s2017
{
    partial class ColaMsg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumCola = new System.Windows.Forms.Label();
            this.lblEnCola = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lstbxEjecucion = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInorden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostorden = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cola De Mensajes";
            // 
            // lblClose
            // 
            this.lblClose.Image = global::Practica12s2017.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(516, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumCola);
            this.groupBox1.Controls.Add(this.lblEnCola);
            this.groupBox1.Controls.Add(this.btnOperar);
            this.groupBox1.Location = new System.Drawing.Point(-1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNumCola
            // 
            this.lblNumCola.AutoSize = true;
            this.lblNumCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCola.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumCola.Location = new System.Drawing.Point(286, 28);
            this.lblNumCola.Name = "lblNumCola";
            this.lblNumCola.Size = new System.Drawing.Size(51, 16);
            this.lblNumCola.TabIndex = 2;
            this.lblNumCola.Text = "label2";
            // 
            // lblEnCola
            // 
            this.lblEnCola.AutoSize = true;
            this.lblEnCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnCola.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblEnCola.Location = new System.Drawing.Point(154, 28);
            this.lblEnCola.Name = "lblEnCola";
            this.lblEnCola.Size = new System.Drawing.Size(127, 15);
            this.lblEnCola.TabIndex = 1;
            this.lblEnCola.Text = "Mensajes En Cola:";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(234, 61);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 23);
            this.btnOperar.TabIndex = 0;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lstbxEjecucion
            // 
            this.lstbxEjecucion.FormattingEnabled = true;
            this.lstbxEjecucion.Location = new System.Drawing.Point(288, 170);
            this.lstbxEjecucion.Name = "lstbxEjecucion";
            this.lstbxEjecucion.Size = new System.Drawing.Size(251, 238);
            this.lstbxEjecucion.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(288, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 26);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consola de Ejecución";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(62, 144);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carnet que hizo el mensaje";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(82, 170);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCarnet.Size = new System.Drawing.Size(137, 20);
            this.txtCarnet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "IP que hizo el mensaje";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(82, 231);
            this.txtIP.Name = "txtIP";
            this.txtIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIP.Size = new System.Drawing.Size(136, 20);
            this.txtIP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(55, 268);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(178, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado de la Operación";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(82, 295);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(133, 20);
            this.txtResult.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(63, 330);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Operación en Inorden";
            // 
            // txtInorden
            // 
            this.txtInorden.Location = new System.Drawing.Point(82, 359);
            this.txtInorden.Name = "txtInorden";
            this.txtInorden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInorden.Size = new System.Drawing.Size(132, 20);
            this.txtInorden.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(62, 395);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(162, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Operación en Postorden";
            // 
            // txtPostorden
            // 
            this.txtPostorden.Location = new System.Drawing.Point(82, 424);
            this.txtPostorden.Name = "txtPostorden";
            this.txtPostorden.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPostorden.Size = new System.Drawing.Size(132, 20);
            this.txtPostorden.TabIndex = 13;
            // 
            // ColaMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(551, 472);
            this.Controls.Add(this.txtPostorden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInorden);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstbxEjecucion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColaMsg";
            this.Text = "ColaMsg";
            this.Load += new System.EventHandler(this.ColaMsg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumCola;
        private System.Windows.Forms.Label lblEnCola;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.ListBox lstbxEjecucion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInorden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostorden;
    }
}