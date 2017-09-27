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
    public partial class FrmMotivo : Form
    {
        public FrmMotivo()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dataListar.DataSource = TMotivo.listarMotivo();
        }

        private void BuscarMotivo_Click(object sender, EventArgs e)
        {
            /*MySqlCommand buscar = new MySqlCommand("select * from producto where id_producto = '" + Textbuscar.Text + "'", conectar());

            MySqlDataReader leer = buscar.ExecuteReader();
            if (leer.Read() == true)
            {

                TextNombreP.Text = leer["nombre_producto"].ToString();

                TextDrescp.Text = leer["descripcion"].ToString();
                Textprecio.Text = leer["precio"].ToString();
                Textstock.Text = leer["stock"].ToString();
            }*/
        }

        private void FrmMotivo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.MOTIVO' Puede moverla o quitarla según sea necesario.
            //this.mOTIVOTableAdapter.Fill(this.dataSet2.MOTIVO);

        }
    }
}
