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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnet,
            this.ip,
            this.inorden,
            this.postorden,
            this.resultado});
            this.dataGridView1.Location = new System.Drawing.Point(44, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(566, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // carnet
            // 
            this.carnet.DataPropertyName = "carnet";
            this.carnet.HeaderText = "Carnet que opero";
            this.carnet.MinimumWidth = 120;
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            this.carnet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.carnet.Width = 120;
            // 
            // ip
            // 
            this.ip.DataPropertyName = "ip";
            this.ip.HeaderText = "IP que opero";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // inorden
            // 
            this.inorden.DataPropertyName = "inorden";
            this.inorden.HeaderText = "Inorden";
            this.inorden.Name = "inorden";
            this.inorden.ReadOnly = true;
            // 
            // postorden
            // 
            this.postorden.DataPropertyName = "postorden";
            this.postorden.HeaderText = "Postorden";
            this.postorden.Name = "postorden";
            this.postorden.ReadOnly = true;
            // 
            // resultado
            // 
            this.resultado.DataPropertyName = "resultado";
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            // 
            // RespuestaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 526);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RespuestaMensajes";
            this.Text = "RespuestaMensajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
    }
}