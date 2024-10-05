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
        EUser item;
        //personalizacion de evento
        public delegate void CardAddEvent(object data,EventArgs e);
        //declaracion de Evento
        public event CardAddEvent CardAddClick;

        public CardProduct()
        {
            InitializeComponent();
        }

        public Image CardImage
        {
            get => img_producto.Image;
            set => img_producto.Image = value;
        }

        public string CardTitulo
        {
            get => lbl_titulo.Text;
            set => lbl_titulo.Text = value;
        }

        public string CardDescripcion
        {
            get => lbl_descripcion.Text;
            set => lbl_descripcion.Text = value;
        }

        public string CardPrecio
        {
            get => lbl_precio.Text;
            set => lbl_precio.Text = value;
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
            CardAddClick?.Invoke(lbl_titulo.Text, e);
        }
    }
}
