using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALEJ.Objects;
using static System.Net.Mime.MediaTypeNames;

namespace ALEJ
{
    public partial class Form3 : Form
    {
        private Commun mCommun;
        private Doc mDoc;
        private List<Doc> mDocs;
        private BusquedaDocs mBusquedaDocs;


        public Form3()
        {
            InitializeComponent();
            mCommun = new Commun();
            mBusquedaDocs = new BusquedaDocs();
            mDoc = new Doc();
            mDocs = new List<Doc>();

            cargarDocs();
        }

        private void cargarDocs(string filtro = "")
        {
            dgvDocs.Rows.Clear();
            dgvDocs.Refresh();
            mDocs.Clear();
            mDocs = mBusquedaDocs.getDocs(filtro);

            for (int i = 0; i < mDocs.Count(); i++)
            {

                dgvDocs.RowTemplate.Height = Commun.ROW_HEIGTH;
                dgvDocs.Rows.Add(
                    mDocs[i].id_reporte,
                    mDocs[i].vc_nombre,
                    mDocs[i].id_paciente,
                    File.FromStream(new MemoryStream(mDocs[i].file)));
            }
        }

        






        //NavBar
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


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarDocs(txtBusqueda.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargarDocs();

            if (mBusquedaDocs.agregarDoc(mDoc))
            {
                MessageBox.Show("Documento agregado");
                cargarDocs();
            }
            else
                MessageBox.Show("Error al agregar el Documento");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.FileLocation = openFileDialog.FileName;
            }
        }
        private void CargarProductos(string filtro = "")
        {

            dgvDocs.Rows.Clear();
            dgvDocs.Refresh();
            mDocs.Clear();
            mDocs = mBusquedaDocs.consultarDocs(filtro);

            for (int i = 0; i < mDocs.Count(); i++)
            {

                dgvDocs.RowTemplate.Height = Commun.ROW_HEIGTH;
                dgvDocs.Rows.Add(
                    mDocs[i].IDREPORTE,
                    mDocs[i].nombreP,
                    mDocs[i].IDPACIENTE,
                    File.FromStream(new MemoryStream(mDocs[i].file)));
            }
        }
        private int getIDREPORTEIfExist()
        {
            if (!textBox3.Text.Trim().Equals(""))
            {
                if (int.TryParse(textBox3.Text.Trim(), out int IDREPORTE))
                    return IDREPORTE;
                else
                    return -1;
            }
            else
                return -1;
        }

        private void dgvDocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDocs.Rows[e.RowIndex];
            textBox3.Text = Convert.ToString(fila.Cells["IDREPORTE"].Value);
            textBox2.Text = Convert.ToString(fila.Cells["nombreP"].Value);
            textBox1.Text = Convert.ToString(fila.Cells["IDPACIENTE"].Value);

            Byte[] archivoBytes = (byte[])fila.Cells["archivo"].Value;

            string tempFilePath = Path.Combine(Path.GetTempPath(), "tempfile");
            File.WriteAllBytes(tempFilePath, archivoBytes);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
