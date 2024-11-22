using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdNoche.entidad;
using TpdNoche.negocio;
using TpdNoche.presentacion.Componentes;

namespace TpdNoche.presentacion
{
    public partial class FomrVentas : Form
    {
        NProducto negocio;

        EVenta eVenta;
        public FomrVentas()
        {
            InitializeComponent();
            negocio = new NProducto();
            listarProductos();

            //instanciar eventa
            eVenta = new EVenta();


            mostrarDetalles();
        }


        private void listarProductos()
        {
            var lista = negocio.ReadAll();
            foreach (var item in lista)
            {
                ItemProductoVenta card = new ItemProductoVenta();
                card.Item = item;
                card.eventAddCart += Card_btnAddClick;
                panel_productos.Controls.Add(card);
            }
        }

        private void Card_btnAddClick(EProducto data, EventArgs e)
        {
            EDetalleVenta detalle = new EDetalleVenta();
            detalle.Producto_id = data.Id;
            detalle.Cantidad = 1;
            detalle.Precio=data.Precio;
            detalle.Producto = data;
            eVenta.addItem(detalle);

            addItemVista(detalle,eVenta.Detalles.Count-1);
        }

        private void mostrarDetalles()
        {
            flp_detalle.Controls.Clear();
            VentaDetalleItem dd = new VentaDetalleItem();
            dd.BackColor = Color.White;
            flp_detalle.Controls.Add(dd);
            if (eVenta.Detalles != null)
            {
                int i = 0;
                foreach (var item in eVenta.Detalles)
                {
                    addItemVista(item, i);
                    i++;
                }
            }
            /*
            for (int j = 0; j < eVenta.Detalles.Count; j++)
            {
                var item = eVenta.Detalles[j];
                VentaDetalleItem diDetalle = new VentaDetalleItem();
                diDetalle.setItem(item, i);
                flp_detalle.Controls.Add(diDetalle);
            }*/

            lbl_total.Text=eVenta.Total.ToString("F2");

        }

        private void addItemVista(EDetalleVenta detalle,int indice)
        {
            VentaDetalleItem diDetalle = new VentaDetalleItem();
            diDetalle.setItem(detalle, indice);
            diDetalle.event_change += DiDetalle_event_change;
            diDetalle.event_delete += DiDetalle_event_delete;
            flp_detalle.Controls.Add(diDetalle);
        }

        private void DiDetalle_event_delete(EDetalleVenta data, int index, EventArgs e)
        {
            eVenta.removeItem(index);
            mostrarDetalles();
            
        }

        private void DiDetalle_event_change(EDetalleVenta data, int index, EventArgs e)
        {
            eVenta.updateItem(index);
            lbl_total.Text = eVenta.Total.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                eVenta.Cliente_id = 1;
                eVenta.Fecha_venta=DateTime.Now;
                eVenta.Metodo_pago = "adsfea";
                NVenta nVenta = new NVenta();
                nVenta.Create(eVenta);
            }
            catch (Exception ex) { 
                MessageBox.Show("error"+ex.Message);
            }
        }
    }
}
