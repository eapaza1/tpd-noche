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
    public partial class FormProductos : Form
    {
        private byte[] imagen_seleccionado;

        List<EProducto> productos;
        NProducto negocio = new NProducto();
        public FormProductos()
        {
            InitializeComponent();
            Listar();
        }

        private void btn_cambiar_imagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "SELECCIONE UNA IMAGEN";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img_producto.Image = Image.FromFile(ofd.FileName);

                    //convertir imagen a array de bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        img_producto.Image.Save(ms, img_producto.Image.RawFormat);

                        imagen_seleccionado = ms.ToArray();
                    }
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            EProducto product = new EProducto();

            try
            {
                product.Nombre = txt_nombre.Text;
                product.Descripcion = txt_descripcion.Text;
                product.Precio = double.Parse(txt_precio.Text);
                product.Stock = double.Parse(txt_stock.Text);
                product.Categoria = txt_categoria.Text;
                product.Imagen = imagen_seleccionado;

                NProducto negocio = new NProducto();
                negocio.Create(product);

                Listar();
                MessageBox.Show("INSERTADO CORRECTAMENTE");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ubicacion: " + ex.StackTrace);
            }

        }


        private void MostrarElementos(List<EProducto> lista)
        {
            panel_productos.Controls.Clear();

            foreach (EProducto item in lista)
            {
                CardProduct card = new CardProduct();
                card.Item = item;

                panel_productos.Controls.Add(card);
            }
        }

        private void Listar()
        {
            try
            {
                productos = negocio.ReadAll();
                MostrarElementos(productos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " codigo " + ex.StackTrace);
            }


        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string filtrado=txt_buscar.Text.ToLower();

            var nuevalista = productos.Where(item => item.Nombre.ToLower().Contains(filtrado)).ToList();
            MostrarElementos(nuevalista);
        }
    }
}
