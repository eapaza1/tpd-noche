using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdNoche.negocio;

namespace TpdNoche.presentacion
{
    public partial class LoginForm : Form
    {
        NUser control;
        public LoginForm()
        {
            InitializeComponent();
            control = new NUser();

        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            String username = txt_usuario.Text;
            string password = txt_password.Text;

            string resultado = control.login(username, password);

            if (resultado == "exito")
            {
                MessageBox.Show("bienvenido al sistema");

                Form1 formulario = new Form1();

                formulario.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show(resultado);
            }


        }
    }
}
