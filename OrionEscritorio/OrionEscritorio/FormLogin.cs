using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace OrionEscritorio
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int costParameter = 12;
      

            Boolean existe;
            Login login = new Login();
            existe = login.validarUsuario(txtUsuario.Text, txtClave.Text);
            

            if (existe)
            {
                this.Hide();
                OrionMain orionMain = new OrionMain();
                orionMain.Show();
            }
            else MessageBox.Show("Verifique credenciales....");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
