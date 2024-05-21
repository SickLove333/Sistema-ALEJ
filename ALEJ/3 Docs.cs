﻿using System;
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
    public partial class Form3 : Form
    {

        private List<Doc> mDocs;

        public Form3()
        {
            InitializeComponent();
        }

        private void SUBIR_DOCUMENTOS_Load(object sender, EventArgs e)
        {

        }

        private void Fondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void REspera_Click(object sender, EventArgs e)
        {
            Espera Espera = new Espera();
            Espera.Show();
            this.Hide();
        }

        private void SubirReporte_Click(object sender, EventArgs e)
        {
            
        }

        private void Archivo_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            Registro.Show();
            this.Hide();
        }

        private void ContinuarR_Click(object sender, EventArgs e)
        {
            Form3_1 form3_1 = new Form3_1();
            form3_1.Show();
            this.Hide();
        }

        private void NuevoR_Click(object sender, EventArgs e)
        {
            Form3_2 form3_2 = new Form3_2();
            form3_2.Show();
            this.Hide();
        }
    }
}
