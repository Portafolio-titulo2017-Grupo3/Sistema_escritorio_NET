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
        private DataGridView dataGridView1;
        private BindingSource dataSet2BindingSource;
        private IContainer components;
        private DataSet2 dataSet2;
        private BindingSource tIPOBindingSource;
        private DataSet2TableAdapters.TIPOTableAdapter tIPOTableAdapter;
        private Label label4;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pERMISOIDPERMISODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eSTADOIDESTADODataGridViewTextBoxColumn;
        private Panel panel1;

        public FrmTipos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListarTipo = new System.Windows.Forms.TabPage();
            this.IngresarTipo = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InicioTipos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new OrionEscritorio.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOTableAdapter = new OrionEscritorio.DataSet2TableAdapters.TIPOTableAdapter();
            this.eSTADOIDESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERMISOIDPERMISODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.ListarTipo.SuspendLayout();
            this.IngresarTipo.SuspendLayout();
            this.InicioTipos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 367);
            this.panel1.TabIndex = 0;
            // 
            // ListarTipo
            // 
            this.ListarTipo.Controls.Add(this.label4);
            this.ListarTipo.Controls.Add(this.dataGridView1);
            this.ListarTipo.Location = new System.Drawing.Point(4, 22);
            this.ListarTipo.Name = "ListarTipo";
            this.ListarTipo.Padding = new System.Windows.Forms.Padding(3);
            this.ListarTipo.Size = new System.Drawing.Size(577, 335);
            this.ListarTipo.TabIndex = 2;
            this.ListarTipo.Text = "Listar Tipo";
            this.ListarTipo.UseVisualStyleBackColor = true;
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
            this.IngresarTipo.Size = new System.Drawing.Size(575, 344);
            this.IngresarTipo.TabIndex = 0;
            this.IngresarTipo.Text = "Ingresar Tipo";
            this.IngresarTipo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crear Nuevo Tipo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // InicioTipos
            // 
            this.InicioTipos.Controls.Add(this.label1);
            this.InicioTipos.Location = new System.Drawing.Point(4, 22);
            this.InicioTipos.Name = "InicioTipos";
            this.InicioTipos.Size = new System.Drawing.Size(577, 335);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InicioTipos);
            this.tabControl1.Controls.Add(this.IngresarTipo);
            this.tabControl1.Controls.Add(this.ListarTipo);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn,
            this.pERMISOIDPERMISODataGridViewTextBoxColumn,
            this.eSTADOIDESTADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tIPOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 145);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // tIPOBindingSource
            // 
            this.tIPOBindingSource.DataMember = "TIPO";
            this.tIPOBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // tIPOTableAdapter
            // 
            this.tIPOTableAdapter.ClearBeforeFill = true;
            // 
            // eSTADOIDESTADODataGridViewTextBoxColumn
            // 
            this.eSTADOIDESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO_IDESTADO";
            this.eSTADOIDESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO_IDESTADO";
            this.eSTADOIDESTADODataGridViewTextBoxColumn.Name = "eSTADOIDESTADODataGridViewTextBoxColumn";
            // 
            // pERMISOIDPERMISODataGridViewTextBoxColumn
            // 
            this.pERMISOIDPERMISODataGridViewTextBoxColumn.DataPropertyName = "PERMISO_IDPERMISO";
            this.pERMISOIDPERMISODataGridViewTextBoxColumn.HeaderText = "PERMISO_IDPERMISO";
            this.pERMISOIDPERMISODataGridViewTextBoxColumn.Name = "pERMISOIDPERMISODataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
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
            // FrmTipos
            // 
            this.ClientSize = new System.Drawing.Size(607, 423);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTipos";
            this.Load += new System.EventHandler(this.FrmTipos_Load);
            this.panel1.ResumeLayout(false);
            this.ListarTipo.ResumeLayout(false);
            this.ListarTipo.PerformLayout();
            this.IngresarTipo.ResumeLayout(false);
            this.IngresarTipo.PerformLayout();
            this.InicioTipos.ResumeLayout(false);
            this.InicioTipos.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmTipos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.TIPO' Puede moverla o quitarla según sea necesario.
            this.tIPOTableAdapter.Fill(this.dataSet2.TIPO);

        }
    }
}
