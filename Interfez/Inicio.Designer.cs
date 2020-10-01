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
            this.usu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPass = new System.Windows.Forms.TextBox();
            this.textUsu = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usu
            // 
            this.usu.AutoSize = true;
            this.usu.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usu.Location = new System.Drawing.Point(79, 31);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(101, 31);
            this.usu.TabIndex = 0;
            this.usu.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.textUsu);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.usu);
            this.panel1.Location = new System.Drawing.Point(156, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 211);
            this.panel1.TabIndex = 1;
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.AliceBlue;
            this.textPass.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.Location = new System.Drawing.Point(253, 129);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(217, 35);
            this.textPass.TabIndex = 3;
            // 
            // textUsu
            // 
            this.textUsu.BackColor = System.Drawing.Color.AliceBlue;
            this.textUsu.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsu.Location = new System.Drawing.Point(253, 27);
            this.textUsu.Name = "textUsu";
            this.textUsu.Size = new System.Drawing.Size(217, 35);
            this.textUsu.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(79, 129);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(144, 31);
            this.pass.TabIndex = 1;
            this.pass.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Bienvenidos!";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(876, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Inicio";
            this.Text = "Los Birreros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.TextBox textUsu;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label1;
    }
}