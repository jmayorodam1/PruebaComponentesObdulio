using Microsoft.Data.SqlClient;
using TiendaOrdenadoresAPI.ConsultasSQL;
using TiendaOrdenadoresAPI.Data;
using TiendaOrdenadoresAPI.Models;
using TiendaOrdenadoresAPI.Repository;

namespace TiendaOrdenadoresAPI.Services
{
    public class RepositorioOrdenadores : IRepositorio<Ordenador>
    {
        private readonly SqlConnection conexion;
        readonly ConsultasOrdenadores consulta;

        public RepositorioOrdenadores(Context context)
        {
            conexion = context.GetConnection();
            consulta = new ConsultasOrdenadores();
        }
        public List<Ordenador> ObtenerTodos()
        {
            var ordenadores = new List<Ordenador>();
            string sql = consulta.ObtenerTodos();
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            conexion.Close();
            return ordenadores;
        }

        public Ordenador? Obtener(int id)
        {
            Ordenador? pc;
            string sql = consulta.Obtener(id);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                pc = new Ordenador()
                {
                    Id = Convert.ToInt32(dataReader["Id"]),
                    PrecioTotal = (double)Convert.ToDecimal(dataReader["PrecioTotal"]),
                    CalorTotal = Convert.ToInt32(dataReader["CalorTotal"]),
                    CoresTotal = Convert.ToInt32(dataReader["CoresTotal"])

                };
            }
            else
            {
                pc = null;
            }
                conexion.Close();
                return pc;
            }
                
        

        public void Añadir(Ordenador item)
        {
            string sql = consulta.Añadir(item);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void Borrar(int id)
        {
            string sql = consulta.Borrar(id);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }

        public void Actualizar(Ordenador item)
        {
            string sql = consulta.Actualizar(item);
            SqlCommand command = new SqlCommand(sql, conexion);
            conexion.Open();
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
