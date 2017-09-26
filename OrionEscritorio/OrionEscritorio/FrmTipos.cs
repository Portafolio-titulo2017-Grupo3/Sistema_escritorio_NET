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
    public partial class FrmTipos : Form
    {
        private TabControl tabControl1;
        private TabPage InicioTipos;
        private Label label1;
        private TabPage IngresarTipo;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage ListarTipo;
        private BindingSource dataSet2BindingSource;
        private IContainer components;
 
        private BindingSource tIPOBindingSource;
 
        private Label label4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button3;
        private Button button2;
        private Panel panel1;

        public FrmTipos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InicioTipos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarTipo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListarTipo = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.InicioTipos.SuspendLayout();
            this.IngresarTipo.SuspendLayout();
            this.ListarTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 459);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InicioTipos);
            this.tabControl1.Controls.Add(this.IngresarTipo);
            this.tabControl1.Controls.Add(this.ListarTipo);
            this.tabControl1.Location = new System.Drawing.Point(3, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // InicioTipos
            // 
            this.InicioTipos.Controls.Add(this.label1);
            this.InicioTipos.Location = new System.Drawing.Point(4, 22);
            this.InicioTipos.Name = "InicioTipos";
            this.InicioTipos.Size = new System.Drawing.Size(617, 379);
            this.InicioTipos.TabIndex = 3;
            this.InicioTipos.Text = "Inicio";
            this.InicioTipos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // IngresarTipo
            // 
            this.IngresarTipo.Controls.Add(this.button1);
            this.IngresarTipo.Controls.Add(this.label3);
            this.IngresarTipo.Controls.Add(this.label2);
            this.IngresarTipo.Controls.Add(this.textBox2);
            this.IngresarTipo.Controls.Add(this.textBox1);
            this.IngresarTipo.Location = new System.Drawing.Point(4, 22);
            this.IngresarTipo.Name = "IngresarTipo";
            this.IngresarTipo.Padding = new System.Windows.Forms.Padding(3);
            this.IngresarTipo.Size = new System.Drawing.Size(617, 379);
            this.IngresarTipo.TabIndex = 0;
            this.IngresarTipo.Text = "Ingresar Tipo";
            this.IngresarTipo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear Nuevo Tipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del tipo de permiso";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ListarTipo
            // 
            this.ListarTipo.Controls.Add(this.button3);
            this.ListarTipo.Controls.Add(this.button2);
            this.ListarTipo.Controls.Add(this.textBox7);
            this.ListarTipo.Controls.Add(this.textBox6);
            this.ListarTipo.Controls.Add(this.textBox5);
            this.ListarTipo.Controls.Add(this.textBox4);
            this.ListarTipo.Controls.Add(this.textBox3);
            this.ListarTipo.Controls.Add(this.label9);
            this.ListarTipo.Controls.Add(this.label8);
            this.ListarTipo.Controls.Add(this.label7);
            this.ListarTipo.Controls.Add(this.label6);
            this.ListarTipo.Controls.Add(this.label5);
            this.ListarTipo.Controls.Add(this.label4);
            this.ListarTipo.Location = new System.Drawing.Point(4, 22);
            this.ListarTipo.Name = "ListarTipo";
            this.ListarTipo.Padding = new System.Windows.Forms.Padding(3);
            this.ListarTipo.Size = new System.Drawing.Size(617, 379);
            this.ListarTipo.TabIndex = 2;
            this.ListarTipo.Text = "Listar Tipo";
            this.ListarTipo.UseVisualStyleBackColor = true;
            this.ListarTipo.Click += new System.EventHandler(this.ListarTipo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(68, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Buscar y modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(68, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(68, 291);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 264);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 236);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Descipcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipos de permiso ingresados en el sistemas";
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // FrmTipos
            // 
            this.ClientSize = new System.Drawing.Size(677, 501);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTipos";
            this.Load += new System.EventHandler(this.FrmTipos_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.InicioTipos.ResumeLayout(false);
            this.InicioTipos.PerformLayout();
            this.IngresarTipo.ResumeLayout(false);
            this.IngresarTipo.PerformLayout();
            this.ListarTipo.ResumeLayout(false);
            this.ListarTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmTipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.TIPO' Puede moverla o quitarla según sea necesario.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


     
        
            Tipo test = new Tipo();

  







    



        }

        private void ListarTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
