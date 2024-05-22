using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ALEJ.Clases;

namespace _0_Login
{
    public partial class LoginALJE : Form
    {
        public LoginALJE()
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
            
            // Lógica para login de empleado usando la db
            
            // Obtener valores de las TextBox.
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            // string contraseña = CreateMD5(textBox2.Text); // Convertimos a MD5 para seguridad
            
            try
            {
                Conexión objConnection = new Conexión();
                String query = $"CALL sp_get_login_empleado('{usuario}', '{contraseña}');";
                MySqlCommand command = new MySqlCommand(query, objConnection.openConn());
                MySqlDataReader reader = command.ExecuteReader();
                // MessageBox.Show("Se inicia sesión correctamente");
                if(reader.Read()){
                    // MessageBox.Show("Resultado: " + reader.GetString(0));
            
                    //InterfazEmpleado interfazEmpleadoForm = new InterfazEmpleado();

                    //interfazEmpleadoForm.Show();

                    this.Hide();
                }
                objConnection.closeConn();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error: "+exception.ToString());
            }
            // Fin
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void closebtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        /*
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes); // .NET 5 +
            }
        }
        */
    }
}
