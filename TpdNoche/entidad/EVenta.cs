using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdNoche.entidad
{
    public class EVenta
    {
        private int id,cliente_id;
        private DateTime fecha_venta;
        private double total;
        private string tipo_pago, metodo_pago, observaciones;

        private List<EDetalleVenta> detalles;


        public EVenta()
        {
        }

        public int Id { get => id; set => id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public DateTime Fecha_venta { get => fecha_venta; set => fecha_venta = value; }
        public double Total { get => total; set => total = value; }
        public string Tipo_pago { get => tipo_pago; set => tipo_pago = value; }
        public string Metodo_pago { get => metodo_pago; set => metodo_pago = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public List<EDetalleVenta> Detalles { get => detalles; set => detalles = value; }


        public void addItem(EDetalleVenta item)
        {
            if (detalles == null)
            {
                detalles= new List<EDetalleVenta>();
            }
            detalles.Add(item);
            //-=  =-
            total += item.Cantidad * item.Precio;
        }

        public void removeItem(int index)
        {        
            detalles.RemoveAt(index);
            updateItem(index);
        }

        public void updateItem(int index)
        {
            total = 0;
            foreach (var item in detalles)
            {
                total += item.Cantidad * item.Precio;
                
            }
        }

       


    }
}
