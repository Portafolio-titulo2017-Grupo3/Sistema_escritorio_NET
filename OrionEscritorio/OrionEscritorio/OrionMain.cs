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
    public partial class OrionMain : MetroForm
    {
        public OrionMain()
        {
            InitializeComponent();
            TUsuario listU = new TUsuario();
            cbxPerfil.DataSource = listU.listarDatos();
            cbxPerfil.DisplayMember = "NOMBRE_PERFIL"; //campo que queres mostrar
            cbxPerfil.ValueMember = "ID_PERFIL"; //valor que capturas
            TUsuario listU2 = new TUsuario();
            cbxModPerfil.DataSource = listU2.listarDatos();
            cbxModPerfil.DisplayMember = "NOMBRE_PERFIL"; //campo que queres mostrar
            cbxModPerfil.ValueMember = "ID_PERFIL"; //valor que capturas

        }

        private void OrionMain_Load(object sender, EventArgs e)
        {
            metroTabControl2.ImageList = imageList1;
        }

        private void btnClaro_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            StyleMain.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void btnOscuro_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            StyleMain.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void btnCUsuario_Click(object sender, EventArgs e)
        {
            //String Usuario = txtUsuario.Text.ToString();
            //String Password = txtPassword.Text.ToString();
            //String IdFunc = txtFuncionario.Text.ToString();
            
            int perfil = 0;

            if (cbxPerfil.SelectedIndex.ToString()=="20")
            {
                perfil = 22;
            }

             

            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
            usuario.nombre = txtUsuario.Text;
            usuario.clave = txtPassword.Text;
            usuario.rut_funcionario = txtFuncionario.Text;
            usuario.perfil_id = perfil;
            tusuario.ingresarUsuario(usuario);
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dataListar.DataSource = TUsuario.listarUsuario();
        }

        private void btnModUsu_Click(object sender, EventArgs e)
        {
            int idusurio = Convert.ToInt32(txtBUser.Text);
            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
            int perfil = Convert.ToInt32(cbxModPerfil.SelectedIndex.ToString());
            usuario.clave = txtModUsuPass.Text;
            usuario.perfil_id = perfil;
            usuario.idUsuario = idusurio;


            tusuario.modificarUsuario(usuario);
        }

        private void btnBuscarUsu_Click(object sender, EventArgs e)
        {
            int idusuario = Convert.ToInt32(txtBUser.Text);

            TUsuario buscaUsu = new TUsuario();
            Usuario usuario = new Usuario();

            usuario.idUsuario = idusuario;
            buscaUsu.modBuscar(usuario);
            txtModUsu.Text = usuario.nombre;
            txtModUsuPass.Text = usuario.clave;
        }
    }
}
