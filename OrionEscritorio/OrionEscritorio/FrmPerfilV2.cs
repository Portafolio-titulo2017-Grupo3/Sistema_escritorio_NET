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
    public partial class FrmPerfilV2 : Form
    {
        public FrmPerfilV2()
        {
            InitializeComponent();
        }

        private void btnNPerfil_Click(object sender, EventArgs e)
        {

            String nombreP = txtNPerfil.Text.ToString();
            String descPerfil = txtDPerfil.Text.ToString();
            TPerfil tperfil = new TPerfil();
            Perfil perfil = new Perfil();
            perfil.nombre = nombreP;
            perfil.descripcion = descPerfil;

            tperfil.ingresarPerfil(perfil);


        }

        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {

            int buscar = int.Parse(txtBPerfil.Text);

            TPerfil buscaPerfil = new TPerfil();
            Perfil perfil = new Perfil();
            perfil.idPerfil = Convert.ToInt32(buscar); 
            buscaPerfil.modBuscar(perfil);
            txtModNom.Text = perfil.nombre;
            txtModDesc.Text = perfil.descripcion;

        }

        private void btnModPerfil_Click(object sender, EventArgs e)
        {
            int test2 = int.Parse(txtBPerfil.Text);
            TPerfil tperfil = new TPerfil();
            Perfil perfil = new Perfil();
            tperfil.modBuscar(perfil);

            perfil.nombre = txtModNom.Text;
            perfil.descripcion = txtModDesc.Text;
            int test = perfil.idPerfil;
            tperfil.modificarPerfil(perfil);



        }

      
    }
}
