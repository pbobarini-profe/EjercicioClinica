using Modelos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DetallesHistoriasClinicasDatos
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["ClinicaDB"].ConnectionString;
        public List<DetallesHistoriasClinicas> Listar()
        {
            List<DetallesHistoriasClinicas> lista = new List<DetallesHistoriasClinicas>();
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT id, fecha, historiaClinicaId, medicoId, tipoEventoId, descripcion FROM DetallesHistoriasClinicas";
                SqlCommand cmd = new SqlCommand(query, conexion);
                conexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new DetallesHistoriasClinicas
                    {
                        id = dr.GetInt32(0),
                        fecha = dr.GetDateTime(1),
                        historiaClinica = new HistoriasClinicas { id = dr.GetInt32(2) },
                        medico = new Medicos { id = dr.GetInt32(3) },
                        tipoEvento = new Eventos { id = dr.GetInt32(4) },
                        descripcion = dr["descripcion"].ToString()
                    });
                }
            }
            return lista;
        }
        public DataTable ListarMedicos()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, nombre + ' ' + apellido AS NombreCompleto FROM Medicos", con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public DataTable ListarHistorias()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT H.id, P.nombre + ' ' + P.apellido AS Paciente FROM HistoriasClinicas H JOIN Pacientes P ON H.pacienteId = P.id", con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public DataTable ListarEventos()
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, descripcion FROM Eventos", con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public DataTable Filtrar(int? medicoId, int? historiaId, int? eventoId)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string sql = "SELECT D.id, D.fecha, D.historiaClinicaId, D.medicoId, D.tipoEventoId, D.descripcion, " +
                             "P.nombre + ' ' + P.apellido AS Paciente, M.nombre + ' ' + M.apellido AS Medico, E.descripcion AS TipoEvento " +
                             "FROM DetallesHistoriasClinicas D " +
                             "JOIN HistoriasClinicas H ON D.historiaClinicaId = H.id " +
                             "JOIN Pacientes P ON H.pacienteId = P.id " +
                             "JOIN Medicos M ON D.medicoId = M.id " +
                             "JOIN Eventos E ON D.tipoEventoId = E.id " +
                             "WHERE (@medicoId IS NULL OR D.medicoId = @medicoId) " +
                             "AND (@historiaId IS NULL OR D.historiaClinicaId = @historiaId) " +
                             "AND (@eventoId IS NULL OR D.tipoEventoId = @eventoId)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@medicoId", (object)medicoId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@historiaId", (object)historiaId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@eventoId", (object)eventoId ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        public bool Agregar(DetallesHistoriasClinicas detalle)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = @"INSERT INTO DetallesHistoriasClinicas (fecha, historiaClinicaId, medicoId, tipoEventoId, descripcion)
                                 VALUES (@fecha, @historiaClinicaId, @medicoId, @tipoEventoId, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fecha", detalle.fecha);
                cmd.Parameters.AddWithValue("@historiaClinicaId", detalle.historiaClinica.id);
                cmd.Parameters.AddWithValue("@medicoId", detalle.medico.id);
                cmd.Parameters.AddWithValue("@tipoEventoId", detalle.tipoEvento.id);
                cmd.Parameters.AddWithValue("@descripcion", detalle.descripcion ?? (object)DBNull.Value);
                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Modificar(DetallesHistoriasClinicas detalle)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = @"UPDATE DetallesHistoriasClinicas
                                 SET fecha=@fecha, historiaClinicaId=@historiaClinicaId, medicoId=@medicoId, tipoEventoId=@tipoEventoId, descripcion=@descripcion
                                 WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@fecha", detalle.fecha);
                cmd.Parameters.AddWithValue("@historiaClinicaId", detalle.historiaClinica.id);
                cmd.Parameters.AddWithValue("@medicoId", detalle.medico.id);
                cmd.Parameters.AddWithValue("@tipoEventoId", detalle.tipoEvento.id);
                cmd.Parameters.AddWithValue("@descripcion", detalle.descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@id", detalle.id);
                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM DetallesHistoriasClinicas WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
