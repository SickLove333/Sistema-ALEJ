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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _1_Home_Load(object sender, EventArgs e)
        {
            
        }

        private void REspera_Click(object sender, EventArgs e)
        {
            Espera Espera = new Espera();
            Espera.Show();
            this.Hide();
        }

        private void SubirReporte_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Archivo_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            /*Registro Registro = new Registro();
            Registro.Show();
            this.Hide();*/
        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }
    }
}
