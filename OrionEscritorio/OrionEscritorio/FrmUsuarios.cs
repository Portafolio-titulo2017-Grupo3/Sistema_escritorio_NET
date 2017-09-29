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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            TUsuario listU = new TUsuario();
            cbxPerfil.DataSource = listU.listarDatos();
            cbxPerfil.DisplayMember = "NOMBRE_PERFIL"; //campo que queres mostrar
            cbxPerfil.ValueMember = "ID_PERFIL"; //valor que capturas
        }

        private void BuscarMotivo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCUsuario_Click(object sender, EventArgs e)
        {

            String Usuario = txtUsuario.Text.ToString();
            String Password = txtPassword.Text.ToString();
            String IdFunc = txtFuncionario.Text.ToString();
            int perfil = Convert.ToInt32(cbxPerfil.SelectedIndex.ToString());
            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
            usuario.nombre = Usuario;
            usuario.clave = Password;
            usuario.rut_funcionario = IdFunc;
            usuario.perfil_id = perfil;
            int resp = tusuario.ingresarUsuario(usuario);

            if (resp > 0)
            { MessageBox.Show("Usuario ingresado en forma correcta....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Usuario con problema de ingreso....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dataListar.DataSource = TUsuario.listarUsuario();
        }

        private void btnModUsu_Click(object sender, EventArgs e)
        {
            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
            usuario.nombre = txtModUsu.Text;
            usuario.clave = txtModPass.Text;
            tusuario.modificarUsuario(usuario);
        }

        private void btnBuscarUsu_Click(object sender, EventArgs e)
        {
            string rutUsu = txtBUser.Text;

            TUsuario buscaUsu = new TUsuario();
            Usuario usuario = new Usuario();

            usuario.rut_funcionario = rutUsu;
            buscaUsu.modBuscar(usuario);
            txtModUsu.Text = usuario.nombre;
            txtModPass.Text = usuario.clave;
        }
    }
}
