using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DActividadesClientes
    {
        public static void Create(ActividadesClientes ac)
        {

            string sql = @"
                    INSERT INTO ActividadesClientes ( clienteId , actividadId , fechaInicio, vigente)
                    VALUES (  @clienteId  , @actividadId , @fechaInicio , @vigente )
                    ";

            using (SqlConnection cn = Db.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {


                    cmd.Parameters.Add("@clienteId ", System.Data.SqlDbType.Int).Value = ac.cliente.id;
                    cmd.Parameters.Add("@actividadId ", System.Data.SqlDbType.Int).Value = ac.actividad.id;
                    cmd.Parameters.Add("@fechaInicio", System.Data.SqlDbType.DateTime2).Value = ac.fechaInicio;
                    cmd.Parameters.Add("@vigente", System.Data.SqlDbType.Int).Value = ac.vigente;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<ActividadesClientes> GetAll()
        {
            List<ActividadesClientes> lista = new List<ActividadesClientes>();

            string sql = @"SELECT 
                AC.id, AC.FechaInicio, AC.Vigente, 
                P.id AS PacienteId, P.nombre AS PacienteNombre, P.apellido AS PacienteApellido, p.dni As PacienteDni,
                H.id AS HistoriaId, H.descripcion AS HistoriaDescripcion
                FROM ActividadesClientes AC
                INNER JOIN Pacientes P ON AC.clienteId = P.id  
                INNER JOIN HistoriasClinicas H ON AC.actividadId = H.id 
                ORDER BY AC.FechaInicio DESC;
                ";


            using (SqlConnection cn = Db.GetConnection())
            {

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            ActividadesClientes ac = new ActividadesClientes()
                            {
                                id = reader.GetInt32(0),
                                fechaInicio = reader.GetDateTime(1),
                                vigente = reader.GetInt32(2),

                                cliente = new Pacientes()
                                {
                                    id = reader.GetInt32(3),
                                    dni = reader.GetString(6),
                                    nombre = reader.GetString(4),
                                    apellido = reader.GetString(5),

                                },

                                actividad = new HistoriasClinicas()
                                {
                                    id = reader.GetInt32(7),
                                    descripcion = reader.GetString(8)
                                }


                            };

                            lista.Add(ac);
                        }
                    }

                }
            }

            return lista;
        }
        

        public static ActividadesClientes GetById(int id)
        {
            ActividadesClientes ac=null; 

            
            string sql = @"SELECT 
                        AC.id, AC.FechaInicio, AC.Vigente, 
                        P.id AS PacienteId, P.nombre AS PacienteNombre, P.apellido AS PacienteApellido, p.dni As PacienteDni,
                        H.id AS HistoriaId, H.descripcion AS HistoriaDescripcion
                        FROM ActividadesClientes AC
                        INNER JOIN Pacientes P ON AC.clienteId = P.id  
                        INNER JOIN HistoriasClinicas H ON AC.actividadId = H.id  
                        WHERE AC.id = @Id;"; 

            using (SqlConnection cn = Db.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    
                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                    cn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            ac = new ActividadesClientes()
                            {
                                id = reader.GetInt32(0),
                                fechaInicio = reader.GetDateTime(1),
                                vigente = reader.GetInt32(2),

                                cliente = new Pacientes()
                                {
                                    id = reader.GetInt32(3),
                                    nombre = reader.GetString(4),
                                    apellido = reader.GetString(5),
                                    dni = reader.GetString(6),
                                },

                                actividad = new HistoriasClinicas()
                                {
                                    id = reader.GetInt32(7),
                                    descripcion = reader.GetString(8)
                                }
                            };
                        }
                    }
                }
            }

            return ac;
        }


        public static void Update(ActividadesClientes ac)
        {
            
            string sql = @"
                            UPDATE ActividadesClientes
                            SET 
                                fechaInicio = @FechaInicio,
                                vigente = @Vigente
                            WHERE id = @Id;
                        ";
            //Creamos conexion sql
            using (SqlConnection cn = Db.GetConnection())
            {
                //creamos sql comand
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                { 
                    cmd.Parameters.Add("@FechaInicio",System.Data.SqlDbType.DateTime2).Value= ac.fechaInicio;
                    cmd.Parameters.Add("@Vigente", System.Data.SqlDbType.Int).Value = ac.vigente;
                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = ac.id;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void Delete(int id)
        {
            string sql = $@"DELETE FROM ActividadesClientes where id = @Id";
            
            using (SqlConnection cn = Db.GetConnection())
            {
               
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                }
            }
        }







        public static List<Pacientes> GetPacientes()
        {
            List<Pacientes> lista = new List<Pacientes>();
            string sql = @"Select * From Pacientes ";
            //Creamos conexion sql
            using (SqlConnection cn = Db.GetConnection())
            {
                //creamos sql comand
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    //objeto sql dataReader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Iterar cada registro
                        while (reader.Read())
                        {
                            Pacientes p = new Pacientes
                            {
                                id = reader.GetInt32(0),
                                dni = reader.GetString(1),
                                nombre = reader.GetString(2),
                                apellido= reader.GetString(3),
                                telefono = reader.GetString(4),
                                genero = reader.GetInt32(5),
                                fechaNacimiento = reader.GetDateTime(6)

                            };
                            lista.Add(p);
                        }
                    }


                }
            }

            return lista;
        }

        public static List<HistoriasClinicas> GetHc()
        {
            List<HistoriasClinicas> lista = new List<HistoriasClinicas>();
            string sql = @"Select * From HistoriasClinicas ";
            //Creamos conexion sql
            using (SqlConnection cn = Db.GetConnection())
            {
                //creamos sql comand
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cn.Open();
                    //objeto sql dataReader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Iterar cada registro
                        while (reader.Read())
                        {
                            HistoriasClinicas h = new HistoriasClinicas()
                            {
                                id = reader.GetInt32(0),
                                paciente = new Pacientes { id = reader.GetInt32(1)},
                                descripcion = reader.GetString(2),
                                fechaInicio = reader.GetDateTime(3)

                            };
                            lista.Add(h);
                        }
                    }


                }
            }

            return lista;
        }

    }
}
