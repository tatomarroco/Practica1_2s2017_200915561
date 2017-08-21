namespace Practica12s2017
{
    partial class RespuestaMensajes
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
            this.dvg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvg
            // 
            this.dvg.AllowUserToAddRows = false;
            this.dvg.AllowUserToDeleteRows = false;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnet,
            this.ip,
            this.inorden,
            this.postorden,
            this.resultado});
            this.dvg.Location = new System.Drawing.Point(38, 74);
            this.dvg.Name = "dvg";
            this.dvg.ReadOnly = true;
            this.dvg.Size = new System.Drawing.Size(566, 225);
            this.dvg.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 36);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar empezando por los mas antiguos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mostrar empezando por los mas recientes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(38, 359);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(566, 23);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblClose
            // 
            this.lblClose.Image = global::Practica12s2017.Properties.Resources.close1;
            this.lblClose.Location = new System.Drawing.Point(610, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(35, 35);
            this.lblClose.TabIndex = 0;
            this.lblClose.Click += new System.EventHandler(this.label1_Click);
            // 
            // carnet
            // 
            this.carnet.DataPropertyName = "carnet";
            this.carnet.HeaderText = "Carnet que opero";
            this.carnet.MinimumWidth = 120;
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            this.carnet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carnet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.carnet.Width = 120;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP que opero";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inorden
            // 
            this.inorden.DataPropertyName = "inorden";
            this.inorden.HeaderText = "Inorden";
            this.inorden.Name = "inorden";
            this.inorden.ReadOnly = true;
            this.inorden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // postorden
            // 
            this.postorden.DataPropertyName = "postorden";
            this.postorden.HeaderText = "Postorden";
            this.postorden.Name = "postorden";
            this.postorden.ReadOnly = true;
            this.postorden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // resultado
            // 
            this.resultado.DataPropertyName = "resultado";
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RespuestaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(644, 408);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RespuestaMensajes";
            this.Text = "RespuestaMensajes";
            this.Load += new System.EventHandler(this.RespuestaMensajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
    }
}