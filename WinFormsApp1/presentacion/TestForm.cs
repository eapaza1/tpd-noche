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
using TpdNoche.presentacion.Componentes;

namespace TpdNoche.presentacion
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            MostrarTodo();

        }

        private void MostrarTodo()
        {
            for (int i = 0; i < 10; i++)
            {
                EProducto item = new EProducto();
                item.Nombre = "Producto n " + i;
                item.Precio = i * 100;
                item.Descripcion = "Descripcion del producto n°: " + i;
                item.Stock = i;


                CardProduct product = new CardProduct();

                if (i % 2 == 0)
                {
                    product.CardPriceColor = Color.Blue;
                    product.CardButonBack = Color.Blue;
                    //product.CardColor = Color.Blue;
                }

                product.Item = item;

                if (item.Stock > 0)
                {
                    product.btnAddClick += agregarProducto;
                }
                product.btnMeGusta += botonMeguasta;


                panel_dinamico.Controls.Add(product);



            }

        }

        private void botonMeguasta(EProducto data, EventArgs e)
        {
            MessageBox.Show("desde boton me gusta El productos es: " + data.Nombre + " con precio: " + data.Precio);
        }

        private void agregarProducto(EProducto data, EventArgs e)
        {
            MessageBox.Show("El productos es: " + data.Nombre + " con precio: " + data.Precio);
        }

    }
}
