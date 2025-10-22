using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EspecializacionesMedicos
    {
        public int id { get; set; }
        public Medicos medico { get; set; }
        public Especializaciones especializacion { get; set; }
        public DateTime fechaTitulacion { get; set; }
        public string otros { get; set; }
    }
}
