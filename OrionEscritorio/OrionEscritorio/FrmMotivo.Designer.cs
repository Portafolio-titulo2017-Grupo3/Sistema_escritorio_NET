namespace OrionEscritorio
{
    partial class FrmMotivo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CrearNMotivo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDmotivo = new System.Windows.Forms.TextBox();
            this.txtNMotivo = new System.Windows.Forms.TextBox();
            this.ModificarMotivo = new System.Windows.Forms.TabPage();
            this.BtnListar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BuscarMotivo = new System.Windows.Forms.Button();
            this.dataListar = new System.Windows.Forms.DataGridView();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 450);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CrearMotivo);
            this.tabControl1.Controls.Add(this.ModificarMotivo);
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(583, 393);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CrearMotivo
            // 
            this.CrearMotivo.Controls.Add(this.label5);
            this.CrearMotivo.Controls.Add(this.label3);
            this.CrearMotivo.Controls.Add(this.CrearNMotivo);
            this.CrearMotivo.Controls.Add(this.label4);
            this.CrearMotivo.Controls.Add(this.label2);
            this.CrearMotivo.Controls.Add(this.label1);
            this.CrearMotivo.Controls.Add(this.txtDmotivo);
            this.CrearMotivo.Controls.Add(this.txtNMotivo);
            this.CrearMotivo.Location = new System.Drawing.Point(4, 22);
            this.CrearMotivo.Name = "CrearMotivo";
            this.CrearMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.CrearMotivo.Size = new System.Drawing.Size(583, 393);
            this.CrearMotivo.TabIndex = 0;
            this.CrearMotivo.Text = "Crear Motivos";
            this.CrearMotivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(352, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Ingrese una descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(352, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "*Ingrese el nombre del motivo";
            // 
            // CrearNMotivo
            // 
            this.CrearNMotivo.Location = new System.Drawing.Point(210, 157);
            this.CrearNMotivo.Name = "CrearNMotivo";
            this.CrearNMotivo.Size = new System.Drawing.Size(136, 24);
            this.CrearNMotivo.TabIndex = 7;
            this.CrearNMotivo.Text = "Crear Nuevo Motivo";
            this.CrearNMotivo.UseVisualStyleBackColor = true;
            this.CrearNMotivo.Click += new System.EventHandler(this.CrearNMotivo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Crear Nuevo Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Motivo";
            // 
            // txtDmotivo
            // 
            this.txtDmotivo.Location = new System.Drawing.Point(210, 107);
            this.txtDmotivo.Name = "txtDmotivo";
            this.txtDmotivo.Size = new System.Drawing.Size(136, 20);
            this.txtDmotivo.TabIndex = 1;
            // 
            // txtNMotivo
            // 
            this.txtNMotivo.Location = new System.Drawing.Point(210, 74);
            this.txtNMotivo.Name = "txtNMotivo";
            this.txtNMotivo.Size = new System.Drawing.Size(136, 20);
            this.txtNMotivo.TabIndex = 0;
            // 
            // ModificarMotivo
            // 
            this.ModificarMotivo.Controls.Add(this.BtnListar);
            this.ModificarMotivo.Controls.Add(this.button3);
            this.ModificarMotivo.Controls.Add(this.label7);
            this.ModificarMotivo.Controls.Add(this.label6);
            this.ModificarMotivo.Controls.Add(this.textBox5);
            this.ModificarMotivo.Controls.Add(this.textBox4);
            this.ModificarMotivo.Controls.Add(this.textBox3);
            this.ModificarMotivo.Controls.Add(this.BuscarMotivo);
            this.ModificarMotivo.Controls.Add(this.dataListar);
            this.ModificarMotivo.Location = new System.Drawing.Point(4, 22);
            this.ModificarMotivo.Name = "ModificarMotivo";
            this.ModificarMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarMotivo.Size = new System.Drawing.Size(583, 393);
            this.ModificarMotivo.TabIndex = 1;
            this.ModificarMotivo.Text = "Modificar Motivo";
            this.ModificarMotivo.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(39, 39);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar Motivo";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
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
            this.textBox3.Location = new System.Drawing.Point(339, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // BuscarMotivo
            // 
            this.BuscarMotivo.Location = new System.Drawing.Point(445, 152);
            this.BuscarMotivo.Name = "BuscarMotivo";
            this.BuscarMotivo.Size = new System.Drawing.Size(110, 23);
            this.BuscarMotivo.TabIndex = 1;
            this.BuscarMotivo.Text = "Seleccionar Motivo";
            this.BuscarMotivo.UseVisualStyleBackColor = true;
            this.BuscarMotivo.Click += new System.EventHandler(this.BuscarMotivo_Click);
            // 
            // dataListar
            // 
            this.dataListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListar.Location = new System.Drawing.Point(39, 68);
            this.dataListar.Name = "dataListar";
            this.dataListar.Size = new System.Drawing.Size(516, 78);
            this.dataListar.TabIndex = 0;
            // 
            // FrmMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 456);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMotivo";
            this.Text = "FrmMotivo";
            this.Load += new System.EventHandler(this.FrmMotivo_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CrearNMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDmotivo;
        private System.Windows.Forms.TextBox txtNMotivo;
        private System.Windows.Forms.TabPage ModificarMotivo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BuscarMotivo;
        private System.Windows.Forms.DataGridView dataListar;
    }
}