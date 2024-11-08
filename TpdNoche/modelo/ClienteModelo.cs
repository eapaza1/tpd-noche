using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TpdNoche.entidad;

namespace TpdNoche.modelo
{
    public class ClienteModelo
    {
        private Conexion conexion;
        private string tabla = "cliente";

        public ClienteModelo()
        {
            conexion = new Conexion();
        }

        // Crear cliente
        public int Create(ECliente data)
        {
            string query = $"INSERT INTO {tabla} (tipo_documento, nrodoc, nombre, direccion, telefono, estado, email) " +
                           "VALUES (@tipo_documento, @nrodoc, @nombre, @direccion, @telefono, @estado, @email)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@tipo_documento", data.Tipo_documento);
            cmd.Parameters.AddWithValue("@nrodoc", data.Nrodoc);
            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue("@direccion", data.Direccion);
            cmd.Parameters.AddWithValue("@telefono", data.Telefono);
            cmd.Parameters.AddWithValue("@estado", data.Estado);
            cmd.Parameters.AddWithValue("@email", data.Email);

            conexion.Open();
            int resultado = cmd.ExecuteNonQuery();
            conexion.Close();

            return resultado;
        }

        // Leer todos los clientes
        public List<ECliente> ReadAll()
        {
            List<ECliente> clientes = new List<ECliente>();
            string query = $"SELECT * FROM {tabla}";

            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ECliente cliente = new ECliente
                {
                    Id = reader.GetInt32("id"),
                    Tipo_documento = reader.GetInt32("tipo_documento"),
                    Nrodoc = reader.GetString("nrodoc"),
                    Nombre = reader.GetString("nombre"),
                    Direccion = reader.IsDBNull(reader.GetOrdinal("direccion")) ? null : reader.GetString("direccion"),
                    Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? null : reader.GetString("telefono"),
                    Estado = reader.GetInt32("estado"),
                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? null : reader.GetString("email")
                };

                clientes.Add(cliente);
            }

            reader.Close();
            conexion.Close();

            return clientes;
        }

        // Actualizar cliente
        public int Update(ECliente data)
        {
            string query = $"UPDATE {tabla} SET tipo_documento=@tipo_documento, nrodoc=@nrodoc, nombre=@nombre, " +
                           "direccion=@direccion, telefono=@telefono, estado=@estado, email=@email WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@tipo_documento", data.Tipo_documento);
            cmd.Parameters.AddWithValue("@nrodoc", data.Nrodoc);
            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue("@direccion", data.Direccion);
            cmd.Parameters.AddWithValue("@telefono", data.Telefono);
            cmd.Parameters.AddWithValue("@estado", data.Estado);
            cmd.Parameters.AddWithValue("@email", data.Email);
            cmd.Parameters.AddWithValue("@id", data.Id);

            conexion.Open();
            int resultado = cmd.ExecuteNonQuery();
            conexion.Close();

            return resultado;
        }

        // Eliminar cliente
        public int Delete(ECliente data)
        {
            string query = $"DELETE FROM {tabla} WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", data.Id);

            conexion.Open();
            int resultado = cmd.ExecuteNonQuery();
            conexion.Close();

            return resultado;
        }
    }
}
