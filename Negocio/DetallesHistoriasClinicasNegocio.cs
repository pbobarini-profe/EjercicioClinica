
using System.Collections.Generic;
using Datos;
using Modelos;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetallesHistoriasClinicasNegocio
    {
        private DetallesHistoriasClinicasDatos datos = new DetallesHistoriasClinicasDatos();

        public List<DetallesHistoriasClinicas> Listar()
        {
            return datos.Listar();
        }



        public DataTable ListarMedicos()
        {
            return datos.ListarMedicos();
        }

        public DataTable ListarHistorias()
        {
            return datos.ListarHistorias();
        }

        public DataTable ListarEventos()
        {
            return datos.ListarEventos();
        }



        public DataTable Filtrar(int? medicoId, int? historiaId, int? eventoId)
        {
            return datos.Filtrar(medicoId, historiaId, eventoId);
        }



        public bool Agregar(DetallesHistoriasClinicas detalle)
        {
            if (detalle == null) return false;
            if (detalle.historiaClinica.id <= 0 || detalle.medico.id <= 0) return false;
            return datos.Agregar(detalle);
        }

        public bool Modificar(DetallesHistoriasClinicas detalle)
        {
            if (detalle.id <= 0) return false;
            return datos.Modificar(detalle);
        }

        public bool Eliminar(int id)
        {
            if (id <= 0) return false;
            return datos.Eliminar(id);
        }
    }
}
