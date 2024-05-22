namespace ALEJ
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.NavBar = new System.Windows.Forms.Panel();
            this.Registro = new System.Windows.Forms.Button();
            this.Archivo = new System.Windows.Forms.Button();
            this.SubirReporte = new System.Windows.Forms.Button();
            this.REspera = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fondo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDREPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbrirDoc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Fondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.NavBar.Controls.Add(this.Registro);
            this.NavBar.Controls.Add(this.Archivo);
            this.NavBar.Controls.Add(this.SubirReporte);
            this.NavBar.Controls.Add(this.REspera);
            this.NavBar.Controls.Add(this.Inicio);
            this.NavBar.Controls.Add(this.panelLogo);
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(320, 1028);
            this.NavBar.TabIndex = 0;
            // 
            // Registro
            // 
            this.Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registro.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.ForeColor = System.Drawing.Color.White;
            this.Registro.Location = new System.Drawing.Point(0, 576);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(320, 72);
            this.Registro.TabIndex = 5;
            this.Registro.Text = "REGISTRO";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // Archivo
            // 
            this.Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Archivo.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivo.ForeColor = System.Drawing.Color.White;
            this.Archivo.Location = new System.Drawing.Point(0, 504);
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(320, 72);
            this.Archivo.TabIndex = 4;
            this.Archivo.Text = "HISTORIAL";
            this.Archivo.UseVisualStyleBackColor = true;
            this.Archivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // SubirReporte
            // 
            this.SubirReporte.BackColor = System.Drawing.Color.White;
            this.SubirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubirReporte.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubirReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.SubirReporte.Location = new System.Drawing.Point(0, 432);
            this.SubirReporte.Name = "SubirReporte";
            this.SubirReporte.Size = new System.Drawing.Size(320, 72);
            this.SubirReporte.TabIndex = 3;
            this.SubirReporte.Text = "ARCHIVO";
            this.SubirReporte.UseVisualStyleBackColor = false;
            this.SubirReporte.Click += new System.EventHandler(this.SubirReporte_Click);
            // 
            // REspera
            // 
            this.REspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REspera.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REspera.ForeColor = System.Drawing.Color.White;
            this.REspera.Location = new System.Drawing.Point(0, 360);
            this.REspera.Name = "REspera";
            this.REspera.Size = new System.Drawing.Size(320, 72);
            this.REspera.TabIndex = 2;
            this.REspera.Text = "REGISTRO DE ESPERA";
            this.REspera.UseVisualStyleBackColor = true;
            this.REspera.Click += new System.EventHandler(this.REspera_Click);
            // 
            // Inicio
            // 
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.ForeColor = System.Drawing.Color.White;
            this.Inicio.Location = new System.Drawing.Point(0, 288);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(320, 72);
            this.Inicio.TabIndex = 1;
            this.Inicio.Text = "INICIO";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 72);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(320, 144);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fondo
            // 
            this.Fondo.BackColor = System.Drawing.Color.White;
            this.Fondo.Controls.Add(this.button3);
            this.Fondo.Controls.Add(this.button2);
            this.Fondo.Controls.Add(this.button1);
            this.Fondo.Controls.Add(this.txtBusqueda);
            this.Fondo.Controls.Add(this.textBox3);
            this.Fondo.Controls.Add(this.label4);
            this.Fondo.Controls.Add(this.dgvDocs);
            this.Fondo.Controls.Add(this.textBox2);
            this.Fondo.Controls.Add(this.label3);
            this.Fondo.Controls.Add(this.textBox1);
            this.Fondo.Controls.Add(this.label2);
            this.Fondo.Controls.Add(this.label1);
            this.Fondo.Location = new System.Drawing.Point(321, 0);
            this.Fondo.Name = "Fondo";
            this.Fondo.Size = new System.Drawing.Size(1576, 1028);
            this.Fondo.TabIndex = 1;
            this.Fondo.Paint += new System.Windows.Forms.PaintEventHandler(this.Fondo_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(21, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 61);
            this.button3.TabIndex = 14;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 960);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1275, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 336);
            this.button1.TabIndex = 10;
            this.button1.Text = "SUBIR DOC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Montserrat", 22F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.txtBusqueda.Location = new System.Drawing.Point(178, 371);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(307, 61);
            this.txtBusqueda.TabIndex = 9;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Montserrat", 22F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.textBox3.Location = new System.Drawing.Point(398, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(471, 61);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 54);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID DE REPORTE";
            // 
            // dgvDocs
            // 
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDREPORTE,
            this.NombreP,
            this.IDPACIENTE,
            this.AbrirDoc});
            this.dgvDocs.Location = new System.Drawing.Point(21, 452);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 62;
            this.dgvDocs.RowTemplate.Height = 28;
            this.dgvDocs.Size = new System.Drawing.Size(1053, 502);
            this.dgvDocs.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 22F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.textBox2.Location = new System.Drawing.Point(562, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(684, 61);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(9, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE DE PACIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 22F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.textBox1.Location = new System.Drawing.Point(402, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 61);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(9, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID DE PACIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE REPORTES";
            // 
            // IDREPORTE
            // 
            this.IDREPORTE.HeaderText = "ID DE REPORTE";
            this.IDREPORTE.MinimumWidth = 8;
            this.IDREPORTE.Name = "IDREPORTE";
            this.IDREPORTE.ReadOnly = true;
            this.IDREPORTE.Width = 150;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "NOMBRE DEL PACIENTE";
            this.NombreP.MinimumWidth = 8;
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 150;
            // 
            // IDPACIENTE
            // 
            this.IDPACIENTE.HeaderText = "ID DE PACIENTE";
            this.IDPACIENTE.MinimumWidth = 8;
            this.IDPACIENTE.Name = "IDPACIENTE";
            this.IDPACIENTE.ReadOnly = true;
            this.IDPACIENTE.Width = 150;
            // 
            // AbrirDoc
            // 
            this.AbrirDoc.HeaderText = "Abrir Documento";
            this.AbrirDoc.MinimumWidth = 8;
            this.AbrirDoc.Name = "AbrirDoc";
            this.AbrirDoc.ReadOnly = true;
            this.AbrirDoc.Width = 150;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.Fondo);
            this.Controls.Add(this.NavBar);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "ALEJ - SUBIR DOCUMENTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SUBIR_DOCUMENTOS_Load);
            this.NavBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Fondo.ResumeLayout(false);
            this.Fondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel Fondo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button Archivo;
        private System.Windows.Forms.Button SubirReporte;
        private System.Windows.Forms.Button REspera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDREPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPACIENTE;
        private System.Windows.Forms.DataGridViewButtonColumn AbrirDoc;
    }
}