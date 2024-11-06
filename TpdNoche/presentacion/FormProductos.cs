using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        EProducto producto_seleccionado;
        public FormProductos()
        {
            InitializeComponent();
            Listar();

            panel_productos.Resize += Panel_productos_Resize;

        }

        private void Panel_productos_Resize(object sender, EventArgs e)
        {
            foreach (ProductListItem item in panel_productos.Controls)
            {
                item.Width = panel_productos.ClientSize.Width;
            }
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
                limpiar();
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
                var card = new ProductListItem();
                card.Item = item;
                card.Width = panel_productos.Width;
                card.Margin = new Padding(0, 3, 0, 0);

                card.ItemDeleteClick += Card_ItemDeleteClick;
                card.ItemEditClick += Card_ItemEditClick;
                panel_productos.Controls.Add(card);

            }
        }

        private void Card_ItemEditClick(EProducto data, EventArgs e)
        {
            editar(data);
        }

        private void Card_ItemDeleteClick(EProducto data, EventArgs e)
        {
            if (MessageBox.Show("DESEAS ELIMINAR EL PRODUCTO: "+data.Nombre,"ALERTA",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                try
                {

                    var res = negocio.Delete(data);
                    if (res > 0)
                    {
                        MessageBox.Show("PRODUCTO ELIMINADO");
                        Listar();

                    }
                    else
                    {
                        MessageBox.Show("PRODUCTO NO ELIMINADO");
                        Listar();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR EN ELIMINAR: " + ex.Message);
                }
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
            string filtrado = txt_buscar.Text.ToLower();

            var nuevalista = productos.Where(item => item.Nombre.ToLower().Contains(filtrado)).ToList();
            MostrarElementos(nuevalista);
        }

        private void editar(EProducto data)
        {
            producto_seleccionado=data;

            txt_categoria.Text = data.Categoria;
            txt_nombre.Text = data.Nombre;
            txt_precio.Text = "" + data.Precio;
            txt_stock.Text = "" + data.Stock;
            txt_descripcion.Text = data.Descripcion;
            imagen_seleccionado = data.Imagen;
            using (MemoryStream ms = new MemoryStream(data.Imagen))
            {

                Image imagen = Image.FromStream(ms);
                img_producto.Image = imagen;
            }

            btn_agregar.Enabled = false;
            btn_actualizar.Enabled = true;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EProducto product=new EProducto();
            
            try
            {
                product.Id = producto_seleccionado.Id;
                product.Nombre = txt_nombre.Text;
                product.Descripcion = txt_descripcion.Text;
                product.Precio = double.Parse(txt_precio.Text);
                product.Stock = double.Parse(txt_stock.Text);
                product.Categoria = txt_categoria.Text;
                product.Imagen = imagen_seleccionado;

                NProducto negocio = new NProducto();
                negocio.Update(product);

                Listar();
                limpiar();
                MessageBox.Show("PRODUCTO ACTUALIZADO CORRECTAMENTE");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ubicacion: " + ex.StackTrace);
            }


        }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
            txt_descripcion.Clear();
            txt_categoria.Clear();
            btn_actualizar.Enabled = false;
            btn_agregar.Enabled = true;
            txt_nombre.Focus();
            img_producto.Image = Properties.Resources.agregar_producto;
            producto_seleccionado = null;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
