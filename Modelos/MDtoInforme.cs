using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MDtoInforme
    {
        public int id { get; set; }
        public int numeroHistoriaClinica { get; set; }
        public string DniPaciente { get; set; }
        public string NombreCompletoPaciente { get; set; }
        public string DescripcionActividad { get; set; }
        public DateTime FechaInicio { get; set; }
        public string EstadoVigencia { get; set; }
        public string telefono { get; set; }
        public string genero { get; set; } // 1-hombre | 2-mujer
    }
}
