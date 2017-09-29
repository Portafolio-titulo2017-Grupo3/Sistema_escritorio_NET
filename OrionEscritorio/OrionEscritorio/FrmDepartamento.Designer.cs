namespace OrionEscritorio
{
    partial class FrmDepartamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CrearMotivo = new System.Windows.Forms.TabPage();
            this.CrearNDepto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomDpto = new System.Windows.Forms.TextBox();
            this.ModificarMotivo = new System.Windows.Forms.TabPage();
            this.BtnListar = new System.Windows.Forms.Button();
            this.btnMDpto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMDptoNom = new System.Windows.Forms.TextBox();
            this.txtBuscarDpto = new System.Windows.Forms.TextBox();
            this.dataListar = new System.Windows.Forms.DataGridView();
            this.btnBuscarDpto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CrearMotivo.SuspendLayout();
            this.ModificarMotivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 399);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CrearMotivo);
            this.tabControl1.Controls.Add(this.ModificarMotivo);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(583, 354);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CrearMotivo
            // 
            this.CrearMotivo.Controls.Add(this.CrearNDepto);
            this.CrearMotivo.Controls.Add(this.label4);
            this.CrearMotivo.Controls.Add(this.label2);
            this.CrearMotivo.Controls.Add(this.txtNomDpto);
            this.CrearMotivo.Location = new System.Drawing.Point(4, 22);
            this.CrearMotivo.Name = "CrearMotivo";
            this.CrearMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.CrearMotivo.Size = new System.Drawing.Size(583, 354);
            this.CrearMotivo.TabIndex = 0;
            this.CrearMotivo.Text = "Crear Departamento";
            this.CrearMotivo.UseVisualStyleBackColor = true;
            // 
            // CrearNDepto
            // 
            this.CrearNDepto.Location = new System.Drawing.Point(219, 153);
            this.CrearNDepto.Name = "CrearNDepto";
            this.CrearNDepto.Size = new System.Drawing.Size(169, 24);
            this.CrearNDepto.TabIndex = 7;
            this.CrearNDepto.Text = "Crear Nuevo Departamento";
            this.CrearNDepto.UseVisualStyleBackColor = true;
            this.CrearNDepto.Click += new System.EventHandler(this.CrearNDepto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crear Nuevo Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Depto";
            // 
            // txtNomDpto
            // 
            this.txtNomDpto.Location = new System.Drawing.Point(192, 75);
            this.txtNomDpto.Name = "txtNomDpto";
            this.txtNomDpto.Size = new System.Drawing.Size(232, 20);
            this.txtNomDpto.TabIndex = 1;
            // 
            // ModificarMotivo
            // 
            this.ModificarMotivo.Controls.Add(this.btnBuscarDpto);
            this.ModificarMotivo.Controls.Add(this.BtnListar);
            this.ModificarMotivo.Controls.Add(this.btnMDpto);
            this.ModificarMotivo.Controls.Add(this.label6);
            this.ModificarMotivo.Controls.Add(this.txtMDptoNom);
            this.ModificarMotivo.Controls.Add(this.txtBuscarDpto);
            this.ModificarMotivo.Controls.Add(this.dataListar);
            this.ModificarMotivo.Location = new System.Drawing.Point(4, 22);
            this.ModificarMotivo.Name = "ModificarMotivo";
            this.ModificarMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarMotivo.Size = new System.Drawing.Size(583, 354);
            this.ModificarMotivo.TabIndex = 1;
            this.ModificarMotivo.Text = "Modificar Departamento";
            this.ModificarMotivo.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(39, 39);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar Dpto";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click_1);
            // 
            // btnMDpto
            // 
            this.btnMDpto.Location = new System.Drawing.Point(156, 287);
            this.btnMDpto.Name = "btnMDpto";
            this.btnMDpto.Size = new System.Drawing.Size(100, 23);
            this.btnMDpto.TabIndex = 7;
            this.btnMDpto.Text = "Modificar Dpto";
            this.btnMDpto.UseVisualStyleBackColor = true;
            this.btnMDpto.Click += new System.EventHandler(this.btnMDpto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre Dpto";
            // 
            // txtMDptoNom
            // 
            this.txtMDptoNom.Location = new System.Drawing.Point(156, 208);
            this.txtMDptoNom.Name = "txtMDptoNom";
            this.txtMDptoNom.Size = new System.Drawing.Size(100, 20);
            this.txtMDptoNom.TabIndex = 3;
            // 
            // txtBuscarDpto
            // 
            this.txtBuscarDpto.Location = new System.Drawing.Point(339, 154);
            this.txtBuscarDpto.Name = "txtBuscarDpto";
            this.txtBuscarDpto.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarDpto.TabIndex = 2;
            // 
            // dataListar
            // 
            this.dataListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListar.Location = new System.Drawing.Point(39, 68);
            this.dataListar.Name = "dataListar";
            this.dataListar.Size = new System.Drawing.Size(516, 78);
            this.dataListar.TabIndex = 0;
            // 
            // btnBuscarDpto
            // 
            this.btnBuscarDpto.Location = new System.Drawing.Point(446, 150);
            this.btnBuscarDpto.Name = "btnBuscarDpto";
            this.btnBuscarDpto.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarDpto.TabIndex = 9;
            this.btnBuscarDpto.Text = "Buscar Dpto";
            this.btnBuscarDpto.UseVisualStyleBackColor = true;
            this.btnBuscarDpto.Click += new System.EventHandler(this.btnBuscarDpto_Click);
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 421);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDepartamento";
            this.Text = "FrmDepartamento";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CrearMotivo.ResumeLayout(false);
            this.CrearMotivo.PerformLayout();
            this.ModificarMotivo.ResumeLayout(false);
            this.ModificarMotivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CrearMotivo;
        private System.Windows.Forms.Button CrearNDepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomDpto;
        private System.Windows.Forms.TabPage ModificarMotivo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button btnMDpto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMDptoNom;
        private System.Windows.Forms.TextBox txtBuscarDpto;
        private System.Windows.Forms.DataGridView dataListar;
        private System.Windows.Forms.Button btnBuscarDpto;
    }
}