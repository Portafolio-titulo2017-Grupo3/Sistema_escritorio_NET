namespace OrionEscritorio
{
    partial class FrmUsuarios
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
            this.inicio = new System.Windows.Forms.TabPage();
            this.CrearUsuario = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCUsuario = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ModificarUsuario = new System.Windows.Forms.TabPage();
            this.BtnListar = new System.Windows.Forms.Button();
            this.btnModUsu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModPass = new System.Windows.Forms.TextBox();
            this.txtModUsu = new System.Windows.Forms.TextBox();
            this.txtBUser = new System.Windows.Forms.TextBox();
            this.btnBuscarUsu = new System.Windows.Forms.Button();
            this.dataListar = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CrearUsuario.SuspendLayout();
            this.ModificarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 513);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inicio);
            this.tabControl1.Controls.Add(this.CrearUsuario);
            this.tabControl1.Controls.Add(this.ModificarUsuario);
            this.tabControl1.Location = new System.Drawing.Point(20, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 454);
            this.tabControl1.TabIndex = 2;
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(4, 22);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(554, 428);
            this.inicio.TabIndex = 2;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            // 
            // CrearUsuario
            // 
            this.CrearUsuario.Controls.Add(this.label5);
            this.CrearUsuario.Controls.Add(this.txtFuncionario);
            this.CrearUsuario.Controls.Add(this.label4);
            this.CrearUsuario.Controls.Add(this.cbxPerfil);
            this.CrearUsuario.Controls.Add(this.label3);
            this.CrearUsuario.Controls.Add(this.label2);
            this.CrearUsuario.Controls.Add(this.label1);
            this.CrearUsuario.Controls.Add(this.btnCUsuario);
            this.CrearUsuario.Controls.Add(this.txtPassword);
            this.CrearUsuario.Controls.Add(this.txtUsuario);
            this.CrearUsuario.Location = new System.Drawing.Point(4, 22);
            this.CrearUsuario.Name = "CrearUsuario";
            this.CrearUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.CrearUsuario.Size = new System.Drawing.Size(554, 428);
            this.CrearUsuario.TabIndex = 0;
            this.CrearUsuario.Text = "Crear Usuarios";
            this.CrearUsuario.UseVisualStyleBackColor = true;
            this.CrearUsuario.Click += new System.EventHandler(this.CrearUsuario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perfil";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(144, 172);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(136, 20);
            this.txtFuncionario.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Id del funcionario";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Items.AddRange(new object[] {
            "Seleccione un perfil"});
            this.cbxPerfil.Location = new System.Drawing.Point(144, 198);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(136, 21);
            this.cbxPerfil.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevo Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Perfil";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(144, 172);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(136, 20);
            this.txtFuncionario.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Id del funcionario";
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Items.AddRange(new object[] {
            "Seleccione un perfil"});
            this.cbxPerfil.Location = new System.Drawing.Point(144, 198);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(136, 21);
            this.cbxPerfil.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevo Usuario";
            // 
            // btnCUsuario
            // 
            this.btnCUsuario.Location = new System.Drawing.Point(144, 240);
            this.btnCUsuario.Name = "btnCUsuario";
            this.btnCUsuario.Size = new System.Drawing.Size(136, 24);
            this.btnCUsuario.TabIndex = 7;
            this.btnCUsuario.Text = "Crear Nuevo Usuario";
            this.btnCUsuario.UseVisualStyleBackColor = true;
            this.btnCUsuario.Click += new System.EventHandler(this.btnCUsuario_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(144, 116);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(136, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Controls.Add(this.BtnListar);
            this.ModificarUsuario.Controls.Add(this.btnModUsu);
            this.ModificarUsuario.Controls.Add(this.label7);
            this.ModificarUsuario.Controls.Add(this.label6);
            this.ModificarUsuario.Controls.Add(this.txtModPass);
            this.ModificarUsuario.Controls.Add(this.txtModUsu);
            this.ModificarUsuario.Controls.Add(this.txtBUser);
            this.ModificarUsuario.Controls.Add(this.btnBuscarUsu);
            this.ModificarUsuario.Controls.Add(this.dataListar);
            this.ModificarUsuario.Location = new System.Drawing.Point(4, 22);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarUsuario.Size = new System.Drawing.Size(554, 428);
            this.ModificarUsuario.TabIndex = 1;
            this.ModificarUsuario.Text = "Modificar Usuarios";
            this.ModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Location = new System.Drawing.Point(39, 39);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(95, 23);
            this.BtnListar.TabIndex = 8;
            this.BtnListar.Text = "Listar Usuario";
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnModUsu
            // 

            /*this.button3.Location = new System.Drawing.Point(156, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modificar Usuario";
            this.button3.UseVisualStyleBackColor = true;*/

            this.btnModUsu.Location = new System.Drawing.Point(156, 287);
            this.btnModUsu.Name = "btnModUsu";
            this.btnModUsu.Size = new System.Drawing.Size(100, 23);
            this.btnModUsu.TabIndex = 7;
            this.btnModUsu.Text = "Modificar Motivo";
            this.btnModUsu.UseVisualStyleBackColor = true;
            this.btnModUsu.Click += new System.EventHandler(this.btnModUsu_Click);

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
            // txtModPass
            // 
            this.txtModPass.Location = new System.Drawing.Point(156, 246);
            this.txtModPass.Name = "txtModPass";
            this.txtModPass.Size = new System.Drawing.Size(100, 20);
            this.txtModPass.TabIndex = 4;
            // 
            // txtModUsu
            // 
            this.txtModUsu.Location = new System.Drawing.Point(156, 208);
            this.txtModUsu.Name = "txtModUsu";
            this.txtModUsu.Size = new System.Drawing.Size(100, 20);
            this.txtModUsu.TabIndex = 3;
            // 
            // txtBUser
            // 
            this.txtBUser.Location = new System.Drawing.Point(265, 167);
            this.txtBUser.Name = "txtBUser";
            this.txtBUser.Size = new System.Drawing.Size(100, 20);
            this.txtBUser.TabIndex = 2;
            // 
            // btnBuscarUsu
            // 

            /*this.BuscarMotivo.Location = new System.Drawing.Point(371, 165);
            this.BuscarMotivo.Name = "BuscarMotivo";
            this.BuscarMotivo.Size = new System.Drawing.Size(110, 23);
            this.BuscarMotivo.TabIndex = 1;
            this.BuscarMotivo.Text = "Seleccionar Usuario";
            this.BuscarMotivo.UseVisualStyleBackColor = true;
            this.BuscarMotivo.Click += new System.EventHandler(this.BuscarMotivo_Click);
            */
            this.btnBuscarUsu.Location = new System.Drawing.Point(371, 165);
            this.btnBuscarUsu.Name = "btnBuscarUsu";
            this.btnBuscarUsu.Size = new System.Drawing.Size(110, 23);
            this.btnBuscarUsu.TabIndex = 1;
            this.btnBuscarUsu.Text = "Seleccionar Motivo";
            this.btnBuscarUsu.UseVisualStyleBackColor = true;
            this.btnBuscarUsu.Click += new System.EventHandler(this.BuscarMotivo_Click);

            // 
            // dataListar
            // 
            this.dataListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListar.Location = new System.Drawing.Point(39, 68);
            this.dataListar.Name = "dataListar";
            this.dataListar.Size = new System.Drawing.Size(422, 78);
            this.dataListar.TabIndex = 0;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CrearUsuario.ResumeLayout(false);
            this.CrearUsuario.PerformLayout();
            this.ModificarUsuario.ResumeLayout(false);
            this.ModificarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inicio;
        private System.Windows.Forms.TabPage CrearUsuario;
        private System.Windows.Forms.Button btnCUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TabPage ModificarUsuario;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button btnModUsu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModPass;
        private System.Windows.Forms.TextBox txtModUsu;
        private System.Windows.Forms.TextBox txtBUser;
        private System.Windows.Forms.Button btnBuscarUsu;
        private System.Windows.Forms.DataGridView dataListar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}