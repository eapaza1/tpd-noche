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
using TpdNoche.servicios;

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
            dgv_clientes.DataSource = dt;
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            string documento=txt_nrodoc.Text;

            if (cbo_tipo_doc.Text=="DNI"&&documento.Length==8)
            {
                buscarDni(documento);                
            }

            if (cbo_tipo_doc.Text == "RUC" && documento.Length == 11)
            {
                buscarRuc(documento);
            }            
        }

        private async void buscarDni(string nrodoc)
        {
            ApiService api=new ApiService();

            try
            {
                var resultado=await api.getByDni(nrodoc);
                txt_nombres.Text = resultado.Nombres+" "+
                    resultado.Apellido_paterno+" "+resultado.Apellido_materno;
                txt_direccion.Text = resultado.Direccion;
            }catch(Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }

        }

        private async void buscarRuc(string ruc)
        {
            var api=new ApiService();
            try
            {
                var emp=await api.getByRuc(ruc);
                txt_nombres.Text = emp.Nombre_o_razon_social;
                txt_direccion.Text = emp.Direccion;

            }catch(Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            ECliente cliente=new ECliente();
            cliente.Nombre= txt_nombres.Text;
            cliente.Tipo_documento =(int) cbo_tipo_doc.SelectedValue;
            cliente.Nrodoc=txt_nrodoc.Text;
            cliente.Direccion=txt_direccion.Text;
            cliente.Telefono=txt_telefono.Text;
            cliente.Email=txt_email.Text;
            cliente.Estado = (int)cbo_estado.SelectedValue;
            try
            {
                int res = nCliente.Create(cliente);
                listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
           
        }
    }
}
