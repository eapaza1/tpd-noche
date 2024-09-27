using MySql.Data.MySqlClient;
using System.Data;
using TpdNoche.entidad;
using TpdNoche.negocio;

namespace TpdNoche
{
    public partial class Form1 : Form
    {
        NUser control;
        public Form1()
        {
            InitializeComponent();

            control = new NUser();
            ReadAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion =
                "Server=localhost;Database=test_lurin;User ID=root;Password=;SslMode=none;";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexion: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }



        }



        private void btn_crear_Click(object sender, EventArgs e)
        {
            EUser data= new EUser();
            data.Username=txt_user.Text;
            data.Password = txt_pass.Text;
            data.Email = txt_mail.Text;
            try
            {
                control.Insert(data);

            }catch (Exception ex)
            {
                MessageBox.Show("error en Insertar: "+ex.Message);
            }
            ReadAll();
        }


        private void ReadAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("USUARIO");
            dt.Columns.Add("CONTRASEÑA");
            dt.Columns.Add("CORREO");
            try
            {             
                var lista = control.ReadAll();

                foreach (EUser user in lista)
                {
                    dt.Rows.Add(user.Id, user.Username, user.Password, user.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en listar: " + ex.Message,"ERROR");
            }

            dgw_users.DataSource = dt;


        }

    }
}