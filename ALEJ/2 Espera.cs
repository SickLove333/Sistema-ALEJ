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
    public partial class Espera : Form
    {
        public Espera()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombrePaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearRegistroDeEspera_Click(object sender, EventArgs e)
        {
            // Obtener valores de las TextBox.
            int idEstudio = Int32.Parse(txtIdEstudio.Text);
            // string nombreEstudio = txtNombreEstudio.Text;
            string precio = txtPrecio.Text;
            string nombrePaciente = txtNombrePaciente.Text;
            string apellidoPaciente = txtApellidoPaciente.Text;
            // string apellidoMaternoPaciente = txtApellidoMaternoPaciente.Text;
            // string sexoPaciente = txtSexoPaciente.Text;
            int idSexoPaciente = Int32.Parse(txtSexoPaciente.Text);
            string correoPaciente = txtCorreoPaciente.Text;
            string idEmpleado = txtIdEmpleado.Text;
            // string nombreEmpleado = txtNombreEmpleado.Text;
            // string apellidoEmpleado = txtApellidoEmpleado.Text;
            // string puestoEmpleado = txtPuestoEmpleado.Text;

            // Lógica para crear el registro de espera.

            try
            {
                Conexión objConnection = new Conexión();
                String query = "CALL sp_put_registro_de_espera(" +
                               $"'{nombrePaciente}'," +
                               $"'{apellidoPaciente}'," +
                               $"'{idSexoPaciente}'," +
                               $"'{correoPaciente}'," +
                               $"'{idEmpleado}'," +
                               $"'{idEstudio}'" +
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

                    // Limpiar las TextBox del formulario.
                    LimpiarFormulario();
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
                MessageBox.Show("Ocurrió un error: " + exception.ToString());
            }
        }

        private void LimpiarFormulario()
        {
            // Lista de todas las TextBox a limpiar.
            TextBox[] textBoxes = {
        txtIdEstudio, txtNombreEstudio, txtPrecio,
        txtNombrePaciente, txtApellidoPaciente, txtSexoPaciente,
        txtCorreoPaciente, txtIdEmpleado, txtNombreEmpleado,
        txtApellidoEmpleado, txtPuestoEmpleado
    };

            // Limpiar cada TextBox.
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario "Registro".
            Form1 HomeForm = new Form1();

            // Mostrar el formulario "Registro".
            HomeForm.Show();

            // Ocultar el formulario actual.
            this.Hide();
        }
    }
}


