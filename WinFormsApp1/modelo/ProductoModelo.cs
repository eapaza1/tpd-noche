using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdNoche.entidad;

namespace TpdNoche.modelo
{
    public class ProductoModelo
    {
        private Conexion conexion;
        private string tabla = "producto";
        public ProductoModelo() {

            conexion = new Conexion();

        }

        public int Create(EProducto data)
        {
            string query = $"INSERT INTO {tabla}(nombre,descripcion," +
                $"precio,stock,imagen,categoria) VALUES(" +
                $"@nombre,@desc,@precio,@stock,@imagen,@categoria)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);

            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue("@desc", data.Descripcion);
            cmd.Parameters.AddWithValue("@precio", data.Precio);
            cmd.Parameters.AddWithValue("@stock", data.Stock);
            cmd.Parameters.AddWithValue("@imagen", data.Imagen);
            cmd.Parameters.AddWithValue("@categoria", data.Categoria);

            conexion.Open();

            return cmd.ExecuteNonQuery();

        }

        public List<EProducto> ReadAll()
        {
            List<EProducto> productos= new List<EProducto>();

            string query = "SELECT * FROM "+tabla;

            MySqlCommand cmd = new MySqlCommand(query,conexion.getConexion);
            conexion.Open();


            var reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                EProducto row= new EProducto();
                row.Id = reader.GetInt32("id");
                row.Nombre = reader.GetString("nombre");
                row.Descripcion = reader.GetString("descripcion");
                row.Precio = reader.GetDouble("precio");
                row.Stock = reader.GetDouble("precio");
                row.Categoria = reader.GetString("categoria");

                row.Imagen = getData(reader,"imagen");

                productos.Add(row);

            }

            reader.Close();

            return productos;
        }

        public int Update(EProducto data)
        {
            string sql = $"UPDATE {tabla} SET nombre=@nombre,descripcion=@desc,precio=@precio,stock=@stock,imagen=@imagen,categoria=@categoria" +
                $" WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql,conexion.getConexion);
            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue("@desc", data.Descripcion);
            cmd.Parameters.AddWithValue("@precio", data.Precio);
            cmd.Parameters.AddWithValue("@stock", data.Stock);
            cmd.Parameters.AddWithValue("@imagen", data.Imagen);
            cmd.Parameters.AddWithValue("@categoria", data.Categoria);
            cmd.Parameters.AddWithValue("@id", data.Id);

            conexion.Open();

            return cmd.ExecuteNonQuery();

        }

        public int Delete(EProducto data)
        {
            string sql = $"DELETE FROM {tabla} WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql ,conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", data.Id);
            conexion .Open();
            return cmd.ExecuteNonQuery();
        }

        private byte[] getData(MySqlDataReader reader,String columna)
        {
            // row.Imagen = reader.GetByte("imagen");
            long length = reader.GetBytes(reader.GetOrdinal(columna), 0, null, 0, 0);
            // Obtener la longitud de los bytes
            byte[] imageData = new byte[length];
            // Crear un array de bytes para almacenar la imagen

            reader.GetBytes(reader.GetOrdinal(columna), 0, imageData, 0, (int)length); // Leer la imagen desde la base de datos
            return imageData;
        }

        

    }
}
