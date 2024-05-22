using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALEJ
{
    internal class Doc
    {
        internal object nombreP;

        public int id_reporte { get; set; }
        public string vc_nombre { get; set; }
        public int id_paciente { get; set; }        
        public byte[] file { get; set; }
        public object[] IDREPORTE { get; internal set; }
        public object IDPACIENTE { get; internal set; }

        internal void Add(Doc mDoc)
        {
            throw new NotImplementedException();
        }
    }
}