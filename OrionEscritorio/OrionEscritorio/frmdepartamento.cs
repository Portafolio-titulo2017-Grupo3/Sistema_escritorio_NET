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
                      
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.TEST' Puede moverla o quitarla según sea necesario.
            //this.tESTTableAdapter.Fill(this.dataSet1.TEST);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.PRUEBA1' Puede moverla o quitarla según sea necesario.
            //this.pRUEBA1TableAdapter.Fill(this.dataSet1.PRUEBA1);

        }


        private void btnMDpto_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click_1(object sender, EventArgs e)
        {
            dataListar.DataSource = TDepartamento.listarDepartamento();
        }

        private void BuscarDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void CrearNDepto_Click(object sender, EventArgs e)
        {

        }
    }
}
