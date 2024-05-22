using ALEJ.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEJ
{
    internal class BusquedaDocs
    {
        private ConexionMySql mConexion;
        private List<Doc> mDocs;

        public BusquedaDocs()
        {
            mConexion = new ConexionMySql();
            mDocs = new List<Doc>();
        }

        public bool agregarDoc(Doc mDoc)
        {
            string INSERT = "INSERT INTO producto (vc_nombre, id_reporte, id_paciente, file)" + " values (@nombre, @precio, @cantidad, @imagen);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@vc_nombre", mDoc.vc_nombre));
            mCommand.Parameters.Add(new MySqlParameter("@id_reporte", mDoc.id_reporte));
            mCommand.Parameters.Add(new MySqlParameter("@id_paciente", mDoc.id_paciente));
            mCommand.Parameters.Add(new MySqlParameter("@file", mDoc.file));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public List<Doc> getDocs(string filtro)
        {
            string CONSULTA = "SELECT * FROM //vc_media";

            MySqlDataReader mReader = null;
            Doc mDoc;
            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "id_reporte LIKE '%" + filtro + "%' OR " +
                        "CONCAT(vc_nombre, ' ', vc_apellido_paterno, ' ', vc_apellido_materno) LIKE '%" + filtro + "%' OR " +
                        "id_paciente LIKE '%" + filtro + "%';";

                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mDoc = new Doc();
                    mDoc.id_reporte = mReader.GetInt16("id_reporte");
                    mDoc.vc_nombre = mReader.GetString("nombre");
                    mDoc.id_reporte = mReader.GetInt16("precio");
                    mDoc.file = (byte[])mReader.GetValue(4);
                    mDoc.Add(mDoc);
                }
                mReader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mConexion.closeConexion();
            }

            return mDocs;
        }

        internal List<Doc> consultarDocs(string filtro)
        {
            
            throw new NotImplementedException();
            
        }
    }
}
