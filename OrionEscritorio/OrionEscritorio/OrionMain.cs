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

            int perfil;

            //if (cbxPerfil.SelectedIndex==0)
            //{
            //    perfil = 20;
            //}

            perfil = cbxPerfil.SelectedIndex;

            switch (perfil)
            {
                case 0:
                    perfil = 20;
                    break;
                case 1:
                    perfil = 21;
                    break;
                case 2:
                    perfil = 22;
                    break;
                case 3:
                    perfil = 23;
                    break;
                case 4:
                    perfil = 24;
                    break;
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

           int perfil = cbxModPerfil.SelectedIndex;

            switch (perfil)
            {
                case 0:
                    perfil = 20;
                    break;
                case 1:
                    perfil = 21;
                    break;
                case 2:
                    perfil = 22;
                    break;
                case 3:
                    perfil = 23;
                    break;
                case 4:
                    perfil = 24;
                    break;
            }



            int idusurio = Convert.ToInt32(txtBUser.Text);
            TUsuario tusuario = new TUsuario();
            Usuario usuario = new Usuario();
           
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

        private void CrearNDepto_Click(object sender, EventArgs e)
        {
            TDepartamento Tdepart = new TDepartamento();
            Departamento depart = new Departamento();

            depart.nombre = txtNDpto.Text;
            Tdepart.ingresarDepartamento(depart);
        }

        private void ListModDpto_Click(object sender, EventArgs e)
        {
            dgvDepto.DataSource = TDepartamento.listarDepartamento();
        }

        private void btnMDpto_Click(object sender, EventArgs e)
        {
           string nombreDept=txtMDptoNom.Text;
           int iddept= Int32.Parse(txtBuscarDpto.Text);


            TDepartamento Tdepart = new TDepartamento();
            Departamento depart = new Departamento();

            depart.idDepto = iddept;
            depart.nombre = nombreDept;
            Tdepart.modificarDepartamento(depart);

        }

        private void BuscarDepartamento_Click(object sender, EventArgs e)
        {
            int iddept = Int32.Parse(txtBuscarDpto.Text);

            TDepartamento Tdepart = new TDepartamento();
            Departamento depart = new Departamento();
            
            Tdepart.modBuscar(depart);
            txtMDptoNom.Text = depart.nombre;
         

        }

        private void btnNPerfil_Click(object sender, EventArgs e)
        {
            string nombrePerfil=txtNPerfil.Text;
            string descripPerfil=txtDPerfil.Text;

            Perfil perfil = new Perfil();
            TPerfil Tperfil = new TPerfil();

            perfil.nombre = nombrePerfil;
            perfil.descripcion = descripPerfil;

            Tperfil.ingresarPerfil(perfil);
        }

        private void listarPerfil_Click(object sender, EventArgs e)
        {
            dgwPerfil.DataSource = TPerfil.listarPerfil();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {


            int iddperfil = Int32.Parse(txtBPerfil.Text);

            TPerfil Tperfil = new TPerfil();
            Perfil perfil = new Perfil();
            perfil.idPerfil = iddperfil;
            Tperfil.modBuscar(perfil);
            txtModNomPerfil.Text = perfil.nombre;
            txtModDescPerfil.Text = perfil.descripcion;
        }

        private void btnModPerfil_Click(object sender, EventArgs e)
        {
            int iddperfil = Convert.ToInt32(txtBPerfil.Text);
            TPerfil Tperfil = new TPerfil();
            Perfil perfil = new Perfil();
          

            perfil.idPerfil = iddperfil;
            perfil.nombre = txtModNomPerfil.Text;
            perfil.descripcion = txtModDescPerfil.Text;
            Tperfil.modificarPerfil(perfil);
        }

        private void CrearNMotivo_Click(object sender, EventArgs e)
        {
            Motivos motivo = new Motivos();
            TMotivo tmotivo = new TMotivo();
            
            string descripcion = txtDmotivo.Text;

            motivo.descripcion = descripcion;

            tmotivo.ingresarMotivo(motivo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgwMotivo.DataSource = TMotivo.listarMotivo();



        }

        private void BuscarMotivo_Click(object sender, EventArgs e)
        {

            Motivos motivo = new Motivos();
            TMotivo tmotivo = new TMotivo();
            int idmotivo = Int32.Parse(txtbuscarMotivo.Text);

            motivo.idMotivo = idmotivo;

            tmotivo.buscarMotivo(motivo);

            txtModMotivo.Text = motivo.descripcion;


        }

        private void txtModMot_Click(object sender, EventArgs e)
        {

            Motivos motivo = new Motivos();
            TMotivo tmotivo = new TMotivo();
            motivo.idMotivo = Int32.Parse(txtbuscarMotivo.Text);
            motivo.descripcion = txtModMotivo.Text;

            tmotivo.modificarMotivo(motivo);


        }
    }
}
