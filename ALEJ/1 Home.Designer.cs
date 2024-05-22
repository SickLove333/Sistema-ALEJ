namespace ALEJ
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NavBar = new System.Windows.Forms.Panel();
            this.Registro = new System.Windows.Forms.Button();
            this.Archivo = new System.Windows.Forms.Button();
            this.SubirReporte = new System.Windows.Forms.Button();
            this.REspera = new System.Windows.Forms.Button();
            this.Inicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.NavBar.TabIndex = 1;
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
            this.SubirReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubirReporte.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubirReporte.ForeColor = System.Drawing.Color.White;
            this.SubirReporte.Location = new System.Drawing.Point(0, 432);
            this.SubirReporte.Name = "SubirReporte";
            this.SubirReporte.Size = new System.Drawing.Size(320, 72);
            this.SubirReporte.TabIndex = 3;
            this.SubirReporte.Text = "ARCHIVO";
            this.SubirReporte.UseVisualStyleBackColor = true;
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
            this.Inicio.BackColor = System.Drawing.Color.White;
            this.Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.Inicio.Location = new System.Drawing.Point(0, 288);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(320, 72);
            this.Inicio.TabIndex = 1;
            this.Inicio.Text = "INICIO";
            this.Inicio.UseVisualStyleBackColor = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.NavBar);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ALEJ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._1_Home_Load);
            this.NavBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button Archivo;
        private System.Windows.Forms.Button SubirReporte;
        private System.Windows.Forms.Button REspera;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}