﻿namespace Interfez
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorUsu = new System.Windows.Forms.Label();
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUsu = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.usu = new System.Windows.Forms.Label();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.BtnMinimizar);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 23);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Interfez.Properties.Resources.Inicio;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(0, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(405, 385);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.errorUsu);
            this.panel1.Controls.Add(this.IniciarSesion);
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.textUsu);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.usu);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 184);
            this.panel1.TabIndex = 0;
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
            // errorUsu
            // 
            this.errorUsu.AutoSize = true;
            this.errorUsu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUsu.ForeColor = System.Drawing.Color.Firebrick;
            this.errorUsu.Location = new System.Drawing.Point(16, 103);
            this.errorUsu.Name = "errorUsu";
            this.errorUsu.Size = new System.Drawing.Size(281, 21);
            this.errorUsu.TabIndex = 20;
            this.errorUsu.Text = "*El Usuario o Contraseña incorrecta";
            this.errorUsu.Visible = false;
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
            this.IniciarSesion.TabIndex = 19;
            this.IniciarSesion.Text = "Iniciar Sesión";
            this.IniciarSesion.UseVisualStyleBackColor = false;
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
            this.textPass.TabIndex = 18;
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
            this.textUsu.TabIndex = 16;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.Black;
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
            this.usu.ForeColor = System.Drawing.Color.Black;
            this.usu.Location = new System.Drawing.Point(15, 8);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(82, 25);
            this.usu.TabIndex = 15;
            this.usu.Text = "Usuario";
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Interfez.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(382, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Birreros";
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorUsu;
        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUsu;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label usu;
    }
}