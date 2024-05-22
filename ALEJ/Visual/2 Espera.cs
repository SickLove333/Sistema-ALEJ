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

        /*private void btnCrearRegistroDeEspera_Click(object sender, EventArgs e)
        {

        }*/
        private void btnCrearRegistroDeEspera_Click(object sender, EventArgs e)
        {
            // Obtener valores de las TextBox.
            string idEstudio = txtIdEstudio.Text;
            string nombreEstudio = txtNombreEstudio.Text;
            string precio = txtPrecio.Text;
            string nombrePaciente = txtNombrePaciente.Text;
            string apellidoPaciente = txtApellidoPaciente.Text;
            string sexoPaciente = txtSexoPaciente.Text;
            string correoPaciente = txtCorreoPaciente.Text;
            string idEmpleado = txtIdEmpleado.Text;
            string nombreEmpleado = txtNombreEmpleado.Text;
            string apellidoEmpleado = txtApellidoEmpleado.Text;
            string puestoEmpleado = txtPuestoEmpleado.Text;

            // Lógica para crear el registro de espera.
            // ...

            // Mostrar mensaje de confirmación.
            MessageBox.Show("Registro generado exitosamente.");

            // Limpiar las TextBox del formulario.
            LimpiarFormulario();
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

    }
}


