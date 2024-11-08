using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpdNoche.presentacion.Componentes
{
    public partial class ElementoLibro : UserControl
    {
        private ELibro libro;

        public ELibro Libro
        {
            get
            {
                return this.libro;
            }
            set
            {
                this.libro = value;
                mostrar();
            }
        }

        private void mostrar()
        {
            //mostrando en formulario
            lbl_titulo.Text = libro.Titulo;

            //mostrar precio
            //mostrar ......
        }

        //ElementoLibro.Libro=   //set
        //ELibro libro= ElementoLibro.Libro  //get

        public ElementoLibro()
        {
            InitializeComponent();
        }
    }
    
    public class ELibro
    {
        string titulo, descripcion;
        string imagen;
        double precio;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
