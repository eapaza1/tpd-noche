using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdNoche.entidad;

namespace TpdNoche.modelo
{
    public class VentaModelo
    {
        Conexion conexion;

        public string MsgError = "";
        public VentaModelo() { 
            conexion = new Conexion();
        
        }

        public int Create(EVenta data)
        {
            var con = conexion.getConexion;
            con.Open();
            MySqlTransaction mst = con.BeginTransaction();
            MySqlCommand cmd = con.CreateCommand();
            cmd.Transaction = mst;

            string tabla_venta = "venta";
            string tabla_dventa = "detalle_venta";
            try
            {                
                //empieza la primera operacion
                //insertar venta
                cmd.CommandText = $"INSERT INTO {tabla_venta} " +
                    $"(fecha_venta,cliente_id,total,tipo_pago" +
                    $",metodo_pago,observaciones) VALUES (" +
                    $"@fech,@cli,@tot,@tp,@mp,@obs)";

                cmd.Parameters.AddWithValue("@fech", data.Fecha_venta.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@cli", data.Cliente_id);
                cmd.Parameters.AddWithValue("@tot", data.Total);
                cmd.Parameters.AddWithValue("@tp", data.Tipo_pago);
                cmd.Parameters.AddWithValue("@mp", data.Metodo_pago);
                cmd.Parameters.AddWithValue("@obs", data.Observaciones);

              

                int res=cmd.ExecuteNonQuery();
                //termina la primera operacion
                if (res > 0 )
                {
                    //comienza segunda operacion
                    cmd.Parameters.Clear();

                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int id_venta=Convert.ToInt32(cmd.ExecuteScalar());
                    if (id_venta > 0)
                    {
                        int contador = 0;
                        foreach (var item in data.Detalles)
                        {
                            cmd.Parameters.Clear();
                            //EJECUCION DE INSERTAR DETALLE VENTA

                            cmd.CommandText = $"INSERT INTO {tabla_dventa} (" +
                                $"venta_id,producto_id,cantidad,precio) " +
                                $"VALUES (@vi,@pi,@c,@p) ";
                            cmd.Parameters.AddWithValue("@vi",id_venta);
                            cmd.Parameters.AddWithValue("@pi", item.Producto_id);
                            cmd.Parameters.AddWithValue("@c", item.Cantidad);
                            cmd.Parameters.AddWithValue("@p", item.Precio);
                            contador += cmd.ExecuteNonQuery();
                            

                            //actualizar stock producto
                            cmd.Parameters.Clear();
                            cmd.CommandText = "Update producto set stock=stock-@cantidad where id=@id";
                            cmd.Parameters.AddWithValue("@cantidad",  item.Cantidad);
                            cmd.Parameters.AddWithValue("@id",item.Producto_id);
                            cmd.ExecuteNonQuery();

                        }

                        if (contador == data.Detalles.Count)
                        {
                            mst.Commit();
                            return 1;
                        }
                    }
                }
                mst.Rollback();
                return 0;
            }
            catch (Exception ex)
            {
                mst.Rollback();
                MsgError=ex.Message;
                MessageBox.Show("error en modelo: " + ex.Message+ "codigo: "+ex.StackTrace);
                return -1;
            }

            //return 1===exitoso 
            //return -1======entro cacht //mensaje de eror
            //return 0====hubo algun errror no hay mensaje

        }
    }
}
