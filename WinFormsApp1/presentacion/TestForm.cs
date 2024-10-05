using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                CardProduct product = new CardProduct();
                product.CardTitulo = "Componente " + i;
                product.CardDescripcion = "Descriupcion del compoente n°" + i;
                product.CardPrecio = "$ " + (i * 1000);
                if (i % 2 == 0)
                {
                    product.CardPriceColor = Color.Blue;
                    product.CardButonBack = Color.Blue;
                    //product.CardColor = Color.Blue;
                }

                product.CardAddClick += cardProduct1_CardAddClick;


                panel_dinamico.Controls.Add(product);



            }

        }


        private void cardProduct1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje desde add Card");
        }

        private void cardProduct1_CardAddClick(object data, EventArgs e)
        {
            MessageBox.Show("mensaje desde add Card con data: "+ data.ToString());
        }
    }
}
