namespace Practica12s2017
{
    partial class SendMsgPanel
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
            this.lblClose = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.btnLoadMsgs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Image = global::Practica12s2017.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(365, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(131, 84);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 1;
            this.txtDestino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(131, 120);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(215, 20);
            this.txtMsg.TabIndex = 2;
            // 
            // btnEnviarMsg
            // 
            this.btnEnviarMsg.Location = new System.Drawing.Point(246, 81);
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.Size = new System.Drawing.Size(100, 23);
            this.btnEnviarMsg.TabIndex = 3;
            this.btnEnviarMsg.Text = "Enviar Mensaje";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // btnLoadMsgs
            // 
            this.btnLoadMsgs.Location = new System.Drawing.Point(156, 191);
            this.btnLoadMsgs.Name = "btnLoadMsgs";
            this.btnLoadMsgs.Size = new System.Drawing.Size(127, 23);
            this.btnLoadMsgs.TabIndex = 4;
            this.btnLoadMsgs.Text = "Cargar Mensajes";
            this.btnLoadMsgs.UseVisualStyleBackColor = true;
            this.btnLoadMsgs.Click += new System.EventHandler(this.btnLoadMsgs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(54, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destino: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mensaje: ";
            // 
            // SendMsgPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(399, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadMsgs);
            this.Controls.Add(this.btnEnviarMsg);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendMsgPanel";
            this.Text = "SendMsgPanel";
            this.Load += new System.EventHandler(this.SendMsgPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnEnviarMsg;
        private System.Windows.Forms.Button btnLoadMsgs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}