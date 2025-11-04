using Microsoft.Reporting.WinForms;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioGimnasio
{
    public partial class PReporteActividadesClientes : Form
    {
        DtoActividadesClientes actividadSeleccionada = new DtoActividadesClientes();
        public PReporteActividadesClientes(DtoActividadesClientes actividadSeleccionada)
        {
            InitializeComponent();
            this.actividadSeleccionada = actividadSeleccionada;
        }

        private void PReporteActividadesClientes_Load(object sender, EventArgs e)
        {
            List<MDtoInforme> informe = new List<MDtoInforme>();
            List<DtoActividadesClientes> actividad = NActividadesClientes.GetDtoById(actividadSeleccionada.id);
            List<Pacientes> paciente = NActividadesClientes.GetClientes();

            informe = actividad.Select(x =>
            {

                Pacientes P = paciente.FirstOrDefault(i => i.dni == x.DniPaciente);
                string genero = P.genero == 1 ? "Hombre" : "Mujer";
                string telefono = P.telefono;

                return new MDtoInforme
                {
                    id = x.id,
                    numeroHistoriaClinica = x.numeroHistoriaClinica,
                    DniPaciente = x.DniPaciente,
                    NombreCompletoPaciente = x.NombreCompletoPaciente,
                    DescripcionActividad = x.DescripcionActividad,
                    FechaInicio = x.FechaInicio,
                    EstadoVigencia = x.EstadoVigencia,
                    genero = genero,
                    telefono = telefono
                };

            }).ToList();


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(
                    "DataSet1", informe
                ));



            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
    
}
