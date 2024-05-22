using Microsoft.Win32;
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

namespace ALEJ
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            btnEmpleado.Visible = false;
            //imgboxDoctor.Visible = false;
            imgboxEmpleado.Visible = false;
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            btnDoctor.Visible = false;
            imgboxDoctor.Visible = false;
            //imgboxEmpleado.Visible = false;
        }

        private void btnEnviarEmpleado_Click(Object sender, EventArgs e)
        {
            // Obtener valores de las TextBox.
            string nombreEmpleado = txtNombreEmpleado.Text;
            string apellidoEmpleado = txtApellidoPaternoEmpleado.Text;
            string apellidoMaternoEmpleado = txtApellidoMaternoEmpleado.Text;
            string usuarioEmpleado = txtUsuarioEmpleado.Text;
            string contraseñaEmpleado = txtContraseñaEmpleado.Text;
            string puestoEmpleado = txtPuestoEmpleado.Text;
            
            try
            {
                Conexión objConnection = new Conexión();
                String query = "CALL sp_put_empleado(" +
                               $"'{nombreEmpleado}'," +
                               $"'{apellidoEmpleado}'," +
                               $"'{apellidoMaternoEmpleado}'," +
                               $"'{usuarioEmpleado}'," +
                               $"'{contraseñaEmpleado}'," +
                               $"'{puestoEmpleado}'" +
                               ");";
                MySqlCommand command = new MySqlCommand(query, objConnection.openConn());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Cerrar la conexión de lectura.
                    reader.Close();
                    objConnection.closeConn();
                    
                    // Mostrar mensaje de confirmación.
                    MessageBox.Show("Registro generado exitosamente.");
                    
                    // Login LoginForm = new Login();
                    // LoginForm.Show();
                    this.Hide();
                }
                else
                {
                    // Cerrar la conexión de lectura.
                    reader.Close();
                    objConnection.closeConn();
                    
                    MessageBox.Show("Ocurrió un error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error: "+exception.ToString());
            }
        }
        private void btnEnviarDoctor_Click(Object sender, EventArgs e)
        {
            // Obtener valores de las TextBox.
            string nombreDoctor = txtNombreDoctor.Text;
            string apellidoDoctor = txtApellidoPaternoDoctor.Text;
            string apellidoMaternoDoctor = txtApellidoMaternoDoctor.Text;
            string usuarioDoctor = txtUsuarioDoctor.Text;
            string contraseñaDoctor = txtContraseñaDoctor.Text;
            string puestoDoctor = txtPuestoDoctor.Text;
            string cédulaDoctor = txtCedulaDoctor.Text;
            
            try
            {
                Conexión objConnection = new Conexión();
                String query = "CALL sp_put_doctor(" +
                               $"'{nombreDoctor}'," +
                               $"'{apellidoDoctor}'," +
                               $"'{apellidoMaternoDoctor}'," +
                               $"'{usuarioDoctor}'," +
                               $"'{contraseñaDoctor}'," +
                               $"'{puestoDoctor}'," +
                               $"'{cédulaDoctor}'" +
                               ");";
                MySqlCommand command = new MySqlCommand(query, objConnection.openConn());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // Cerrar la conexión de lectura.
                    reader.Close();
                    objConnection.closeConn();
                    
                    // Mostrar mensaje de confirmación.
                    MessageBox.Show("Registro generado exitosamente.");
                    
                    // Login LoginForm = new Login();
                    // LoginForm.Show();
                    this.Hide();
                }
                else
                {
                    // Cerrar la conexión de lectura.
                    reader.Close();
                    objConnection.closeConn();
                    
                    MessageBox.Show("Ocurrió un error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error: "+exception.ToString());
            }
        }

        
    }
}
