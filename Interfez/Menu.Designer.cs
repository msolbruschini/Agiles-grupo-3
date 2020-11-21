namespace Interfez
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AgregarNuevo = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.EditarProducto = new System.Windows.Forms.Button();
            this.CrearProducto = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.BtnMinimizar);
            this.panel4.Controls.Add(this.BtnCerrar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 23);
            this.panel4.TabIndex = 12;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Interfez.Properties.Resources.borrarBlanco;
            this.BtnMinimizar.Location = new System.Drawing.Point(652, 1);
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
            this.BtnCerrar.Location = new System.Drawing.Point(677, 1);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 19);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 720);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Interfez.Properties.Resources.WhatsApp_Image_2020_11_19_at_11_43_06_AM;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel16);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.AgregarNuevo);
            this.tabPage1.Controls.Add(this.BtnBuscar);
            this.tabPage1.Controls.Add(this.EditarProducto);
            this.tabPage1.Controls.Add(this.CrearProducto);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(481, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Location = new System.Drawing.Point(197, 212);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(301, 3);
            this.panel16.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 256);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 329);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AgregarNuevo
            // 
            this.AgregarNuevo.BackColor = System.Drawing.Color.White;
            this.AgregarNuevo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgregarNuevo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarNuevo.Location = new System.Drawing.Point(197, 190);
            this.AgregarNuevo.Name = "AgregarNuevo";
            this.AgregarNuevo.Size = new System.Drawing.Size(301, 25);
            this.AgregarNuevo.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Black;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(504, 183);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(166, 37);
            this.BtnBuscar.TabIndex = 16;
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
            this.EditarProducto.Location = new System.Drawing.Point(272, 616);
            this.EditarProducto.Name = "EditarProducto";
            this.EditarProducto.Size = new System.Drawing.Size(170, 37);
            this.EditarProducto.TabIndex = 17;
            this.EditarProducto.Text = "Editar";
            this.EditarProducto.UseVisualStyleBackColor = false;
            this.EditarProducto.Click += new System.EventHandler(this.EditarProducto_Click);
            // 
            // CrearProducto
            // 
            this.CrearProducto.BackColor = System.Drawing.Color.Black;
            this.CrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrearProducto.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.CrearProducto.ForeColor = System.Drawing.Color.White;
            this.CrearProducto.Location = new System.Drawing.Point(68, 616);
            this.CrearProducto.Name = "CrearProducto";
            this.CrearProducto.Size = new System.Drawing.Size(166, 37);
            this.CrearProducto.TabIndex = 18;
            this.CrearProducto.Text = "Agregar";
            this.CrearProducto.UseVisualStyleBackColor = false;
            this.CrearProducto.Click += new System.EventHandler(this.CrearProducto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(700, 740);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Birreros";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox AgregarNuevo;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button EditarProducto;
        private System.Windows.Forms.Button CrearProducto;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button button1;
    }
}