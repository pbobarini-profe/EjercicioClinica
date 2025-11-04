using EjercicioGimnasio;
using Modelos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClinica
{
    public partial class PActividadesClientes : Form
    {
       
        List<DtoActividadesClientes> dtoActividades = new List<DtoActividadesClientes>();
        DtoActividadesClientes DtoActividadSeleccionada = new DtoActividadesClientes ();
        public PActividadesClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbHistoriasClinicas.Text != "" && cbVigente.Text != "" && dateTimePicker1.Text !="")
                {
                    HistoriasClinicas actividad = (HistoriasClinicas)cbHistoriasClinicas.SelectedItem;
                    Pacientes cliente = actividad.paciente;
                    DateTime fechaInicio = dateTimePicker1.Value;
                    int vigente = cbVigente.Text == "Vigente" ? 1 : 2;

                    ActividadesClientes ac = new ActividadesClientes()
                    {
                       
                        actividad = actividad,
                        cliente = cliente,
                        vigente = vigente,
                        fechaInicio = fechaInicio

                    };

                    NActividadesClientes.Create(ac);

                    Actualizar();

                    MessageBox.Show("Registro Agrgado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    throw new Exception("No puede tener campos vacios");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PActividadesClientes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void cbHistoriasClinicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            HistoriasClinicas h =(HistoriasClinicas) cbHistoriasClinicas.SelectedItem;
            
            if(h != null)
            {
                tbActividad.Text = h.descripcion;
                List<Pacientes> p = NActividadesClientes.GetClientes();
                foreach(var item in p) 
                {
                    if (h.paciente.id == item.id) 
                    {
                        tbDni.Text = item.dni;
                    }
                }
                
            }
  
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbHistoriasClinicas.Text != "" && cbVigente.Text != "" && dateTimePicker1.Text != "")
                {

                    DateTime fechaInicio = dateTimePicker1.Value;
                    int vigente = cbVigente.Text == "Vigente" ? 1 : 2;

                    ActividadesClientes actvidadUpdate = NActividadesClientes.GetById(DtoActividadSeleccionada.id);


                    actvidadUpdate.vigente = vigente;
                    actvidadUpdate.fechaInicio = fechaInicio;

                    NActividadesClientes.Update(actvidadUpdate);

                    Actualizar();

                    MessageBox.Show("Registro Modificado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    throw new Exception("No puede tener campos vacios");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DtoActividadSeleccionada = (DtoActividadesClientes)dtoActividadesClientesBindingSource.Current;

            if(DtoActividadSeleccionada != null) 
            {
                cbHistoriasClinicas.Text = DtoActividadSeleccionada.numeroHistoriaClinica.ToString();
                cbVigente.Text=DtoActividadSeleccionada.EstadoVigencia;
                dateTimePicker1.Value = DtoActividadSeleccionada.FechaInicio;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Desea Borrar el registro?", "Confirmacion Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    NActividadesClientes.Delete(DtoActividadSeleccionada.id);
                    MessageBox.Show("Registro Eliminado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    Actualizar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private  void Actualizar() 
        {
            dtoActividades = NActividadesClientes.GetDtoActividades();
            dtoActividadesClientesBindingSource.DataSource = dtoActividades;
            historiasClinicasBindingSource.DataSource = NActividadesClientes.GetActividad();

            cbHistoriasClinicas.SelectedIndex = -1;
            cbVigente.Text = string.Empty;
            tbActividad.Text = string.Empty;
            tbDni.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PReporteActividadesClientes r = new PReporteActividadesClientes (DtoActividadSeleccionada);
            r.Show();
        }
    }
    
}
