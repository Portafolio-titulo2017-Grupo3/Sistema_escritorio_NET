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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDpto = new FrmDepartamento();
            frmDpto.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMotivo formotivo = new FrmMotivo();
            formotivo.Show();
        }

        private void administracionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios formus = new FrmUsuarios();
            formus.Show();


        }
    }
}
