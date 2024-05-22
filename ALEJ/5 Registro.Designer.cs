using ALEJ.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ALEJ
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgboxDoctor = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnEnviarEmpleado = new System.Windows.Forms.Button();
            this.txtPuestoEmpleado = new System.Windows.Forms.TextBox();
            this.lblPuestoEmpleado = new System.Windows.Forms.Label();
            this.txtContraseñaEmpleado = new System.Windows.Forms.TextBox();
            this.lblContraseñaEmpleado = new System.Windows.Forms.Label();
            this.txtUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.lblUsuarioEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoMaternoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoMaternoEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoPaternoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoPaternoEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgboxEmpleado = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnEnviarDoctor = new System.Windows.Forms.Button();
            this.txtCedulaDoctor = new System.Windows.Forms.TextBox();
            this.lblCedulaDoctor = new System.Windows.Forms.Label();
            this.txtPuestoDoctor = new System.Windows.Forms.TextBox();
            this.lblPuestoDoctor = new System.Windows.Forms.Label();
            this.txtContraseñaDoctor = new System.Windows.Forms.TextBox();
            this.lblContraseñaDoctor = new System.Windows.Forms.Label();
            this.txtUsuarioDoctor = new System.Windows.Forms.TextBox();
            this.lblUsuarioDoctor = new System.Windows.Forms.Label();
            this.txtApellidoMaternoDoctor = new System.Windows.Forms.TextBox();
            this.lblApellidoMaternoDoctor = new System.Windows.Forms.Label();
            this.txtApellidoPaternoDoctor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellidoPaternoDoctor = new System.Windows.Forms.Label();
            this.lblNombreDoctor = new System.Windows.Forms.Label();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxDoctor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.imgboxDoctor);
            this.panel1.Controls.Add(this.btnDoctor);
            this.panel1.Controls.Add(this.btnEnviarEmpleado);
            this.panel1.Controls.Add(this.txtPuestoEmpleado);
            this.panel1.Controls.Add(this.lblPuestoEmpleado);
            this.panel1.Controls.Add(this.txtContraseñaEmpleado);
            this.panel1.Controls.Add(this.lblContraseñaEmpleado);
            this.panel1.Controls.Add(this.txtUsuarioEmpleado);
            this.panel1.Controls.Add(this.lblUsuarioEmpleado);
            this.panel1.Controls.Add(this.txtApellidoMaternoEmpleado);
            this.panel1.Controls.Add(this.lblApellidoMaternoEmpleado);
            this.panel1.Controls.Add(this.txtApellidoPaternoEmpleado);
            this.panel1.Controls.Add(this.lblApellidoPaternoEmpleado);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.lblNombreEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 530);
            this.panel1.TabIndex = 0;
            // 
            // imgboxDoctor
            // 
            this.imgboxDoctor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.imgboxDoctor.Image = ((System.Drawing.Image)(resources.GetObject("imgboxDoctor.Image")));
            this.imgboxDoctor.Location = new System.Drawing.Point(97, 30);
            this.imgboxDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgboxDoctor.Name = "imgboxDoctor";
            this.imgboxDoctor.Size = new System.Drawing.Size(171, 171);
            this.imgboxDoctor.TabIndex = 23;
            this.imgboxDoctor.TabStop = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnDoctor.Location = new System.Drawing.Point(0, 0);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(375, 530);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnEnviarEmpleado
            // 
            this.btnEnviarEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEnviarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmpleado.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnEnviarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarEmpleado.Location = new System.Drawing.Point(39, 358);
            this.btnEnviarEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarEmpleado.Name = "btnEnviarEmpleado";
            this.btnEnviarEmpleado.Size = new System.Drawing.Size(133, 35);
            this.btnEnviarEmpleado.TabIndex = 21;
            this.btnEnviarEmpleado.Text = "Enviar";
            this.btnEnviarEmpleado.UseVisualStyleBackColor = false;
            // 
            // txtPuestoEmpleado
            // 
            this.txtPuestoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuestoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuestoEmpleado.Location = new System.Drawing.Point(39, 310);
            this.txtPuestoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPuestoEmpleado.Name = "txtPuestoEmpleado";
            this.txtPuestoEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtPuestoEmpleado.TabIndex = 20;
            // 
            // lblPuestoEmpleado
            // 
            this.lblPuestoEmpleado.AutoSize = true;
            this.lblPuestoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblPuestoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuestoEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblPuestoEmpleado.Location = new System.Drawing.Point(39, 289);
            this.lblPuestoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            this.lblPuestoEmpleado.Size = new System.Drawing.Size(64, 24);
            this.lblPuestoEmpleado.TabIndex = 20;
            this.lblPuestoEmpleado.Text = "Puesto";
            // 
            // txtContraseñaEmpleado
            // 
            this.txtContraseñaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaEmpleado.Location = new System.Drawing.Point(39, 256);
            this.txtContraseñaEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaEmpleado.Name = "txtContraseñaEmpleado";
            this.txtContraseñaEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtContraseñaEmpleado.TabIndex = 20;
            // 
            // lblContraseñaEmpleado
            // 
            this.lblContraseñaEmpleado.AutoSize = true;
            this.lblContraseñaEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContraseñaEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblContraseñaEmpleado.Location = new System.Drawing.Point(39, 234);
            this.lblContraseñaEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblContraseñaEmpleado.Name = "lblContraseñaEmpleado";
            this.lblContraseñaEmpleado.Size = new System.Drawing.Size(99, 24);
            this.lblContraseñaEmpleado.TabIndex = 20;
            this.lblContraseñaEmpleado.Text = "Contraseña";
            // 
            // txtUsuarioEmpleado
            // 
            this.txtUsuarioEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEmpleado.Location = new System.Drawing.Point(39, 202);
            this.txtUsuarioEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioEmpleado.Name = "txtUsuarioEmpleado";
            this.txtUsuarioEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtUsuarioEmpleado.TabIndex = 20;
            // 
            // lblUsuarioEmpleado
            // 
            this.lblUsuarioEmpleado.AutoSize = true;
            this.lblUsuarioEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuarioEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioEmpleado.Location = new System.Drawing.Point(39, 180);
            this.lblUsuarioEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuarioEmpleado.Name = "lblUsuarioEmpleado";
            this.lblUsuarioEmpleado.Size = new System.Drawing.Size(70, 24);
            this.lblUsuarioEmpleado.TabIndex = 20;
            this.lblUsuarioEmpleado.Text = "Usuario";
            // 
            // txtApellidoMaternoEmpleado
            // 
            this.txtApellidoMaternoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaternoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaternoEmpleado.Location = new System.Drawing.Point(39, 146);
            this.txtApellidoMaternoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaternoEmpleado.Name = "txtApellidoMaternoEmpleado";
            this.txtApellidoMaternoEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtApellidoMaternoEmpleado.TabIndex = 20;
            // 
            // lblApellidoMaternoEmpleado
            // 
            this.lblApellidoMaternoEmpleado.AutoSize = true;
            this.lblApellidoMaternoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoMaternoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoMaternoEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaternoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoMaternoEmpleado.Location = new System.Drawing.Point(39, 125);
            this.lblApellidoMaternoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoMaternoEmpleado.Name = "lblApellidoMaternoEmpleado";
            this.lblApellidoMaternoEmpleado.Size = new System.Drawing.Size(148, 24);
            this.lblApellidoMaternoEmpleado.TabIndex = 20;
            this.lblApellidoMaternoEmpleado.Text = "Apellido materno";
            // 
            // txtApellidoPaternoEmpleado
            // 
            this.txtApellidoPaternoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaternoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaternoEmpleado.Location = new System.Drawing.Point(39, 92);
            this.txtApellidoPaternoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaternoEmpleado.Name = "txtApellidoPaternoEmpleado";
            this.txtApellidoPaternoEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtApellidoPaternoEmpleado.TabIndex = 20;
            // 
            // lblApellidoPaternoEmpleado
            // 
            this.lblApellidoPaternoEmpleado.AutoSize = true;
            this.lblApellidoPaternoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoPaternoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoPaternoEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaternoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoPaternoEmpleado.Location = new System.Drawing.Point(39, 70);
            this.lblApellidoPaternoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoPaternoEmpleado.Name = "lblApellidoPaternoEmpleado";
            this.lblApellidoPaternoEmpleado.Size = new System.Drawing.Size(143, 24);
            this.lblApellidoPaternoEmpleado.TabIndex = 20;
            this.lblApellidoPaternoEmpleado.Text = "Apellido paterno";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(39, 39);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(317, 25);
            this.txtNombreEmpleado.TabIndex = 20;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(39, 18);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(76, 24);
            this.lblNombreEmpleado.TabIndex = 20;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.imgboxEmpleado);
            this.panel2.Controls.Add(this.btnEmpleado);
            this.panel2.Controls.Add(this.btnEnviarDoctor);
            this.panel2.Controls.Add(this.txtCedulaDoctor);
            this.panel2.Controls.Add(this.lblCedulaDoctor);
            this.panel2.Controls.Add(this.txtPuestoDoctor);
            this.panel2.Controls.Add(this.lblPuestoDoctor);
            this.panel2.Controls.Add(this.txtContraseñaDoctor);
            this.panel2.Controls.Add(this.lblContraseñaDoctor);
            this.panel2.Controls.Add(this.txtUsuarioDoctor);
            this.panel2.Controls.Add(this.lblUsuarioDoctor);
            this.panel2.Controls.Add(this.txtApellidoMaternoDoctor);
            this.panel2.Controls.Add(this.lblApellidoMaternoDoctor);
            this.panel2.Controls.Add(this.txtApellidoPaternoDoctor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblApellidoPaternoDoctor);
            this.panel2.Controls.Add(this.lblNombreDoctor);
            this.panel2.Controls.Add(this.txtNombreDoctor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 530);
            this.panel2.TabIndex = 1;
            // 
            // imgboxEmpleado
            // 
            this.imgboxEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.imgboxEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("imgboxEmpleado.Image")));
            this.imgboxEmpleado.Location = new System.Drawing.Point(99, 30);
            this.imgboxEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgboxEmpleado.Name = "imgboxEmpleado";
            this.imgboxEmpleado.Size = new System.Drawing.Size(171, 171);
            this.imgboxEmpleado.TabIndex = 24;
            this.imgboxEmpleado.TabStop = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(116)))), ((int)(((byte)(204)))));
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 2);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(375, 528);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnEnviarDoctor
            // 
            this.btnEnviarDoctor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEnviarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarDoctor.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btnEnviarDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarDoctor.Location = new System.Drawing.Point(35, 391);
            this.btnEnviarDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarDoctor.Name = "btnEnviarDoctor";
            this.btnEnviarDoctor.Size = new System.Drawing.Size(133, 35);
            this.btnEnviarDoctor.TabIndex = 22;
            this.btnEnviarDoctor.Text = "Enviar";
            this.btnEnviarDoctor.UseVisualStyleBackColor = false;
            // 
            // txtCedulaDoctor
            // 
            this.txtCedulaDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaDoctor.Location = new System.Drawing.Point(35, 362);
            this.txtCedulaDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedulaDoctor.Name = "txtCedulaDoctor";
            this.txtCedulaDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtCedulaDoctor.TabIndex = 19;
            // 
            // lblCedulaDoctor
            // 
            this.lblCedulaDoctor.AutoSize = true;
            this.lblCedulaDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblCedulaDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCedulaDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblCedulaDoctor.Location = new System.Drawing.Point(35, 340);
            this.lblCedulaDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblCedulaDoctor.Name = "lblCedulaDoctor";
            this.lblCedulaDoctor.Size = new System.Drawing.Size(157, 24);
            this.lblCedulaDoctor.TabIndex = 18;
            this.lblCedulaDoctor.Text = "Cédula Profesional";
            // 
            // txtPuestoDoctor
            // 
            this.txtPuestoDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuestoDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuestoDoctor.Location = new System.Drawing.Point(35, 310);
            this.txtPuestoDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPuestoDoctor.Name = "txtPuestoDoctor";
            this.txtPuestoDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtPuestoDoctor.TabIndex = 17;
            // 
            // lblPuestoDoctor
            // 
            this.lblPuestoDoctor.AutoSize = true;
            this.lblPuestoDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblPuestoDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuestoDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblPuestoDoctor.Location = new System.Drawing.Point(35, 289);
            this.lblPuestoDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblPuestoDoctor.Name = "lblPuestoDoctor";
            this.lblPuestoDoctor.Size = new System.Drawing.Size(64, 24);
            this.lblPuestoDoctor.TabIndex = 16;
            this.lblPuestoDoctor.Text = "Puesto";
            // 
            // txtContraseñaDoctor
            // 
            this.txtContraseñaDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseñaDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaDoctor.Location = new System.Drawing.Point(35, 256);
            this.txtContraseñaDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseñaDoctor.Name = "txtContraseñaDoctor";
            this.txtContraseñaDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtContraseñaDoctor.TabIndex = 15;
            // 
            // lblContraseñaDoctor
            // 
            this.lblContraseñaDoctor.AutoSize = true;
            this.lblContraseñaDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseñaDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContraseñaDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblContraseñaDoctor.Location = new System.Drawing.Point(35, 234);
            this.lblContraseñaDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblContraseñaDoctor.Name = "lblContraseñaDoctor";
            this.lblContraseñaDoctor.Size = new System.Drawing.Size(99, 24);
            this.lblContraseñaDoctor.TabIndex = 14;
            this.lblContraseñaDoctor.Text = "Contraseña";
            // 
            // txtUsuarioDoctor
            // 
            this.txtUsuarioDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioDoctor.Location = new System.Drawing.Point(35, 202);
            this.txtUsuarioDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioDoctor.Name = "txtUsuarioDoctor";
            this.txtUsuarioDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtUsuarioDoctor.TabIndex = 13;
            // 
            // lblUsuarioDoctor
            // 
            this.lblUsuarioDoctor.AutoSize = true;
            this.lblUsuarioDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuarioDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioDoctor.Location = new System.Drawing.Point(35, 180);
            this.lblUsuarioDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuarioDoctor.Name = "lblUsuarioDoctor";
            this.lblUsuarioDoctor.Size = new System.Drawing.Size(70, 24);
            this.lblUsuarioDoctor.TabIndex = 12;
            this.lblUsuarioDoctor.Text = "Usuario";
            // 
            // txtApellidoMaternoDoctor
            // 
            this.txtApellidoMaternoDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoMaternoDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoMaternoDoctor.Location = new System.Drawing.Point(35, 146);
            this.txtApellidoMaternoDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoMaternoDoctor.Name = "txtApellidoMaternoDoctor";
            this.txtApellidoMaternoDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtApellidoMaternoDoctor.TabIndex = 11;
            // 
            // lblApellidoMaternoDoctor
            // 
            this.lblApellidoMaternoDoctor.AutoSize = true;
            this.lblApellidoMaternoDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoMaternoDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoMaternoDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoMaternoDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoMaternoDoctor.Location = new System.Drawing.Point(35, 125);
            this.lblApellidoMaternoDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoMaternoDoctor.Name = "lblApellidoMaternoDoctor";
            this.lblApellidoMaternoDoctor.Size = new System.Drawing.Size(148, 24);
            this.lblApellidoMaternoDoctor.TabIndex = 10;
            this.lblApellidoMaternoDoctor.Text = "Apellido materno";
            // 
            // txtApellidoPaternoDoctor
            // 
            this.txtApellidoPaternoDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaternoDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaternoDoctor.Location = new System.Drawing.Point(35, 92);
            this.txtApellidoPaternoDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoPaternoDoctor.Name = "txtApellidoPaternoDoctor";
            this.txtApellidoPaternoDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtApellidoPaternoDoctor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 9;
            // 
            // lblApellidoPaternoDoctor
            // 
            this.lblApellidoPaternoDoctor.AutoSize = true;
            this.lblApellidoPaternoDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoPaternoDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoPaternoDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaternoDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoPaternoDoctor.Location = new System.Drawing.Point(35, 70);
            this.lblApellidoPaternoDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoPaternoDoctor.Name = "lblApellidoPaternoDoctor";
            this.lblApellidoPaternoDoctor.Size = new System.Drawing.Size(143, 24);
            this.lblApellidoPaternoDoctor.TabIndex = 6;
            this.lblApellidoPaternoDoctor.Text = "Apellido paterno";
            // 
            // lblNombreDoctor
            // 
            this.lblNombreDoctor.AutoSize = true;
            this.lblNombreDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreDoctor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblNombreDoctor.Location = new System.Drawing.Point(35, 18);
            this.lblNombreDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreDoctor.Name = "lblNombreDoctor";
            this.lblNombreDoctor.Size = new System.Drawing.Size(76, 24);
            this.lblNombreDoctor.TabIndex = 5;
            this.lblNombreDoctor.Text = "Nombre";
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoctor.Location = new System.Drawing.Point(35, 39);
            this.txtNombreDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(317, 25);
            this.txtNombreDoctor.TabIndex = 8;
            // 
            // Registro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxDoctor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgboxEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDoctor;
        private Button btnEmpleado;
        private Label lblNombreDoctor;
        private TextBox txtNombreDoctor;
        private Label label1;
        private TextBox txtApellidoPaternoDoctor;
        private Label lblApellidoPaternoDoctor;
        private TextBox txtApellidoMaternoDoctor;
        private Label lblApellidoMaternoDoctor;
        private Label lblUsuarioDoctor;
        private TextBox txtContraseñaDoctor;
        private Label lblContraseñaDoctor;
        private TextBox txtUsuarioDoctor;
        private TextBox txtCedulaDoctor;
        private Label lblCedulaDoctor;
        private TextBox txtPuestoDoctor;
        private Label lblPuestoDoctor;
        private Label lblNombreEmpleado;
        private TextBox txtApellidoPaternoEmpleado;
        private Label lblApellidoPaternoEmpleado;
        private TextBox txtNombreEmpleado;
        private TextBox txtPuestoEmpleado;
        private Label lblPuestoEmpleado;
        private TextBox txtContraseñaEmpleado;
        private Label lblContraseñaEmpleado;
        private TextBox txtUsuarioEmpleado;
        private Label lblUsuarioEmpleado;
        private TextBox txtApellidoMaternoEmpleado;
        private Label lblApellidoMaternoEmpleado;
        private Button btnEnviarEmpleado;
        private Button btnEnviarDoctor;
        private PictureBox imgboxDoctor;
        private PictureBox imgboxEmpleado;
    }
}