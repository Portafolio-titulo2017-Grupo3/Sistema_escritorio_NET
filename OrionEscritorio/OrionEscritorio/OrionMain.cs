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
        }

        private void OrionMain_Load(object sender, EventArgs e)
        {

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
    }
}
