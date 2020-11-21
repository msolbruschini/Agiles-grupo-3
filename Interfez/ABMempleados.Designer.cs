namespace Interfez
{
    partial class ABMempleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMempleados));
            this.barra = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AgregarNuevo = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.EditarProducto = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Black;
            this.barra.Controls.Add(this.BtnMinimizar);
            this.barra.Controls.Add(this.BtnCerrar);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(684, 23);
            this.barra.TabIndex = 1;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Interfez.Properties.Resources.borrarBlanco;
            this.BtnMinimizar.Location = new System.Drawing.Point(635, 1);
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
            this.BtnCerrar.Location = new System.Drawing.Point(661, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 19);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackgroundImage = global::Interfez.Properties.Resources.WhatsApp_Image_2020_11_19_at_12_27_12_PM;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Controls.Add(this.BtnEliminar);
            this.panelCentral.Controls.Add(this.panel16);
            this.panelCentral.Controls.Add(this.BtnVolver);
            this.panelCentral.Controls.Add(this.dataGridView1);
            this.panelCentral.Controls.Add(this.AgregarNuevo);
            this.panelCentral.Controls.Add(this.BtnBuscar);
            this.panelCentral.Controls.Add(this.EditarProducto);
            this.panelCentral.Controls.Add(this.BtnNuevo);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(0, 23);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(684, 678);
            this.panelCentral.TabIndex = 2;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Black;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(502, 623);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(170, 37);
            this.BtnEliminar.TabIndex = 34;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Location = new System.Drawing.Point(182, 226);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(301, 3);
            this.panel16.TabIndex = 33;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Black;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(12, 623);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(92, 37);
            this.BtnVolver.TabIndex = 27;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 254);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 329);
            this.dataGridView1.TabIndex = 26;
            // 
            // AgregarNuevo
            // 
            this.AgregarNuevo.BackColor = System.Drawing.Color.White;
            this.AgregarNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgregarNuevo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarNuevo.Location = new System.Drawing.Point(182, 204);
            this.AgregarNuevo.Name = "AgregarNuevo";
            this.AgregarNuevo.Size = new System.Drawing.Size(301, 25);
            this.AgregarNuevo.TabIndex = 28;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(489, 197);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(166, 37);
            this.BtnBuscar.TabIndex = 29;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // EditarProducto
            // 
            this.EditarProducto.BackColor = System.Drawing.Color.Black;
            this.EditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditarProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.EditarProducto.ForeColor = System.Drawing.Color.White;
            this.EditarProducto.Location = new System.Drawing.Point(313, 623);
            this.EditarProducto.Name = "EditarProducto";
            this.EditarProducto.Size = new System.Drawing.Size(170, 37);
            this.EditarProducto.TabIndex = 30;
            this.EditarProducto.Text = "Editar";
            this.EditarProducto.UseVisualStyleBackColor = false;
            this.EditarProducto.Click += new System.EventHandler(this.EditarProducto_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.Black;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(126, 623);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(166, 37);
            this.BtnNuevo.TabIndex = 31;
            this.BtnNuevo.Text = "Agregar";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ABMempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 701);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMempleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMempleados";
            this.Load += new System.EventHandler(this.ABMempleados_Load);
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AgregarNuevo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button EditarProducto;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
    }
}