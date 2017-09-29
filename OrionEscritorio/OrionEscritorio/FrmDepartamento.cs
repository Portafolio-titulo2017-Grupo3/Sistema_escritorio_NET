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
            TDepartamento tDpto = new TDepartamento();
            Departamento dpto = new Departamento();
            dpto.nombre = txtMDptoNom.Text;
            dpto.idDepto = int.Parse(txtBuscarDpto.Text);
            tDpto.modificarDepartamento(dpto);
        }

        private void BtnListar_Click_1(object sender, EventArgs e)
        {
            dataListar.DataSource = TDepartamento.listarDepartamento();
        }


        private void CrearNDepto_Click(object sender, EventArgs e)
        {
            Departamento dpto = new Departamento();
            TDepartamento tDpto = new TDepartamento();
            dpto.nombre = txtNomDpto.Text;
            int resp = tDpto.ingresarDepartamento(dpto);
            if (resp > 0)
            { MessageBox.Show("Departamento ingresado en forma correcta....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Departamento con problema de ingreso....!", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnBuscarDpto_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscarDpto.Text);

            TDepartamento tDpto = new TDepartamento();
            Departamento dpto = new Departamento();

            dpto.idDepto = id;
            tDpto.modBuscar(dpto);
            txtMDptoNom.Text = dpto.nombre;


        }
    }
}
