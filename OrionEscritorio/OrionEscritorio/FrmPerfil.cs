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
    public partial class FrmPerfil : Form
    {
        private TabControl tabControl1;
        private TabPage inicio;
        private TabPage CrearUsuario;
        private Button CrearTipo;
        private TextBox txtdescTipo;
        private TextBox txtNombreTipo;
        private TabPage ModificarUsuario;
        private Button BtnListar;
        private Button button3;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button BuscarMotivo;
        private DataGridView dataListar;
        private Panel panel1;

        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inicio = new System.Windows.Forms.TabPage();
            this.CrearUsuario = new System.Windows.Forms.TabPage();
            this.CrearTipo = new System.Windows.Forms.Button();
            this.txtdescTipo = new System.Windows.Forms.TextBox();
            this.txtNombreTipo = new System.Windows.Forms.TextBox();
            this.ModificarUsuario = new System.Windows.Forms.TabPage();
            this.BtnListar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BuscarMotivo = new System.Windows.Forms.Button();
            this.dataListar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.CrearUsuario.SuspendLayout();
            this.ModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inicio);
            this.tabControl1.Controls.Add(this.CrearUsuario);
            this.tabControl1.Controls.Add(this.ModificarUsuario);
            this.tabControl1.Location = new System.Drawing.Point(20, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 368);
            this.tabControl1.TabIndex = 2;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(4, 22);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(506, 342);
            this.inicio.TabIndex = 2;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // CrearUsuario
            // 
            this.CrearUsuario.Controls.Add(this.CrearTipo);
            this.CrearUsuario.Controls.Add(this.txtdescTipo);
            this.CrearUsuario.Controls.Add(this.txtNombreTipo);
            this.CrearUsuario.Location = new System.Drawing.Point(4, 22);
            this.CrearUsuario.Name = "CrearUsuario";
            this.CrearUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.CrearUsuario.Size = new System.Drawing.Size(506, 342);
            this.CrearUsuario.TabIndex = 0;
            this.CrearUsuario.Text = "Crear Perfil";
            this.CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // CrearTipo
            // 
            this.CrearTipo.Location = new System.Drawing.Point(165, 146);
            this.CrearTipo.Name = "CrearTipo";
            this.CrearTipo.Size = new System.Drawing.Size(136, 24);
            this.CrearTipo.TabIndex = 7;
            this.CrearTipo.Text = "Crear Nuevo Tipo";
            this.CrearTipo.UseVisualStyleBackColor = true;
            this.CrearTipo.Click += new System.EventHandler(this.CrearTipo_Click);
            // 
            // txtdescTipo
            // 
            this.txtdescTipo.Location = new System.Drawing.Point(165, 106);
            this.txtdescTipo.Name = "txtdescTipo";
            this.txtdescTipo.Size = new System.Drawing.Size(136, 20);
            this.txtdescTipo.TabIndex = 1;
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.Location = new System.Drawing.Point(165, 73);
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.Size = new System.Drawing.Size(136, 20);
            this.txtNombreTipo.TabIndex = 0;
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Controls.Add(this.BtnListar);
            this.ModificarUsuario.Controls.Add(this.button3);
            this.ModificarUsuario.Controls.Add(this.label7);
            this.ModificarUsuario.Controls.Add(this.label6);
            this.ModificarUsuario.Controls.Add(this.textBox5);
            this.ModificarUsuario.Controls.Add(this.textBox4);
            this.ModificarUsuario.Controls.Add(this.textBox3);
            this.ModificarUsuario.Controls.Add(this.BuscarMotivo);
            this.ModificarUsuario.Controls.Add(this.dataListar);
            this.ModificarUsuario.Location = new System.Drawing.Point(4, 22);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarUsuario.Size = new System.Drawing.Size(506, 342);
            this.ModificarUsuario.TabIndex = 1;
            this.ModificarUsuario.Text = "Modificar Perfil";
            this.ModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(39, 39);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar Perfil";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modificar Perfil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion Motivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Motivo";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(265, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // BuscarMotivo
            // 
            this.BuscarMotivo.Location = new System.Drawing.Point(371, 165);
            this.BuscarMotivo.Name = "BuscarMotivo";
            this.BuscarMotivo.Size = new System.Drawing.Size(110, 23);
            this.BuscarMotivo.TabIndex = 1;
            this.BuscarMotivo.Text = "Seleccionar Perfil";
            this.BuscarMotivo.UseVisualStyleBackColor = true;
            // 
            // dataListar
            // 
            this.dataListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListar.Location = new System.Drawing.Point(39, 68);
            this.dataListar.Name = "dataListar";
            this.dataListar.Size = new System.Drawing.Size(422, 78);
            this.dataListar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 455);
            this.panel1.TabIndex = 1;
            // 
            // FrmPerfil
            // 
            this.ClientSize = new System.Drawing.Size(575, 479);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPerfil";
            this.tabControl1.ResumeLayout(false);
            this.CrearUsuario.ResumeLayout(false);
            this.CrearUsuario.PerformLayout();
            this.ModificarUsuario.ResumeLayout(false);
            this.ModificarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void CrearTipo_Click(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            dataListar.DataSource = TPerfil.listarPerfil();
        }
    }
}
