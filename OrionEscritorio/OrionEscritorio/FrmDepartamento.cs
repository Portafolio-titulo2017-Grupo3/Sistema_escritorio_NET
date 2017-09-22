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
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Departamento dpto = new Departamento();
            TDepartamento tDpto = new TDepartamento();
            /*dpto.datoqlo = txtDato.Text;

            int resp = tDpto.ingresarDepartamento(dpto);
            if (resp > 0)
            { 
                MessageBox.Show("Dato ingresado en forma correcta....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { 
                MessageBox.Show("Dato con problema de ingreso....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            */
        }
    }
}
