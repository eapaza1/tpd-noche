using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.entidad
{
    public class EProducto
    {
        private int id;
        private string nombre, descripcion,categoria;
        private double precio, stock;
        private byte[] imagen;

        public EProducto()
        {
        }

        public EProducto(int id, string nombre, string descripcion, double precio, double stock, byte[] imagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.imagen = imagen;
        }


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Stock { get => stock; set => stock = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
