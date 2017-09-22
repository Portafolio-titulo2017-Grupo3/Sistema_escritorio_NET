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
            Test test = new Test();
            TTest tTest = new TTest();
            test.datoqlo = txtDato.Text;

            int resp = tTest.ingresarTest(test);
            if (resp > 0)
            { 
                MessageBox.Show("Dato ingresado en forma correcta....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { 
                MessageBox.Show("Dato con problema de ingreso....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            grillaTest.DataSource = TTest.listarTest();
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.TEST' Puede moverla o quitarla según sea necesario.
            this.tESTTableAdapter.Fill(this.dataSet1.TEST);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.PRUEBA1' Puede moverla o quitarla según sea necesario.
            this.pRUEBA1TableAdapter.Fill(this.dataSet1.PRUEBA1);

        }
    }
}
