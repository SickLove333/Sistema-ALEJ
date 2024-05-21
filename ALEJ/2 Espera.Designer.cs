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
            Pestañas = new TabControl();
            Registro_de_espera = new TabPage();
            lblPuestoEmpleado = new Label();
            txtPuestoEmpleado = new TextBox();
            txtCorreoPaciente = new TextBox();
            lblCorreoPaciente = new Label();
            lblApellidoEmpleado = new Label();
            txtApellidoEmpleado = new TextBox();
            lblNombreEmpleado = new Label();
            txtNombreEmpleado = new TextBox();
            lblIdEmpleado = new Label();
            txtIdEmpleado = new TextBox();
            lblSexoPaciente = new Label();
            txtSexoPaciente = new TextBox();
            txtApellidoPaciente = new TextBox();
            lblApellidoPaciente = new Label();
            txtNombrePaciente = new TextBox();
            lblNombrePaciente = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombreEstudio = new TextBox();
            lblNombreEstudio = new Label();
            txtIdEstudio = new TextBox();
            lblIdEstudio = new Label();
            btnCrearRegistroDeEspera = new Button();
            Historial_de_paciente = new TabPage();
            Historial_de_consulta = new TabPage();
            Pestañas.SuspendLayout();
            Registro_de_espera.SuspendLayout();
            SuspendLayout();
            // 
            // Pestañas
            // 
            Pestañas.Controls.Add(Registro_de_espera);
            Pestañas.Controls.Add(Historial_de_paciente);
            Pestañas.Controls.Add(Historial_de_consulta);
            Pestañas.Dock = DockStyle.Fill;
            Pestañas.Location = new Point(0, 0);
            Pestañas.Name = "Pestañas";
            Pestañas.SelectedIndex = 0;
            Pestañas.Size = new Size(800, 494);
            Pestañas.TabIndex = 0;
            // 
            // Registro_de_espera
            // 
            Registro_de_espera.BackColor = Color.Gainsboro;
            Registro_de_espera.Controls.Add(lblPuestoEmpleado);
            Registro_de_espera.Controls.Add(txtPuestoEmpleado);
            Registro_de_espera.Controls.Add(txtCorreoPaciente);
            Registro_de_espera.Controls.Add(lblCorreoPaciente);
            Registro_de_espera.Controls.Add(lblApellidoEmpleado);
            Registro_de_espera.Controls.Add(txtApellidoEmpleado);
            Registro_de_espera.Controls.Add(lblNombreEmpleado);
            Registro_de_espera.Controls.Add(txtNombreEmpleado);
            Registro_de_espera.Controls.Add(lblIdEmpleado);
            Registro_de_espera.Controls.Add(txtIdEmpleado);
            Registro_de_espera.Controls.Add(lblSexoPaciente);
            Registro_de_espera.Controls.Add(txtSexoPaciente);
            Registro_de_espera.Controls.Add(txtApellidoPaciente);
            Registro_de_espera.Controls.Add(lblApellidoPaciente);
            Registro_de_espera.Controls.Add(txtNombrePaciente);
            Registro_de_espera.Controls.Add(lblNombrePaciente);
            Registro_de_espera.Controls.Add(txtPrecio);
            Registro_de_espera.Controls.Add(lblPrecio);
            Registro_de_espera.Controls.Add(txtNombreEstudio);
            Registro_de_espera.Controls.Add(lblNombreEstudio);
            Registro_de_espera.Controls.Add(txtIdEstudio);
            Registro_de_espera.Controls.Add(lblIdEstudio);
            Registro_de_espera.Controls.Add(btnCrearRegistroDeEspera);
            Registro_de_espera.Location = new Point(4, 29);
            Registro_de_espera.Name = "Registro_de_espera";
            Registro_de_espera.Padding = new Padding(3);
            Registro_de_espera.Size = new Size(792, 461);
            Registro_de_espera.TabIndex = 0;
            Registro_de_espera.Text = "Registro de espera";
            // 
            // lblPuestoEmpleado
            // 
            lblPuestoEmpleado.AutoSize = true;
            lblPuestoEmpleado.BackColor = Color.Transparent;
            lblPuestoEmpleado.FlatStyle = FlatStyle.Flat;
            lblPuestoEmpleado.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuestoEmpleado.ForeColor = Color.Black;
            lblPuestoEmpleado.Location = new Point(5, 420);
            lblPuestoEmpleado.Margin = new Padding(0);
            lblPuestoEmpleado.Name = "lblPuestoEmpleado";
            lblPuestoEmpleado.Size = new Size(149, 24);
            lblPuestoEmpleado.TabIndex = 28;
            lblPuestoEmpleado.Text = "Puesto empleado";
            // 
            // txtPuestoEmpleado
            // 
            txtPuestoEmpleado.BorderStyle = BorderStyle.None;
            txtPuestoEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPuestoEmpleado.Location = new Point(169, 418);
            txtPuestoEmpleado.Name = "txtPuestoEmpleado";
            txtPuestoEmpleado.Size = new Size(317, 25);
            txtPuestoEmpleado.TabIndex = 27;
            // 
            // txtCorreoPaciente
            // 
            txtCorreoPaciente.BorderStyle = BorderStyle.None;
            txtCorreoPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoPaciente.Location = new Point(169, 258);
            txtCorreoPaciente.Name = "txtCorreoPaciente";
            txtCorreoPaciente.Size = new Size(317, 25);
            txtCorreoPaciente.TabIndex = 26;
            // 
            // lblCorreoPaciente
            // 
            lblCorreoPaciente.AutoSize = true;
            lblCorreoPaciente.BackColor = Color.Transparent;
            lblCorreoPaciente.FlatStyle = FlatStyle.Flat;
            lblCorreoPaciente.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoPaciente.ForeColor = Color.Black;
            lblCorreoPaciente.Location = new Point(5, 260);
            lblCorreoPaciente.Margin = new Padding(0);
            lblCorreoPaciente.Name = "lblCorreoPaciente";
            lblCorreoPaciente.Size = new Size(135, 24);
            lblCorreoPaciente.TabIndex = 25;
            lblCorreoPaciente.Text = "Correo paciente";
            // 
            // lblApellidoEmpleado
            // 
            lblApellidoEmpleado.AutoSize = true;
            lblApellidoEmpleado.BackColor = Color.Transparent;
            lblApellidoEmpleado.FlatStyle = FlatStyle.Flat;
            lblApellidoEmpleado.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoEmpleado.ForeColor = Color.Black;
            lblApellidoEmpleado.Location = new Point(5, 380);
            lblApellidoEmpleado.Margin = new Padding(0);
            lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            lblApellidoEmpleado.Size = new Size(161, 24);
            lblApellidoEmpleado.TabIndex = 24;
            lblApellidoEmpleado.Text = "Apellido empleado";
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.BorderStyle = BorderStyle.None;
            txtApellidoEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoEmpleado.Location = new Point(169, 378);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(317, 25);
            txtApellidoEmpleado.TabIndex = 23;
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.BackColor = Color.Transparent;
            lblNombreEmpleado.FlatStyle = FlatStyle.Flat;
            lblNombreEmpleado.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEmpleado.ForeColor = Color.Black;
            lblNombreEmpleado.Location = new Point(5, 340);
            lblNombreEmpleado.Margin = new Padding(0);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(161, 24);
            lblNombreEmpleado.TabIndex = 22;
            lblNombreEmpleado.Text = "Nombre empleado";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.BorderStyle = BorderStyle.None;
            txtNombreEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEmpleado.Location = new Point(169, 338);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(317, 25);
            txtNombreEmpleado.TabIndex = 21;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.BackColor = Color.Transparent;
            lblIdEmpleado.FlatStyle = FlatStyle.Flat;
            lblIdEmpleado.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdEmpleado.ForeColor = Color.Black;
            lblIdEmpleado.Location = new Point(5, 300);
            lblIdEmpleado.Margin = new Padding(0);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(115, 24);
            lblIdEmpleado.TabIndex = 20;
            lblIdEmpleado.Text = "Id. Empleado";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.BorderStyle = BorderStyle.None;
            txtIdEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdEmpleado.Location = new Point(169, 298);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(317, 25);
            txtIdEmpleado.TabIndex = 19;
            // 
            // lblSexoPaciente
            // 
            lblSexoPaciente.AutoSize = true;
            lblSexoPaciente.BackColor = Color.Transparent;
            lblSexoPaciente.FlatStyle = FlatStyle.Flat;
            lblSexoPaciente.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexoPaciente.ForeColor = Color.Black;
            lblSexoPaciente.Location = new Point(5, 220);
            lblSexoPaciente.Margin = new Padding(0);
            lblSexoPaciente.Name = "lblSexoPaciente";
            lblSexoPaciente.Size = new Size(119, 24);
            lblSexoPaciente.TabIndex = 18;
            lblSexoPaciente.Text = "Sexo paciente";
            // 
            // txtSexoPaciente
            // 
            txtSexoPaciente.BorderStyle = BorderStyle.None;
            txtSexoPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSexoPaciente.Location = new Point(169, 218);
            txtSexoPaciente.Name = "txtSexoPaciente";
            txtSexoPaciente.Size = new Size(317, 25);
            txtSexoPaciente.TabIndex = 17;
            // 
            // txtApellidoPaciente
            // 
            txtApellidoPaciente.BorderStyle = BorderStyle.None;
            txtApellidoPaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaciente.Location = new Point(169, 178);
            txtApellidoPaciente.Name = "txtApellidoPaciente";
            txtApellidoPaciente.Size = new Size(317, 25);
            txtApellidoPaciente.TabIndex = 16;
            // 
            // lblApellidoPaciente
            // 
            lblApellidoPaciente.AutoSize = true;
            lblApellidoPaciente.BackColor = Color.Transparent;
            lblApellidoPaciente.FlatStyle = FlatStyle.Flat;
            lblApellidoPaciente.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoPaciente.ForeColor = Color.Black;
            lblApellidoPaciente.Location = new Point(5, 180);
            lblApellidoPaciente.Margin = new Padding(0);
            lblApellidoPaciente.Name = "lblApellidoPaciente";
            lblApellidoPaciente.Size = new Size(147, 24);
            lblApellidoPaciente.TabIndex = 15;
            lblApellidoPaciente.Text = "Apellido paciente";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.BorderStyle = BorderStyle.None;
            txtNombrePaciente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombrePaciente.Location = new Point(169, 138);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(317, 25);
            txtNombrePaciente.TabIndex = 14;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.BackColor = Color.Transparent;
            lblNombrePaciente.FlatStyle = FlatStyle.Flat;
            lblNombrePaciente.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePaciente.ForeColor = Color.Black;
            lblNombrePaciente.Location = new Point(5, 140);
            lblNombrePaciente.Margin = new Padding(0);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(147, 24);
            lblNombrePaciente.TabIndex = 13;
            lblNombrePaciente.Text = "Nombre paciente";
            lblNombrePaciente.Click += lblNombrePaciente_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(169, 98);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(317, 25);
            txtPrecio.TabIndex = 12;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.FlatStyle = FlatStyle.Flat;
            lblPrecio.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(5, 100);
            lblPrecio.Margin = new Padding(0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(58, 24);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // txtNombreEstudio
            // 
            txtNombreEstudio.BorderStyle = BorderStyle.None;
            txtNombreEstudio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEstudio.Location = new Point(169, 58);
            txtNombreEstudio.Name = "txtNombreEstudio";
            txtNombreEstudio.Size = new Size(317, 25);
            txtNombreEstudio.TabIndex = 10;
            // 
            // lblNombreEstudio
            // 
            lblNombreEstudio.AutoSize = true;
            lblNombreEstudio.BackColor = Color.Transparent;
            lblNombreEstudio.FlatStyle = FlatStyle.Flat;
            lblNombreEstudio.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEstudio.ForeColor = Color.Black;
            lblNombreEstudio.Location = new Point(5, 60);
            lblNombreEstudio.Margin = new Padding(0);
            lblNombreEstudio.Name = "lblNombreEstudio";
            lblNombreEstudio.Size = new Size(69, 24);
            lblNombreEstudio.TabIndex = 9;
            lblNombreEstudio.Text = "Estudio";
            // 
            // txtIdEstudio
            // 
            txtIdEstudio.BorderStyle = BorderStyle.None;
            txtIdEstudio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdEstudio.Location = new Point(169, 18);
            txtIdEstudio.Name = "txtIdEstudio";
            txtIdEstudio.Size = new Size(317, 25);
            txtIdEstudio.TabIndex = 8;
            // 
            // lblIdEstudio
            // 
            lblIdEstudio.AutoSize = true;
            lblIdEstudio.BackColor = Color.Transparent;
            lblIdEstudio.FlatStyle = FlatStyle.Flat;
            lblIdEstudio.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdEstudio.ForeColor = Color.Black;
            lblIdEstudio.Location = new Point(5, 20);
            lblIdEstudio.Margin = new Padding(0);
            lblIdEstudio.Name = "lblIdEstudio";
            lblIdEstudio.Size = new Size(94, 24);
            lblIdEstudio.TabIndex = 5;
            lblIdEstudio.Text = "Id. Estudio";
            lblIdEstudio.Click += label5_Click;
            // 
            // btnCrearRegistroDeEspera
            // 
            btnCrearRegistroDeEspera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCrearRegistroDeEspera.BackColor = Color.LightGray;
            btnCrearRegistroDeEspera.Location = new Point(685, 3);
            btnCrearRegistroDeEspera.Name = "btnCrearRegistroDeEspera";
            btnCrearRegistroDeEspera.Size = new Size(104, 39);
            btnCrearRegistroDeEspera.TabIndex = 0;
            btnCrearRegistroDeEspera.Text = "Crear";
            btnCrearRegistroDeEspera.UseVisualStyleBackColor = false;
            btnCrearRegistroDeEspera.Click += btnCrearRegistroDeEspera_Click;
            // 
            // Historial_de_paciente
            // 
            Historial_de_paciente.Location = new Point(4, 29);
            Historial_de_paciente.Name = "Historial_de_paciente";
            Historial_de_paciente.Padding = new Padding(3);
            Historial_de_paciente.Size = new Size(792, 461);
            Historial_de_paciente.TabIndex = 1;
            Historial_de_paciente.Text = "Historial de paciente";
            Historial_de_paciente.UseVisualStyleBackColor = true;
            // 
            // Historial_de_consulta
            // 
            Historial_de_consulta.Location = new Point(4, 29);
            Historial_de_consulta.Name = "Historial_de_consulta";
            Historial_de_consulta.Size = new Size(792, 461);
            Historial_de_consulta.TabIndex = 2;
            Historial_de_consulta.Text = "Historial de consulta";
            Historial_de_consulta.UseVisualStyleBackColor = true;
            // 
            // InterfazEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(Pestañas);
            Name = "InterfazEmpleado";
            Text = "InterfazEmpleado";
            Pestañas.ResumeLayout(false);
            Registro_de_espera.ResumeLayout(false);
            Registro_de_espera.PerformLayout();
            ResumeLayout(false);
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