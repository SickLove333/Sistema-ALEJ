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
            //Login LoginForm = new Login();

            //LoginForm.Show();

            //this.Hide();
        }
        private void btnEnviarDoctor_Click(Object sender, EventArgs e)
        {
            //Login LoginForm = new Login();

            //LoginForm.Show();

            //this.Hide();
        }
    }
}
