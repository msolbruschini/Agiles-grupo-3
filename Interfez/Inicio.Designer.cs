namespace Interfez
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnStock = new System.Windows.Forms.Button();
            this.pIngreso = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorMsg = new System.Windows.Forms.Label();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUsu = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.usu = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panel5.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.pIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.BtnMinimizar);
            this.panel4.Controls.Add(this.BtnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 23);
            this.panel4.TabIndex = 2;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Interfez.Properties.Resources.borrarBlanco;
            this.BtnMinimizar.Location = new System.Drawing.Point(357, 1);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 19);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 4;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = global::Interfez.Properties.Resources.cerrar;
            this.BtnCerrar.Location = new System.Drawing.Point(382, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 19);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Interfez.Properties.Resources.Inicio;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.pMenu);
            this.panel5.Controls.Add(this.pIngreso);
            this.panel5.Location = new System.Drawing.Point(0, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 385);
            this.panel5.TabIndex = 3;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMenu.Controls.Add(this.BtnMenu);
            this.pMenu.Controls.Add(this.BtnEmpleados);
            this.pMenu.Controls.Add(this.BtnPedidos);
            this.pMenu.Controls.Add(this.BtnStock);
            this.pMenu.ForeColor = System.Drawing.Color.White;
            this.pMenu.Location = new System.Drawing.Point(12, 153);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(381, 184);
            this.pMenu.TabIndex = 0;
            this.pMenu.Visible = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Black;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(0, 47);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(166, 37);
            this.BtnMenu.TabIndex = 18;
            this.BtnMenu.Text = "Menú";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.Color.Black;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12.5F);
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Location = new System.Drawing.Point(209, 47);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(169, 37);
            this.BtnEmpleados.TabIndex = 17;
            this.BtnEmpleados.Text = "Gestión Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.BackColor = System.Drawing.Color.Black;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.ForeColor = System.Drawing.Color.White;
            this.BtnPedidos.Location = new System.Drawing.Point(209, 100);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(166, 37);
            this.BtnPedidos.TabIndex = 16;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = false;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.Black;
            this.BtnStock.FlatAppearance.BorderSize = 0;
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.ForeColor = System.Drawing.Color.White;
            this.BtnStock.Location = new System.Drawing.Point(0, 100);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(166, 37);
            this.BtnStock.TabIndex = 15;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // pIngreso
            // 
            this.pIngreso.BackColor = System.Drawing.Color.Transparent;
            this.pIngreso.Controls.Add(this.panel3);
            this.pIngreso.Controls.Add(this.panel2);
            this.pIngreso.Controls.Add(this.errorMsg);
            this.pIngreso.Controls.Add(this.IniciarSesion);
            this.pIngreso.Controls.Add(this.textPass);
            this.pIngreso.Controls.Add(this.textUsu);
            this.pIngreso.Controls.Add(this.pass);
            this.pIngreso.Controls.Add(this.usu);
            this.pIngreso.Location = new System.Drawing.Point(12, 153);
            this.pIngreso.Name = "pIngreso";
            this.pIngreso.Size = new System.Drawing.Size(381, 184);
            this.pIngreso.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(148, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 3);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(148, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 3);
            this.panel2.TabIndex = 14;
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.errorMsg.Location = new System.Drawing.Point(16, 103);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(281, 21);
            this.errorMsg.TabIndex = 20;
            this.errorMsg.Text = "*El Usuario o Contraseña incorrecta";
            this.errorMsg.Visible = false;
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.Black;
            this.IniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesion.ForeColor = System.Drawing.Color.White;
            this.IniciarSesion.Location = new System.Drawing.Point(109, 138);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(148, 39);
            this.IniciarSesion.TabIndex = 3;
            this.IniciarSesion.Text = "Iniciar Sesión";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.White;
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(148, 62);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(217, 22);
            this.textPass.TabIndex = 2;
            // 
            // textUsu
            // 
            this.textUsu.BackColor = System.Drawing.Color.White;
            this.textUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textUsu.Location = new System.Drawing.Point(148, 11);
            this.textUsu.Name = "textUsu";
            this.textUsu.Size = new System.Drawing.Size(217, 22);
            this.textUsu.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(15, 62);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(117, 25);
            this.pass.TabIndex = 17;
            this.pass.Text = "Contraseña";
            // 
            // usu
            // 
            this.usu.AutoSize = true;
            this.usu.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usu.ForeColor = System.Drawing.Color.White;
            this.usu.Location = new System.Drawing.Point(15, 8);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(82, 25);
            this.usu.TabIndex = 15;
            this.usu.Text = "Usuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 408);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Birreros";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pIngreso.ResumeLayout(false);
            this.pIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pIngreso;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUsu;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label usu;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnMenu;
    }
}