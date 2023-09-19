using Microsoft.Data.SqlClient;
using TiendaOrdenadoresAPI.ConsultasSQL;
using TiendaOrdenadoresAPI.Data;
using TiendaOrdenadoresAPI.Models;
using TiendaOrdenadoresAPI.Repository;

namespace TiendaOrdenadoresAPI.Services
{
    public class RepositorioComponentes : IRepositorio<Componente>
    {
        private readonly SqlConnection _conexion;
        private readonly ConsultasComponente _consultas;

        public RepositorioComponentes(Context contexto)
        {
            _conexion = contexto.GetConnection();
            _consultas = new ConsultasComponente();
        }

        public List<Componente> ObtenerTodos()
        {
            var componentes = new List<Componente>();
            string sql = _consultas.ObtenerTodos();

            using (var comando = new SqlCommand(sql, _conexion))
            {
                _conexion.Open();
                SqlDataReader lectorDatos = comando.ExecuteReader();

                while (lectorDatos.Read())
                {
                    componentes.Add(ObtenerComponenteDesdeLector(lectorDatos));
                }

                _conexion.Close();
            }

            return componentes;
        }

        public Componente? Obtener(int id)
        {
            Componente? componente = null;
            string sql = _consultas.Obtener(id);

            using (var comando = new SqlCommand(sql, _conexion))
            {
                _conexion.Open();
                SqlDataReader lectorDatos = comando.ExecuteReader();

                if (lectorDatos.Read())
                {
                    componente = ObtenerComponenteDesdeLector(lectorDatos);
                }

                _conexion.Close();
            }

            return componente;
        }

        public void Añadir(Componente componente)
        {
            string sql = _consultas.Añadir(componente);

            using (var comando = new SqlCommand(sql, _conexion))
            {
                _conexion.Open();
                comando.ExecuteNonQuery();
                _conexion.Close();
            }
        }

        public void Borrar(int id)
        {
            string sql = _consultas.Borrar(id);

            using (var comando = new SqlCommand(sql, _conexion))
            {
                _conexion.Open();
                comando.ExecuteNonQuery();
                _conexion.Close();
            }
        }

        public void Actualizar(Componente componente)
        {
            string sql = _consultas.Actualizar(componente);

            using (var comando = new SqlCommand(sql, _conexion))
            {
                _conexion.Open();
                comando.ExecuteNonQuery();
                _conexion.Close();
            }
        }

        private Componente ObtenerComponenteDesdeLector(SqlDataReader lector)
        {
            return new Componente()
            {
                Id = Convert.ToInt32(lector["Id"]),
                Calor = Convert.ToInt32(lector["Calor"]),
                Cores = Convert.ToInt32(lector["Cores"]),
                Coste = Convert.ToDouble(lector["Coste"]),
                Descripcion = Convert.ToString(lector["Descripcion"]),
                Megas = Convert.ToInt64(lector["Megas"]),
                NumeroSerie = Convert.ToString(lector["NumeroSerie"]),
            };
        }
    }

}
