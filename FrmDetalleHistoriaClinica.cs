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
using Modelos;



namespace EjercicioClinica
{
    public partial class FrmDetalleHistoriaClinica : Form
    {
        private DetallesHistoriasClinicasNegocio negocio = new DetallesHistoriasClinicasNegocio();

        public FrmDetalleHistoriaClinica()
        {
            InitializeComponent();
            // Cargar combos y tabla al inicio de la forma para que la grilla se muestre inmediatamente
            CargarCombos();
            CargarTabla();
        }

       

        private void CargarDatos()
        {
            dgvDetalles.DataSource = negocio.Listar();
        }
        private void Actualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }


        private void FrmDetallesHistoriasClinicas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarTabla();
        }

        private void CargarCombos()
        {
            cbMedico.DataSource = negocio.ListarMedicos();
            cbMedico.DisplayMember = "NombreCompleto";
            cbMedico.ValueMember = "id";
            cbMedico.SelectedIndex = -1;

            cbHistoria.DataSource = negocio.ListarHistorias();
            cbHistoria.DisplayMember = "Paciente";
            cbHistoria.ValueMember = "id";
            cbHistoria.SelectedIndex = -1;

            cbEvento.DataSource = negocio.ListarEventos();
            cbEvento.DisplayMember = "descripcion";
            cbEvento.ValueMember = "id";
            cbEvento.SelectedIndex = -1;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int? medicoId = cbMedico.SelectedIndex >= 0 ? (int?)cbMedico.SelectedValue : null;
            int? historiaId = cbHistoria.SelectedIndex >= 0 ? (int?)cbHistoria.SelectedValue : null;
            int? eventoId = cbEvento.SelectedIndex >= 0 ? (int?)cbEvento.SelectedValue : null;

            dgvDetalles.DataSource = negocio.Filtrar(medicoId, historiaId, eventoId);
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            cbMedico.SelectedIndex = -1;
            cbHistoria.SelectedIndex = -1;
            cbEvento.SelectedIndex = -1;
            CargarTabla();
        }
        private void CargarTabla()
        {
            dgvDetalles.DataSource = negocio.Listar();
        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalle = new DetallesHistoriasClinicas
            {
                fecha = dtpFecha.Value,
                historiaClinica = new HistoriasClinicas { id = int.Parse(txtHistoriaClinicaId.Text) },
                medico = new Medicos { id = int.Parse(txtMedicoId.Text) },
                tipoEvento = new Eventos { id = int.Parse(txtTipoEventoId.Text) },
                descripcion = txtDescripcion.Text
            };

            negocio.Agregar(detalle);
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                var detalle = (DetallesHistoriasClinicas)dgvDetalles.CurrentRow.DataBoundItem;
                detalle.fecha = dtpFecha.Value;
                detalle.historiaClinica = new HistoriasClinicas { id = int.Parse(txtHistoriaClinicaId.Text) };
                detalle.medico = new Medicos { id = int.Parse(txtMedicoId.Text) };
                detalle.tipoEvento = new Eventos { id = int.Parse(txtTipoEventoId.Text) };
                detalle.descripcion = txtDescripcion.Text;

                negocio.Modificar(detalle);
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                var detalle = (DetallesHistoriasClinicas)dgvDetalles.CurrentRow.DataBoundItem;
                negocio.Eliminar(detalle.id);
                CargarDatos();
            }
        }

        private void FrmDetalleHistoriaClinica_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ejercicioClinicaDataSet3.DetallesHistoriasClinicas' Puede moverla o quitarla según sea necesario.
            // this.detallesHistoriasClinicasTableAdapter.Fill(this.ejercicioClinicaDataSet3.DetallesHistoriasClinicas);
            // TODO: esta línea de código carga datos en la tabla 'ejercicioClinicaDataSet2.HistoriasClinicas' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'ejercicioClinicaDataSet1.DetallesHistoriasClinicas' Puede moverla o quitarla según sea necesario.

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMedicoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void detallesHistoriasClinicasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbHistoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMostrarTodo_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtHistoriaClinicaId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
