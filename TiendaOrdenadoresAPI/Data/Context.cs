﻿using Microsoft.Data.SqlClient;


namespace TiendaOrdenadoresAPI.Data
{
    public class Context
    {
        private readonly SqlConnection _connection;

        public Context(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
