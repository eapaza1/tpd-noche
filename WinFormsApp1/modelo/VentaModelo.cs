using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.modelo
{
    public class VentaModelo
    {
        Conexion conexion;
        public VentaModelo() { 
            conexion = new Conexion();
        
        }

        public void Create()
        {
            var conn = conexion.getConexion;

            conn.Open();

            MySqlTransaction mst = conn.BeginTransaction();

            MySqlCommand cmd = conn.CreateCommand();
            try
            {

         
           

           //INSERTAR VENTA
            cmd.Transaction = mst;

            cmd.CommandText = "";// sql para primera operacion

            cmd.Parameters.AddWithValue("@nombre", "Producto 1");
      
            cmd.ExecuteNonQuery();

            //INSERTAR DETALLE DE VENTA
            // Segunda operación 
            cmd.CommandText = "UPDATE product SET stock = stock - 10 WHERE id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", 1);
            cmd.ExecuteNonQuery();

                //INSERTAR EL REGISTRO
            mst.Commit();

            }catch (Exception ex)
            {

                mst.Rollback();


            }




        }
    }
}
