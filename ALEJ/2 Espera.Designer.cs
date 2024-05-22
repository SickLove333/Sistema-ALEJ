using System.Drawing;
using System.Windows.Forms;

namespace ALEJ
{
    partial class Espera
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
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.Registro_de_espera = new System.Windows.Forms.TabPage();
            this.lblPuestoEmpleado = new System.Windows.Forms.Label();
            this.txtPuestoEmpleado = new System.Windows.Forms.TextBox();
            this.txtCorreoPaciente = new System.Windows.Forms.TextBox();
            this.lblCorreoPaciente = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.txtSexoPaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombreEstudio = new System.Windows.Forms.TextBox();
            this.lblNombreEstudio = new System.Windows.Forms.Label();
            this.txtIdEstudio = new System.Windows.Forms.TextBox();
            this.lblIdEstudio = new System.Windows.Forms.Label();
            this.btnCrearRegistroDeEspera = new System.Windows.Forms.Button();
            this.Historial_de_paciente = new System.Windows.Forms.TabPage();
            this.Historial_de_consulta = new System.Windows.Forms.TabPage();
            this.Pestañas.SuspendLayout();
            this.Registro_de_espera.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pestañas
            // 
            this.Pestañas.Controls.Add(this.Registro_de_espera);
            this.Pestañas.Controls.Add(this.Historial_de_paciente);
            this.Pestañas.Controls.Add(this.Historial_de_consulta);
            this.Pestañas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pestañas.Location = new System.Drawing.Point(0, 0);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(900, 494);
            this.Pestañas.TabIndex = 0;
            // 
            // Registro_de_espera
            // 
            this.Registro_de_espera.BackColor = System.Drawing.Color.Gainsboro;
            this.Registro_de_espera.Controls.Add(this.lblPuestoEmpleado);
            this.Registro_de_espera.Controls.Add(this.txtPuestoEmpleado);
            this.Registro_de_espera.Controls.Add(this.txtCorreoPaciente);
            this.Registro_de_espera.Controls.Add(this.lblCorreoPaciente);
            this.Registro_de_espera.Controls.Add(this.lblApellidoEmpleado);
            this.Registro_de_espera.Controls.Add(this.txtApellidoEmpleado);
            this.Registro_de_espera.Controls.Add(this.lblNombreEmpleado);
            this.Registro_de_espera.Controls.Add(this.txtNombreEmpleado);
            this.Registro_de_espera.Controls.Add(this.lblIdEmpleado);
            this.Registro_de_espera.Controls.Add(this.txtIdEmpleado);
            this.Registro_de_espera.Controls.Add(this.lblSexoPaciente);
            this.Registro_de_espera.Controls.Add(this.txtSexoPaciente);
            this.Registro_de_espera.Controls.Add(this.txtApellidoPaciente);
            this.Registro_de_espera.Controls.Add(this.lblApellidoPaciente);
            this.Registro_de_espera.Controls.Add(this.txtNombrePaciente);
            this.Registro_de_espera.Controls.Add(this.lblNombrePaciente);
            this.Registro_de_espera.Controls.Add(this.txtPrecio);
            this.Registro_de_espera.Controls.Add(this.lblPrecio);
            this.Registro_de_espera.Controls.Add(this.txtNombreEstudio);
            this.Registro_de_espera.Controls.Add(this.lblNombreEstudio);
            this.Registro_de_espera.Controls.Add(this.txtIdEstudio);
            this.Registro_de_espera.Controls.Add(this.lblIdEstudio);
            this.Registro_de_espera.Controls.Add(this.btnCrearRegistroDeEspera);
            this.Registro_de_espera.Location = new System.Drawing.Point(4, 29);
            this.Registro_de_espera.Name = "Registro_de_espera";
            this.Registro_de_espera.Padding = new System.Windows.Forms.Padding(3);
            this.Registro_de_espera.Size = new System.Drawing.Size(892, 461);
            this.Registro_de_espera.TabIndex = 0;
            this.Registro_de_espera.Text = "Registro de espera";
            // 
            // lblPuestoEmpleado
            // 
            this.lblPuestoEmpleado.AutoSize = true;
            this.lblPuestoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblPuestoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPuestoEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblPuestoEmpleado.Location = new System.Drawing.Point(6, 420);
            this.lblPuestoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            this.lblPuestoEmpleado.Size = new System.Drawing.Size(182, 29);
            this.lblPuestoEmpleado.TabIndex = 28;
            this.lblPuestoEmpleado.Text = "Puesto empleado";
            // 
            // txtPuestoEmpleado
            // 
            this.txtPuestoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuestoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuestoEmpleado.Location = new System.Drawing.Point(190, 418);
            this.txtPuestoEmpleado.Name = "txtPuestoEmpleado";
            this.txtPuestoEmpleado.Size = new System.Drawing.Size(357, 30);
            this.txtPuestoEmpleado.TabIndex = 27;
            // 
            // txtCorreoPaciente
            // 
            this.txtCorreoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPaciente.Location = new System.Drawing.Point(190, 258);
            this.txtCorreoPaciente.Name = "txtCorreoPaciente";
            this.txtCorreoPaciente.Size = new System.Drawing.Size(357, 30);
            this.txtCorreoPaciente.TabIndex = 26;
            // 
            // lblCorreoPaciente
            // 
            this.lblCorreoPaciente.AutoSize = true;
            this.lblCorreoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCorreoPaciente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblCorreoPaciente.Location = new System.Drawing.Point(6, 260);
            this.lblCorreoPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblCorreoPaciente.Name = "lblCorreoPaciente";
            this.lblCorreoPaciente.Size = new System.Drawing.Size(169, 29);
            this.lblCorreoPaciente.TabIndex = 25;
            this.lblCorreoPaciente.Text = "Correo paciente";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(6, 380);
            this.lblApellidoEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(197, 29);
            this.lblApellidoEmpleado.TabIndex = 24;
            this.lblApellidoEmpleado.Text = "Apellido empleado";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(190, 378);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(357, 30);
            this.txtApellidoEmpleado.TabIndex = 23;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(6, 340);
            this.lblNombreEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(198, 29);
            this.lblNombreEmpleado.TabIndex = 22;
            this.lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(190, 338);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(357, 30);
            this.txtNombreEmpleado.TabIndex = 21;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblIdEmpleado.Location = new System.Drawing.Point(6, 300);
            this.lblIdEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(140, 29);
            this.lblIdEmpleado.TabIndex = 20;
            this.lblIdEmpleado.Text = "Id. Empleado";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(190, 298);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(357, 30);
            this.txtIdEmpleado.TabIndex = 19;
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblSexoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSexoPaciente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblSexoPaciente.Location = new System.Drawing.Point(6, 220);
            this.lblSexoPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(148, 29);
            this.lblSexoPaciente.TabIndex = 18;
            this.lblSexoPaciente.Text = "Sexo paciente";
            // 
            // txtSexoPaciente
            // 
            this.txtSexoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexoPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexoPaciente.Location = new System.Drawing.Point(190, 218);
            this.txtSexoPaciente.Name = "txtSexoPaciente";
            this.txtSexoPaciente.Size = new System.Drawing.Size(357, 30);
            this.txtSexoPaciente.TabIndex = 17;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaciente.Location = new System.Drawing.Point(190, 178);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(357, 30);
            this.txtApellidoPaciente.TabIndex = 16;
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellidoPaciente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(6, 180);
            this.lblApellidoPaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(181, 29);
            this.lblApellidoPaciente.TabIndex = 15;
            this.lblApellidoPaciente.Text = "Apellido paciente";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(190, 138);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(357, 30);
            this.txtNombrePaciente.TabIndex = 14;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePaciente.Location = new System.Drawing.Point(6, 140);
            this.lblNombrePaciente.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(182, 29);
            this.lblNombrePaciente.TabIndex = 13;
            this.lblNombrePaciente.Text = "Nombre paciente";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(190, 98);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(357, 30);
            this.txtPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(6, 100);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(73, 29);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNombreEstudio
            // 
            this.txtNombreEstudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEstudio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudio.Location = new System.Drawing.Point(190, 58);
            this.txtNombreEstudio.Name = "txtNombreEstudio";
            this.txtNombreEstudio.Size = new System.Drawing.Size(357, 30);
            this.txtNombreEstudio.TabIndex = 10;
            // 
            // lblNombreEstudio
            // 
            this.lblNombreEstudio.AutoSize = true;
            this.lblNombreEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreEstudio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudio.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEstudio.Location = new System.Drawing.Point(6, 60);
            this.lblNombreEstudio.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombreEstudio.Name = "lblNombreEstudio";
            this.lblNombreEstudio.Size = new System.Drawing.Size(83, 29);
            this.lblNombreEstudio.TabIndex = 9;
            this.lblNombreEstudio.Text = "Estudio";
            // 
            // txtIdEstudio
            // 
            this.txtIdEstudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEstudio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstudio.Location = new System.Drawing.Point(190, 18);
            this.txtIdEstudio.Name = "txtIdEstudio";
            this.txtIdEstudio.Size = new System.Drawing.Size(357, 30);
            this.txtIdEstudio.TabIndex = 8;
            // 
            // lblIdEstudio
            // 
            this.lblIdEstudio.AutoSize = true;
            this.lblIdEstudio.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdEstudio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEstudio.ForeColor = System.Drawing.Color.Black;
            this.lblIdEstudio.Location = new System.Drawing.Point(6, 20);
            this.lblIdEstudio.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdEstudio.Name = "lblIdEstudio";
            this.lblIdEstudio.Size = new System.Drawing.Size(113, 29);
            this.lblIdEstudio.TabIndex = 5;
            this.lblIdEstudio.Text = "Id. Estudio";
            // 
            // btnCrearRegistroDeEspera
            // 
            this.btnCrearRegistroDeEspera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearRegistroDeEspera.BackColor = System.Drawing.Color.LightGray;
            this.btnCrearRegistroDeEspera.Location = new System.Drawing.Point(771, 3);
            this.btnCrearRegistroDeEspera.Name = "btnCrearRegistroDeEspera";
            this.btnCrearRegistroDeEspera.Size = new System.Drawing.Size(117, 39);
            this.btnCrearRegistroDeEspera.TabIndex = 0;
            this.btnCrearRegistroDeEspera.Text = "Crear";
            this.btnCrearRegistroDeEspera.UseVisualStyleBackColor = false;
            // 
            // Historial_de_paciente
            // 
            this.Historial_de_paciente.Location = new System.Drawing.Point(4, 29);
            this.Historial_de_paciente.Name = "Historial_de_paciente";
            this.Historial_de_paciente.Padding = new System.Windows.Forms.Padding(3);
            this.Historial_de_paciente.Size = new System.Drawing.Size(892, 461);
            this.Historial_de_paciente.TabIndex = 1;
            this.Historial_de_paciente.Text = "Historial de paciente";
            this.Historial_de_paciente.UseVisualStyleBackColor = true;
            // 
            // Historial_de_consulta
            // 
            this.Historial_de_consulta.Location = new System.Drawing.Point(4, 29);
            this.Historial_de_consulta.Name = "Historial_de_consulta";
            this.Historial_de_consulta.Size = new System.Drawing.Size(892, 461);
            this.Historial_de_consulta.TabIndex = 2;
            this.Historial_de_consulta.Text = "Historial de consulta";
            this.Historial_de_consulta.UseVisualStyleBackColor = true;
            // 
            // Espera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 494);
            this.Controls.Add(this.Pestañas);
            this.Name = "Espera";
            this.ShowIcon = false;
            this.Text = "InterfazEmpleado";
            this.Pestañas.ResumeLayout(false);
            this.Registro_de_espera.ResumeLayout(false);
            this.Registro_de_espera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Registro_de_espera;
        private TabPage Historial_de_paciente;
        private TabPage Historial_de_consulta;
        private TabControl Pestañas;
        private Button btnCrearRegistroDeEspera;
        private Label lblIdEstudio;
        private TextBox txtIdEstudio;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombreEstudio;
        private Label lblNombreEstudio;
        private TextBox txtNombrePaciente;
        private Label lblNombrePaciente;
        private TextBox txtApellidoPaciente;
        private Label lblApellidoPaciente;
        private TextBox txtApellidoEmpleado;
        private Label lblNombreEmpleado;
        private TextBox txtNombreEmpleado;
        private Label lblIdEmpleado;
        private TextBox txtIdEmpleado;
        private Label lblSexoPaciente;
        private TextBox txtSexoPaciente;
        private TextBox txtCorreoPaciente;
        private Label lblCorreoPaciente;
        private Label lblApellidoEmpleado;
        private Label lblPuestoEmpleado;
        private TextBox txtPuestoEmpleado;
    }
}