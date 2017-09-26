namespace OrionEscritorio
{
    partial class FrmTipos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inicio = new System.Windows.Forms.TabPage();
            this.CrearTipo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ModificarTipo = new System.Windows.Forms.TabPage();
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
            this.CrearTipo.SuspendLayout();
            this.ModificarTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inicio);
            this.tabControl1.Controls.Add(this.CrearTipo);
            this.tabControl1.Controls.Add(this.ModificarTipo);
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
            // CrearTipo
            // 
            this.CrearTipo.Controls.Add(this.button1);
            this.CrearTipo.Controls.Add(this.textBox2);
            this.CrearTipo.Controls.Add(this.textBox1);
            this.CrearTipo.Location = new System.Drawing.Point(4, 22);
            this.CrearTipo.Name = "CrearTipo";
            this.CrearTipo.Padding = new System.Windows.Forms.Padding(3);
            this.CrearTipo.Size = new System.Drawing.Size(506, 342);
            this.CrearTipo.TabIndex = 0;
            this.CrearTipo.Text = "Crear Tipo";
            this.CrearTipo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear Nuevo Motivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ModificarTipo
            // 
            this.ModificarTipo.Controls.Add(this.BtnListar);
            this.ModificarTipo.Controls.Add(this.button3);
            this.ModificarTipo.Controls.Add(this.label7);
            this.ModificarTipo.Controls.Add(this.label6);
            this.ModificarTipo.Controls.Add(this.textBox5);
            this.ModificarTipo.Controls.Add(this.textBox4);
            this.ModificarTipo.Controls.Add(this.textBox3);
            this.ModificarTipo.Controls.Add(this.BuscarMotivo);
            this.ModificarTipo.Controls.Add(this.dataListar);
            this.ModificarTipo.Location = new System.Drawing.Point(4, 22);
            this.ModificarTipo.Name = "ModificarTipo";
            this.ModificarTipo.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarTipo.Size = new System.Drawing.Size(506, 342);
            this.ModificarTipo.TabIndex = 1;
            this.ModificarTipo.Text = "Modificar Usuarios";
            this.ModificarTipo.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(39, 39);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar Motivo";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modificar Motivo";
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
            this.BuscarMotivo.Text = "Seleccionar Motivo";
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
            this.panel1.Location = new System.Drawing.Point(-4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 444);
            this.panel1.TabIndex = 1;
            // 
            // FrmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 453);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTipos";
            this.Text = "FrmTipos";
        
            this.tabControl1.ResumeLayout(false);
            this.CrearTipo.ResumeLayout(false);
            this.CrearTipo.PerformLayout();
            this.ModificarTipo.ResumeLayout(false);
            this.ModificarTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inicio;
        private System.Windows.Forms.TabPage CrearTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage ModificarTipo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BuscarMotivo;
        private System.Windows.Forms.DataGridView dataListar;
        private System.Windows.Forms.Panel panel1;
    }
}