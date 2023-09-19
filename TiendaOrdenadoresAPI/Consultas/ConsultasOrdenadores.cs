using TiendaOrdenadoresAPI.Models;

namespace TiendaOrdenadoresAPI.ConsultasSQL
{
    public class ConsultasOrdenadores : IConsultas<Ordenador>
    {
        public string ObtenerTodos()
        {
            return "Select * From Ordenador";
        }

        public string Obtener(int id)
        {
            return $"SELECT * FROM Ordenador WHERE Id = {id}";
        }

        public string Añadir(Ordenador item)
        {
            return "INSERT INTO Ordenador (Id,CalorTotal, PrecioTotal, MegasTotal,CoresTotal)" + 
                   "VALUES" +
                   $"('{item.Id}','{item.CalorTotal}', '{item.PrecioTotal}', '{(int)item.MegasTotal}','{(int)item.CoresTotal}')";
        }

        public string Borrar(int id)
        {
            return $"DELETE FROM Ordenador WHERE Id = {id}";
        }

        public string Actualizar(Ordenador item)
        {
            return "UPDATE Ordenador SET " +
                   
                   $"CalorTotal = '{(int)item.CalorTotal}'," +
                   $"PrecioTotal = '{item.PrecioTotal}'," +
                   $"CalorTotal = '{item.CalorTotal}'," +
                   $"CoresTotal = '{item.CoresTotal}'," +
                   $"WHERE Id = {item.Id}";
        }

        public string ObtenerUltimoId()
        {
            return "SELECT MAX(Id) AS Id FROM Ordenador";
        }
    }
}
