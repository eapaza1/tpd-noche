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

namespace TpdNoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //listar();

            InicializarDatos();

            cb_cliente.SelectedValue = 2;
        }

        private void InicializarDatos()
        {
            var clientes=new NCliente().ReadAll();
            cb_cliente.Items.Clear();
            cb_cliente.DataSource = clientes;
            cb_cliente.DisplayMember = "nombre";
            cb_cliente.ValueMember = "id";

        }

        private void listar()
        {
            List<ELibro> libros = new List<ELibro>();
            libros.Add(new ELibro() { Titulo="LIBRO 1",Descripcion="adsf"});
            libros.Add(new ELibro() { Titulo="50 SOBRAS DE GREY",Descripcion="adsf"});
            libros.Add(new ELibro() { Titulo="SOMBI",Descripcion="adsf"});

            foreach (var item in libros)
            {
                ElementoLibro elibro= new ElementoLibro();
               elibro.Libro = item;
               // flp_data.Controls.Add(elibro);
            }



        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var res =(ECliente) cb_cliente.SelectedItem;

            var res=cb_cliente.SelectedValue;

            MessageBox.Show("elemento seleccionado: " + res);
        }
    }
}
