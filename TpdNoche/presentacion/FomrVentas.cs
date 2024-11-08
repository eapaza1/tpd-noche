using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdNoche.negocio;
using TpdNoche.presentacion.Componentes;

namespace TpdNoche.presentacion
{
    public partial class FomrVentas : Form
    {
        NProducto negocio;
        public FomrVentas()
        {
            InitializeComponent();
            negocio = new NProducto();
            listarProductos();
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

        private void Card_btnAddClick(entidad.EProducto data, EventArgs e)
        {


            MessageBox.Show("Producto: -" + data.Nombre);
        }
    }
}
