using MySql.Data.MySqlClient;
using System.Data;
using TpdNoche.entidad;
using TpdNoche.negocio;

namespace TpdNoche
{
    public partial class Form1 : Form
    {
        NUser control;
        int id_seleccionado = -1;
        public Form1()
        {
            InitializeComponent();

            control = new NUser();
            ReadAll();

            limpiarFormulario();

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
            EUser data = new EUser();
            data.Username = txt_user.Text;
            data.Password = txt_pass.Text;
            data.Email = txt_mail.Text;
            try
            {
                control.Insert(data);

            }
            catch (Exception ex)
            {
                MessageBox.Show("error en Insertar: " + ex.Message);
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
                MessageBox.Show("Error en listar: " + ex.Message, "ERROR");
            }

            dgw_users.DataSource = dt;


        }

        private void dgw_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaIndex = e.RowIndex;

            if (filaIndex >= 0)
            {
                var fila = dgw_users.Rows[filaIndex];

                id_seleccionado = int.Parse(fila.Cells[0].Value.ToString());
                string username = fila.Cells[1].Value.ToString();
                string password = fila.Cells[2].Value.ToString();
                string email = fila.Cells[3].Value.ToString();

                //mostrar en el formulario
                txt_user.Text = username;
                txt_pass.Text = password;
                txt_mail.Text = email;

                btn_crear.Enabled = false;
                btn_actualizar.Enabled = true;
                btn_eliminar.Enabled = true;
            }

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Username = txt_user.Text;
            user.Password = txt_pass.Text;
            user.Email = txt_mail.Text;
            user.Id = id_seleccionado;

            try
            {
                control.Update(user);
                ReadAll();
                lbl_mensaje.Text = "Acutualizado Correctamente";

                limpiarFormulario();

            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = "Error en Actualizar: " + ex.Message;
            }

        }


        private void limpiarFormulario()
        {
            txt_mail.Text = "";
            txt_pass.Clear();
            txt_user.Clear();

            //efocar cursor
            txt_user.Focus();

            id_seleccionado = -1;

            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;

            btn_crear.Enabled = true;


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EUser user = new EUser();
            user.Id = id_seleccionado;
            try
            {
                control.Delete(user);
                limpiarFormulario();
                ReadAll();
                lbl_mensaje.Text = "Se elimino correctamente";

            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = "Error en Eliminar: " + ex.Message;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }
    }

}