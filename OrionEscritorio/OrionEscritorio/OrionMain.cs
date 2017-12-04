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
        
        protected override CreateParams CreateParams {
            get {

                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200; 

                return parms;
            }
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
            if (txtUsuario.Text.Length >= 5)
            {
                lblUsuario.Visible = false;
                if (txtPassword.Text.Length > 4)
                {
                    lblpass.Visible = false;
                    if (txtFuncionario.Text.Length >= 10)
                    {

                        int perfil;
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

                        lblFuncionario.Visible = false;
                        TUsuario tusuario = new TUsuario();
                        Usuario usuario = new Usuario();
                        usuario.nombre = txtUsuario.Text;
                        usuario.clave = txtPassword.Text;
                        usuario.rut_funcionario = txtFuncionario.Text;
                        usuario.perfil_id = perfil;
                        tusuario.ingresarUsuario(usuario);
                        MessageBox.Show("USUARIO CREADO CORRECTAMENTE");
                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtFuncionario.Text = "";

                    }
                    else
                    {
                        lblFuncionario.Visible = true;
                    }
                }
                else
                {
                    lblpass.Visible = true;
                }
            }
            else
            {
                lblUsuario.Visible = true;
            }
         
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dataListar.DataSource = TUsuario.listarUsuario();
        }

        private void btnModUsu_Click(object sender, EventArgs e)
        {

            if (txtModUsuPass.Text.Length >= 5)
            {
                lblusuclave.Visible = false;
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
                dataListar.DataSource = TUsuario.listarUsuario();
                txtModUsuPass.Enabled = false;
                cbxModPerfil.Enabled = false;
                btnModUsu.Enabled = false;
                txtBUser.Text = "";
                txtModUsuPass.Text = "";
           
             


            }
            else
            {
                lblusuclave.Visible = true;
            }
          
        }

        private void btnBuscarUsu_Click(object sender, EventArgs e)
        {
            if (txtBUser.Text.Length >= 2)
            {
                int idusuario = Convert.ToInt32(txtBUser.Text);

                TUsuario buscaUsu = new TUsuario();
                Usuario usuario = new Usuario();

                usuario.idUsuario = idusuario;
                buscaUsu.modBuscar(usuario);
                txtModUsu.Text = usuario.nombre;
                txtModUsuPass.Text = usuario.clave;

                if (txtModUsu.Text.Length > 1)
                {

            
                    txtModUsuPass.Enabled = true;
                    cbxModPerfil.Enabled = true;
                    btnModUsu.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("INGRESE UNA ID VALIDA");
            }
            
        }

        private void CrearNDepto_Click(object sender, EventArgs e)
        {
            if (txtNDpto.Text.Length >= 5)
            {
                lbldepart.Visible = false;

                TDepartamento Tdepart = new TDepartamento();
                Departamento depart = new Departamento();

                depart.nombre = txtNDpto.Text;
                Tdepart.ingresarDepartamento(depart);

            }
            else
            {
                lbldepart.Visible = true;
            }

            
        }

        private void ListModDpto_Click(object sender, EventArgs e)
        {
            dgvDepto.DataSource = TDepartamento.listarDepartamento();
        }

        private void btnMDpto_Click(object sender, EventArgs e)
        {

            if (txtMDptoNom.Text.Length >= 5 )
            {
                lbldepM.Visible = false;
                string nombreDept = txtMDptoNom.Text;
                int iddept = Int32.Parse(txtBuscarDpto.Text);


                TDepartamento Tdepart = new TDepartamento();
                Departamento depart = new Departamento();

                depart.idDepto = iddept;
                depart.nombre = nombreDept;
                Tdepart.modificarDepartamento(depart);


                txtMDptoNom.Text = "";
                txtMDptoNom.Enabled = false;
                btnMDpto.Enabled = false;
            }
            else
            {
                lbldepM.Visible = true;
            }
            
            
        }

        private void BuscarDepartamento_Click(object sender, EventArgs e)
        {
            
            if (!txtBuscarDpto.Text.Equals(""))
            {

                int iddept = Int32.Parse(txtBuscarDpto.Text);

                TDepartamento Tdepart = new TDepartamento();
                Departamento depart = new Departamento();
                depart.idDepto = iddept;

                Tdepart.modBuscar(depart);

                txtMDptoNom.Text = depart.nombre;
                if (txtMDptoNom.Text.Length > 1)
                {
                    
                    txtMDptoNom.Enabled = true;
                    btnMDpto.Enabled = true;

                }
               

            }
            else
            {
                MessageBox.Show("INGRESE UNA ID DE DEPARTAMENTO VALIDA");
            }


         

        }

        private void btnNPerfil_Click(object sender, EventArgs e)
        {
            if (txtNPerfil.Text.Length >= 5)
            {
                lblperfilname.Visible = false;
                if (txtDPerfil.Text.Length >= 5)
                {
                    lblperfildesc.Visible = false;
                    string nombrePerfil = txtNPerfil.Text;
                    string descripPerfil = txtDPerfil.Text;

                    Perfil perfil = new Perfil();
                    TPerfil Tperfil = new TPerfil();

                    perfil.nombre = nombrePerfil;
                    perfil.descripcion = descripPerfil;

                    Tperfil.ingresarPerfil(perfil);
                }
                else
                {
                    lblperfildesc.Visible = true;
                }
            }
            else
            {
                lblperfilname.Visible = true;
            }
           
        }

        private void listarPerfil_Click(object sender, EventArgs e)
        {
            dgwPerfil.DataSource = TPerfil.listarPerfil();
        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            if(txtBPerfil.Text.Length>= 2)
            {
                int iddperfil = Int32.Parse(txtBPerfil.Text);

                TPerfil Tperfil = new TPerfil();
                Perfil perfil = new Perfil();
                perfil.idPerfil = iddperfil;
                Tperfil.modBuscar(perfil);
                txtModNomPerfil.Text = perfil.nombre;
                txtModDescPerfil.Text = perfil.descripcion;

                if (txtModNomPerfil.Text.Length > 1)
                {

                    txtModNomPerfil.Enabled = true;
                    txtModDescPerfil.Enabled = true;
                    btnModPerfil.Enabled = true;

                }
            }
            else
            {

                MessageBox.Show("ID DE PERFIL NO VALIDA");
            }

            
        }

        private void btnModPerfil_Click(object sender, EventArgs e)
        {


            if (txtModNomPerfil.Text.Length >= 5)
            {
                lblperfilMname.Visible = false;
                if (txtModDescPerfil.Text.Length >= 5)
                {
                    lblperfilMdesc.Visible = false;
                    int iddperfil = Convert.ToInt32(txtBPerfil.Text);
                    TPerfil Tperfil = new TPerfil();
                    Perfil perfil = new Perfil();


                    perfil.idPerfil = iddperfil;
                    perfil.nombre = txtModNomPerfil.Text;
                    perfil.descripcion = txtModDescPerfil.Text;
                    Tperfil.modificarPerfil(perfil);


                    MessageBox.Show("PERFIL MODIFICADO CORRECTAMENTE");


                    txtModNomPerfil.Text = "";
                    txtModDescPerfil.Text = "";
                    txtModNomPerfil.Enabled = false;
                    txtModDescPerfil.Enabled = false;
                    btnModPerfil.Enabled = false;

                }
                else
                {
                    lblperfilMdesc.Visible = true;
                }
            }
            else
            {
                lblperfilMname.Visible = true;
            }



                   
        }

        private void CrearNMotivo_Click(object sender, EventArgs e)
        {


            if (txtDmotivo.Text.Length > 5)
            {
                lblmotivo.Visible = false;
                Motivos motivo = new Motivos();
                TMotivo tmotivo = new TMotivo();

                string descripcion = txtDmotivo.Text;

                motivo.descripcion = descripcion;

                tmotivo.ingresarMotivo(motivo);
            }
            else
            {
                lblmotivo.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgwMotivo.DataSource = TMotivo.listarMotivo();



        }

        private void BuscarMotivo_Click(object sender, EventArgs e)
        {
            if (txtbuscarMotivo.Text.Length >= 2)
            {
                Motivos motivo = new Motivos();
                TMotivo tmotivo = new TMotivo();
                int idmotivo = Int32.Parse(txtbuscarMotivo.Text);

                motivo.idMotivo = idmotivo;

                tmotivo.buscarMotivo(motivo);

                txtModMotivo.Text = motivo.descripcion;
                if (txtModMotivo.Text.Length > 1)
                {

                    txtModMot.Enabled = true;
                    txtModMotivo.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("ID DE MOTIVO NO VALIDA");
            }
            


        }

        private void txtModMot_Click(object sender, EventArgs e)
        {
            if (txtModMotivo.Text.Length > 5)
            {
                lblmotivodesc.Visible = false;

                Motivos motivo = new Motivos();
                TMotivo tmotivo = new TMotivo();
                motivo.idMotivo = Int32.Parse(txtbuscarMotivo.Text);
                motivo.descripcion = txtModMotivo.Text;

                tmotivo.modificarMotivo(motivo);

                txtModMot.Enabled = false;
                txtModMotivo.Enabled = false;
                txtModMotivo.Text = "";

            }
            else
            {
                lblmotivodesc.Visible = true;
            }
            


        }

        private void btnNTipo_Click(object sender, EventArgs e)
        {
            if (txtNTipoN.Text.Length > 5)
            {
                lbltipon.Visible = false;
                if(txtNTipoDesc.Text.Length > 5)
                {
                    lbltipoD.Visible = false;
                    Tipo tipo = new Tipo();
                    TTipo tTipo = new TTipo();

                    tipo.descripcion = txtNTipoDesc.Text;
                    tipo.nombre = txtNTipoN.Text;

                    tTipo.ingresarTipo(tipo);
                    MessageBox.Show("TIPO DE PERMISO CREADO CORRECTAMENTE");
                }
                else
                {
                    lbltipoD.Visible = true;
                }
            }
            else
            {
                lbltipon.Visible = true;
            }
            

        }

        private void listarTipo_Click(object sender, EventArgs e)
        {
            dwvTipo.DataSource = TTipo.listarTipo();
        }

        private void btnBTipo_Click(object sender, EventArgs e)
        {
            if (txtBTipo.Text.Length >= 1)
            {
                int IdTipo = Int32.Parse(txtBTipo.Text);

                Tipo tipo = new Tipo();
                TTipo tTipo = new TTipo();
                tipo.idTipo = IdTipo;
                tTipo.modBuscar(tipo);

                txtMNTIpo.Text = tipo.nombre;
                txtMdtipo.Text = tipo.descripcion;

                if (txtMNTIpo.Text.Length > 1)
                {
                    txtMNTIpo.Enabled = true;
                    txtMdtipo.Enabled = true;
                    btnMTipo.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("ID DE TIPO INVALIDA");
                txtMNTIpo.Enabled = false;
                txtMdtipo.Enabled = false;
                btnMTipo.Enabled = false;
            }
            

        }

        private void btnMTipo_Click(object sender, EventArgs e)
        {

            if (txtMNTIpo.Text.Length >= 5)
            {
                lblmtiponame.Visible = false;
                if (txtMdtipo.Text.Length >= 5)
                {
                    lblmtipod.Visible = false;
                    int IdTipo = Int32.Parse(txtBTipo.Text);

                    Tipo tipo = new Tipo();
                    TTipo tTipo = new TTipo();
                    tipo.idTipo = IdTipo;

                    tipo.nombre = txtMNTIpo.Text;
                    tipo.descripcion = txtMdtipo.Text;
                    tTipo.modificarTipo(tipo);

                    MessageBox.Show("TIPO MODIFICADO CORRECTAMENTE");
                    txtMNTIpo.Text = "";
                    txtMdtipo.Text = "";
                    txtMNTIpo.Enabled = false;
                    txtMdtipo.Enabled = false;
                    btnMTipo.Enabled = false;


                }
                else
                {
                    lblmtipod.Visible = true;
                }
            }
            else
            {
                lblmtiponame.Visible = true;
            }
            

        }

        void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloUsuario(e);

        }

        void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloUsuario(e);

        }
        
       void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solorut(e);
           

        }

        
         void txtBUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solonum(e);


        }

        void txtModUsuPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.letrasynumv2(e);


        }
        void txtNDpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.letrasynum(e);


        }

    
        void txtBuscarDpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solonum(e);
        }
     
        void txtMDptoNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.letrasynum(e);
        }
         void txtDmotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

        

           void txtbuscarMotivO_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solonum(e);
        }

  
        void txtModMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

        
        void txtNPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }
        void txtDPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

       
        void txtBPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solonum(e);
        }

     
        void txtModNomPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

  
        void txtModDescPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

      
        void txtNTipoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }
        void txtNTipoDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

     
        void txtBTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.solonum(e);
        }
      
        void txtMNTIpo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }
        
        void txtMdtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            OrionEscritoriok.validar.soloLetras(e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mensaje de ayuda");
        }

        private void BtnListEliminarUsu_Click(object sender, EventArgs e)
        {
            //dataListar.DataSource = TUsuario.listarUsuario();
            gridEliminarUsu.DataSource = TUsuario.listarUsuario();
        }

        private void btnListarEliminarDpto_Click(object sender, EventArgs e)
        {
            gridEliminarDpto.DataSource = TDepartamento.listarDepartamento();
        }

        private void btnListarEliminarMotivo_Click(object sender, EventArgs e)
        {
            gridEliminarMotivo.DataSource = TMotivo.listarMotivo();
        }

        private void btnListarEliminarPerfil_Click(object sender, EventArgs e)
        {
            gridEliminarPerfil.DataSource = TPerfil.listarPerfil();
        }

        private void btnEliminarUsu_Click(object sender, EventArgs e)
        {
            int idusurio = Convert.ToInt32(txtEliminarUsu.Text);
            TUsuario tusuario = new TUsuario();        

            tusuario.eliminarUsuario(idusurio);
        }

        private void btnEliminarDpto_Click(object sender, EventArgs e)
        {
            int idDpto = Convert.ToInt32(txtEliminarDpto.Text);
            TDepartamento tdpto = new TDepartamento();

            tdpto.eliminarDepartamento(idDpto);
        }

        private void btnEliminarMotivo_Click(object sender, EventArgs e)
        {
            int idMotivo = Convert.ToInt32(txtEliminarMotivo.Text);
            TMotivo tMotivo = new TMotivo();

            tMotivo.eliminarMotivo(idMotivo);
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            int idPerfil = Convert.ToInt32(txtEliminarPerfil.Text);
            TPerfil tPerfil = new TPerfil();

            tPerfil.eliminarPerfil(idPerfil);
        }

        private void btnListarEliminarTipo_Click(object sender, EventArgs e)
        {
            gridEliminarTipo.DataSource = TTipo.listarTipo();
        }

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32(txtEliminarTipo.Text);
            TTipo tTipo = new TTipo();

            tTipo.eliminarTipo(idTipo);
        }
    }
}
