using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.entidad
{
    public class EDetalleVenta
    {
        private int id, venta_id, producto_id;
        private double cantidad, precio;

        public EDetalleVenta()
        {

        }

        public EDetalleVenta(int producto_id, double cantidad, double precio)
        {
            this.producto_id = producto_id;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public int Venta_id { get => venta_id; set => venta_id = value; }
        public int Producto_id { get => producto_id; set => producto_id = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
