using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _0_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario "Registro"
            //Registro registroForm = new Registro();

            // Mostrar el formulario "Registro"
            //registroForm.Show();

            // Ocultar la interfaz actual 
            //this.Hide();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //InterfazEmpleado interfazEmpleadoForm = new InterfazEmpleado();

            //interfazEmpleadoForm.Show();

            //this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
