using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionEscritorio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del LOGIN");
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean existe;
            Login login = new Login();
            existe = login.validarUsuario(txtUser.Text, txtPass.Text);
            if (existe)
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
            else MessageBox.Show("Verifique credenciales....");
        }
    }
}
