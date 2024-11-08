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
using TpdNoche.presentacion.viewEntity;

namespace TpdNoche.presentacion
{
   
    public partial class FormCliente : Form
    {
        private List<ECliente> clientes;
        private NCliente nCliente;
        public FormCliente()
        {
            InitializeComponent();
            nCliente = new NCliente();
            listar();

            initData();
        }

        private void initData()
        {
            //inicio de cbo estado
            cbo_estado.Items.Clear();
            cbo_estado.DataSource= new EstadoCliente().Estados;
            cbo_estado.DisplayMember = "descripcion";
            cbo_estado.ValueMember = "id";

            //inicio de cbo tipo documento
            cbo_tipo_doc.Items.Clear();
            cbo_tipo_doc.DataSource = new TipoDocumento().List;
            cbo_tipo_doc.DisplayMember = "descripcion";
            cbo_tipo_doc.ValueMember = "id";
        }

        private void listar()
        {
            try
            {


                clientes = nCliente.ReadAll();

                mostrar(clientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en listar: "+ex.Message+" con codigo: "+ex.StackTrace);
            }
        }

        private void mostrar(List<ECliente> clientes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOMBRES");
            dt.Columns.Add("DOCUMENTO");
            dt.Columns.Add("CORREO");
            dt.Columns.Add("TELEFONO");

            foreach (var item in clientes)
            {
                dt.Rows.Add(item.Id,item.Nombre,item.Nrodoc,item.Email,item.Telefono);
            }

            dgv_clientes.DataSource = clientes;
        }

        private void cbo_tipo_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=(int)cbo_tipo_doc.SelectedValue;
            MessageBox.Show(""+id);
        }
    }
}
