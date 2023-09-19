﻿namespace TiendaOrdenadoresAPI.ConsultasSQL
{  public interface IConsultas<T>
    {
        string ObtenerTodos();
        string Obtener(int id);
        string Añadir(T item);
        string Borrar(int id);
        string Actualizar(T element);
        string ObtenerUltimoId();
    }
}
