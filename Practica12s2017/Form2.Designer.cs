namespace Practica12s2017
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.nodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmyip = new System.Windows.Forms.Label();
            this.btnCargarJson = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodo,
            this.IP,
            this.Carnet,
            this.Estado});
            this.dgv1.Location = new System.Drawing.Point(107, 151);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(444, 150);
            this.dgv1.TabIndex = 5;
            // 
            // nodo
            // 
            this.nodo.DataPropertyName = "nodo";
            this.nodo.HeaderText = "Nodo";
            this.nodo.Name = "nodo";
            this.nodo.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "ip";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Carnet
            // 
            this.Carnet.DataPropertyName = "carnet";
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            this.Carnet.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 35);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // label1
            // 
            this.label1.Image = global::Practica12s2017.Properties.Resources.close1;
            this.label1.Location = new System.Drawing.Point(626, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 35);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmyip
            // 
            this.lblmyip.AutoSize = true;
            this.lblmyip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmyip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblmyip.Location = new System.Drawing.Point(107, 304);
            this.lblmyip.Name = "lblmyip";
            this.lblmyip.Size = new System.Drawing.Size(85, 16);
            this.lblmyip.TabIndex = 7;
            this.lblmyip.Text = "Este Nodo:";
            // 
            // btnCargarJson
            // 
            this.btnCargarJson.ActiveBorderThickness = 1;
            this.btnCargarJson.ActiveCornerRadius = 20;
            this.btnCargarJson.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCargarJson.ActiveForecolor = System.Drawing.Color.DarkTurquoise;
            this.btnCargarJson.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCargarJson.BackColor = System.Drawing.Color.Maroon;
            this.btnCargarJson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarJson.BackgroundImage")));
            this.btnCargarJson.ButtonText = "Cargar JSON";
            this.btnCargarJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarJson.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarJson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.btnCargarJson.IdleBorderThickness = 1;
            this.btnCargarJson.IdleCornerRadius = 25;
            this.btnCargarJson.IdleFillColor = System.Drawing.Color.Tomato;
            this.btnCargarJson.IdleForecolor = System.Drawing.Color.MidnightBlue;
            this.btnCargarJson.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btnCargarJson.Location = new System.Drawing.Point(249, 69);
            this.btnCargarJson.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarJson.Name = "btnCargarJson";
            this.btnCargarJson.Size = new System.Drawing.Size(153, 55);
            this.btnCargarJson.TabIndex = 4;
            this.btnCargarJson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCargarJson.Click += new System.EventHandler(this.btnCargarJson_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(661, 391);
            this.Controls.Add(this.lblmyip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnCargarJson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 btnCargarJson;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewImageColumn Estado;
        private System.Windows.Forms.Label lblmyip;
        private System.Windows.Forms.Label label2;
    }
}