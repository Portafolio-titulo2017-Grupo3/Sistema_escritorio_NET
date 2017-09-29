namespace OrionEscritorio
{
    partial class FrmPerfilV2
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
            this.InicioPerfil = new System.Windows.Forms.TabPage();
            this.AgrPerfil = new System.Windows.Forms.TabPage();
            this.ModPefil = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPerfil = new System.Windows.Forms.TextBox();
            this.txtDPerfil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNPerfil = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.btnModPerfil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.txtModNom = new System.Windows.Forms.TextBox();
            this.txtBPerfil = new System.Windows.Forms.TextBox();
            this.btnBuscarPerfil = new System.Windows.Forms.Button();
            this.dataListar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AgrPerfil.SuspendLayout();
            this.ModPefil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 372);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InicioPerfil);
            this.tabControl1.Controls.Add(this.AgrPerfil);
            this.tabControl1.Controls.Add(this.ModPefil);
            this.tabControl1.Location = new System.Drawing.Point(4, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // InicioPerfil
            // 
            this.InicioPerfil.Location = new System.Drawing.Point(4, 22);
            this.InicioPerfil.Name = "InicioPerfil";
            this.InicioPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.InicioPerfil.Size = new System.Drawing.Size(573, 319);
            this.InicioPerfil.TabIndex = 0;
            this.InicioPerfil.Text = "Inicio Perfil";
            this.InicioPerfil.UseVisualStyleBackColor = true;
            // 
            // AgrPerfil
            // 
            this.AgrPerfil.Controls.Add(this.btnNPerfil);
            this.AgrPerfil.Controls.Add(this.label1);
            this.AgrPerfil.Controls.Add(this.txtDPerfil);
            this.AgrPerfil.Controls.Add(this.txtNPerfil);
            this.AgrPerfil.Controls.Add(this.label3);
            this.AgrPerfil.Controls.Add(this.label2);
            this.AgrPerfil.Location = new System.Drawing.Point(4, 22);
            this.AgrPerfil.Name = "AgrPerfil";
            this.AgrPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.AgrPerfil.Size = new System.Drawing.Size(573, 319);
            this.AgrPerfil.TabIndex = 1;
            this.AgrPerfil.Text = "Agregar Perfil";
            this.AgrPerfil.UseVisualStyleBackColor = true;
            // 
            // ModPefil
            // 
            this.ModPefil.Controls.Add(this.BtnListar);
            this.ModPefil.Controls.Add(this.btnModPerfil);
            this.ModPefil.Controls.Add(this.label7);
            this.ModPefil.Controls.Add(this.label6);
            this.ModPefil.Controls.Add(this.txtModDesc);
            this.ModPefil.Controls.Add(this.txtModNom);
            this.ModPefil.Controls.Add(this.txtBPerfil);
            this.ModPefil.Controls.Add(this.btnBuscarPerfil);
            this.ModPefil.Controls.Add(this.dataListar);
            this.ModPefil.Location = new System.Drawing.Point(4, 22);
            this.ModPefil.Name = "ModPefil";
            this.ModPefil.Size = new System.Drawing.Size(573, 319);
            this.ModPefil.TabIndex = 2;
            this.ModPefil.Text = "Modificar Perfil";
            this.ModPefil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion Perfil";
            // 
            // txtNPerfil
            // 
            this.txtNPerfil.Location = new System.Drawing.Point(203, 87);
            this.txtNPerfil.Name = "txtNPerfil";
            this.txtNPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtNPerfil.TabIndex = 4;
            // 
            // txtDPerfil
            // 
            this.txtDPerfil.Location = new System.Drawing.Point(203, 114);
            this.txtDPerfil.Name = "txtDPerfil";
            this.txtDPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtDPerfil.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuevo Perfil";
            // 
            // btnNPerfil
            // 
            this.btnNPerfil.Location = new System.Drawing.Point(203, 153);
            this.btnNPerfil.Name = "btnNPerfil";
            this.btnNPerfil.Size = new System.Drawing.Size(107, 23);
            this.btnNPerfil.TabIndex = 7;
            this.btnNPerfil.Text = "Crear Nuevo Perfil";
            this.btnNPerfil.UseVisualStyleBackColor = true;
            this.btnNPerfil.Click += new System.EventHandler(this.btnNPerfil_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(67, 24);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 17;
            this.BtnListar.Text = "Listar Perfil";
            this.BtnListar.UseVisualStyleBackColor = true;
            // 
            // btnModPerfil
            // 
            this.btnModPerfil.Location = new System.Drawing.Point(184, 272);
            this.btnModPerfil.Name = "btnModPerfil";
            this.btnModPerfil.Size = new System.Drawing.Size(100, 23);
            this.btnModPerfil.TabIndex = 16;
            this.btnModPerfil.Text = "Modificar Perfil";
            this.btnModPerfil.UseVisualStyleBackColor = true;
            this.btnModPerfil.Click += new System.EventHandler(this.btnModPerfil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descripcion Motivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre Motivo";
            // 
            // txtModDesc
            // 
            this.txtModDesc.Location = new System.Drawing.Point(184, 231);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(100, 20);
            this.txtModDesc.TabIndex = 13;
            // 
            // txtModNom
            // 
            this.txtModNom.Location = new System.Drawing.Point(184, 193);
            this.txtModNom.Name = "txtModNom";
            this.txtModNom.Size = new System.Drawing.Size(100, 20);
            this.txtModNom.TabIndex = 12;
            // 
            // txtBPerfil
            // 
            this.txtBPerfil.Location = new System.Drawing.Point(293, 152);
            this.txtBPerfil.Name = "txtBPerfil";
            this.txtBPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtBPerfil.TabIndex = 11;
            // 
            // btnBuscarPerfil
            // 
            this.btnBuscarPerfil.Location = new System.Drawing.Point(399, 150);
            this.btnBuscarPerfil.Name = "btnBuscarPerfil";
            this.btnBuscarPerfil.Size = new System.Drawing.Size(110, 23);
            this.btnBuscarPerfil.TabIndex = 10;
            this.btnBuscarPerfil.Text = "Seleccionar Perfil";
            this.btnBuscarPerfil.UseVisualStyleBackColor = true;
            this.btnBuscarPerfil.Click += new System.EventHandler(this.btnBuscarPerfil_Click);
            // 
            // dataListar
            // 
            this.dataListar.AllowUserToOrderColumns = true;
            this.dataListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListar.Location = new System.Drawing.Point(67, 53);
            this.dataListar.Name = "dataListar";
            this.dataListar.Size = new System.Drawing.Size(422, 78);
            this.dataListar.TabIndex = 9;
            // 
            // FrmPerfilV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 397);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPerfilV2";
            this.Text = "FrmPerfilV2";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.AgrPerfil.ResumeLayout(false);
            this.AgrPerfil.PerformLayout();
            this.ModPefil.ResumeLayout(false);
            this.ModPefil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InicioPerfil;
        private System.Windows.Forms.TabPage AgrPerfil;
        private System.Windows.Forms.Button btnNPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDPerfil;
        private System.Windows.Forms.TextBox txtNPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ModPefil;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button btnModPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModDesc;
        private System.Windows.Forms.TextBox txtModNom;
        private System.Windows.Forms.TextBox txtBPerfil;
        private System.Windows.Forms.Button btnBuscarPerfil;
        private System.Windows.Forms.DataGridView dataListar;
    }
}