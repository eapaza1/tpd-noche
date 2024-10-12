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

namespace TpdNoche.presentacion.Componentes
{
    public partial class CardProduct : UserControl
    {
        private EProducto item;

        public delegate void EventoClick(EProducto data, EventArgs e);


        public event EventoClick btnAddClick;
        public event EventoClick btnMeGusta;


        public CardProduct()
        {
            InitializeComponent();
        }

        public EProducto Item
        {
            get => item;
            set
            {
                item = value;
                mostrar();
            }

        }

        private void mostrar()
        {
            lbl_titulo.Text = item.Nombre;
            lbl_descripcion.Text = item.Descripcion;
            lbl_precio.Text = item.Precio.ToString();

            //mostra la imagen
            using(MemoryStream ms = new MemoryStream(item.Imagen))
            {
                Image imagen= Image.FromStream(ms);
                img_producto.Image = imagen;
            }
        }

        public Color CardButonBack
        {
            get => btn_add.BackColor;
            set => btn_add.BackColor = value;
        }
        public Color CardPriceColor
        {
            get => lbl_precio.ForeColor;
            set => lbl_precio.ForeColor = value;
        }

        public Color CardColor
        {
            get => btn_add.BackColor;

            set
            {
                btn_add.BackColor = value;
                lbl_precio.ForeColor = value;

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (btnAddClick!=null)
            {
                btnAddClick(item, e);

            }
            
        }

        private void btn_me_gusta_Click(object sender, EventArgs e)
        {
            // (1>2)?"valor verdadero":"valor si falso"
            btnMeGusta?.Invoke(item, e);
        }
    }
}
