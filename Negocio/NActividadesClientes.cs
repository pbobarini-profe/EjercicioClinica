using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NActividadesClientes
    {
        public static void Create(ActividadesClientes p)
        {
            try
            {
                DActividadesClientes.Create(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

   /*     public static List<ActividadesClientes> Get()
        {
            try
            {
               return DActividadesClientes.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }*/
        public static ActividadesClientes GetById(int id)
        {
            try
            {
                return DActividadesClientes.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Update(ActividadesClientes ac)
        {
            try
            {
                DActividadesClientes.Update(ac);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Delete(int id)
        {
            try
            {
                DActividadesClientes.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static List<DtoActividadesClientes> GetDtoActividades() 
        {
            try
            {
                List<ActividadesClientes> listaAc =DActividadesClientes.GetAll();

                List<DtoActividadesClientes> listaDto = new List<DtoActividadesClientes>();

                foreach (var item in listaAc)
                {
                    DtoActividadesClientes dto = new DtoActividadesClientes
                    {
                        id = item.id,
                        numeroHistoriaClinica = item.actividad.id,
                        DniPaciente = item.cliente.dni,
                        NombreCompletoPaciente = $"{item.cliente.nombre} {item.cliente.apellido} ",
                        DescripcionActividad = item.actividad.descripcion,
                        FechaInicio = item.fechaInicio,
                        EstadoVigencia = item.vigente == 1 ? "vigente" : "caducada"

                    };

                    listaDto.Add(dto);

                }

                return listaDto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List <DtoActividadesClientes> GetDtoById(int id)
        {
            try
            {
                List<DtoActividadesClientes> listaDto = new List<DtoActividadesClientes>();
                
                ActividadesClientes ac = DActividadesClientes.GetById(id);

                if (ac == null)
                {
                    
                    throw new Exception($"El registro de actividad con ID {id} no fue encontrado.");
                }

                
                DtoActividadesClientes dto = new DtoActividadesClientes
                {
                    id = ac.id,
                    numeroHistoriaClinica = ac.actividad.id,
                    DniPaciente = ac.cliente.dni,
                    NombreCompletoPaciente = $"{ac.cliente.nombre} {ac.cliente.apellido}",
                    DescripcionActividad = ac.actividad.descripcion,
                    FechaInicio = ac.fechaInicio,
                    EstadoVigencia = ac.vigente == 1 ? "Vigente" : "Caducada"
                };

                listaDto.Add(dto);

                return listaDto;
            }
            catch (Exception ex)
            {
                
                throw new Exception($"Error en NActividadesClientes al obtener DTO por ID.", ex);
            }
        }


        public static List<Pacientes> GetClientes()
        {
            try
            {
                return DActividadesClientes.GetPacientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<HistoriasClinicas> GetActividad()
        {
            try
            {
                return DActividadesClientes.GetHc();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
