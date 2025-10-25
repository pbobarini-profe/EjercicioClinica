using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Tratamiento
    {
        public int id { get; set; }
        public DetallesHistoriasClinicas detalleHistoriaClinica { get; set; }
        public Medicamentos medicamento { get; set; }
        public decimal peso { get; set; }//graduacion del medicamento
        public DateTime fechaInicio { get; set; }
        public string descripcion { get; set; } //varchar(MAX)
        public TiposResultadosTratamientos resultado { get; set; }
    }
}
