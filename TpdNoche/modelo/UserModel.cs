using MySql.Data.MySqlClient;
using System.Collections.Generic;
using TpdNoche.entidad;

namespace TpdNoche.modelo
{
    public class UserModel
    {
        private Conexion conexion;

        private string tabla = "users";

        public UserModel()
        {
            conexion = new Conexion();
        }

        public int Create(EUser data)
        {
            string sql = $"INSERT INTO {tabla}(username,password,email) VALUES (@user,@pass,@email) ";

            MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion);

            cmd.Parameters.AddWithValue("@user",data.Username);
            cmd.Parameters.AddWithValue("@pass",data.Password);
            cmd.Parameters.AddWithValue("@email",data.Email);

            conexion.Open();

            int res=cmd.ExecuteNonQuery();
            return res;
            
        }
        public List<EUser> ReadAll()
        {
            List<EUser> list = new List<EUser>();
            string sql = "SELECT * FROM "+tabla;
            MySqlCommand cmd = new MySqlCommand(sql,conexion.getConexion);

            conexion.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EUser user = new EUser();
                user.Id = reader.GetInt32("id");
                user.Username = reader.GetString("username");
                user.Password = reader.GetString("password");
                user .Email = reader.GetString("email");
                list.Add(user);
            }

            reader.Close();

            return list;


        }
        public int Update(EUser data)
        {
            string sql = $"UPDATE {tabla} SET username=@user,password=@pass,email=@email WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql ,conexion.getConexion);
            cmd.Parameters.AddWithValue("@user", data.Username);
            cmd.Parameters.AddWithValue("@pass", data.Password);
            cmd.Parameters.AddWithValue("@email", data.Email);
            cmd.Parameters.AddWithValue("@id", data.Id);

            conexion.Open();
            int res=cmd.ExecuteNonQuery();
            return res;


        }
        public int Delete(EUser data)
        {
            string sql = $"DELETE FROM {tabla} WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql,conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", data.Id);
            conexion.Open();
            int res=cmd.ExecuteNonQuery();
            return res;
            //{tabla}
        }

        public EUser FindById(int id)
        {
            EUser user = new EUser();
            string sql = $"SELECT * FROM {tabla} WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql,conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            conexion.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {               
                user.Id = reader.GetInt32("id");
                user.Username = reader.GetString("username");
                user.Password = reader.GetString("password");
                user.Email = reader.GetString("email");
            }
            reader.Close();
            return user;
        }
        
        public EUser FindByUsername(string username)
        {
            EUser usuario= new EUser();
            string sql = $"SELECT * FROM {tabla} WHERE username=@username";

            var cmd = new MySqlCommand(sql, conexion.getConexion);

            cmd.Parameters.AddWithValue("@username", username);

            conexion.Open();
            var reader=cmd.ExecuteReader();
            if (reader.Read())
            {
                usuario.Id=reader.GetInt32("id");
                usuario.Username=reader.GetString("username");
                usuario.Password=reader.GetString("password");
                usuario.Email=reader.GetString("email");
            }
            reader.Close();
            return usuario;
        }
    }
}
