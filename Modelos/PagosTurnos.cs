using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class PagosTurnos
    {
        public int id { get; set; }
        public DateTime fechaPago { get; set; }
        public Turnos turno{ get; set; }
        public decimal monto { get; set; }
    }
}
