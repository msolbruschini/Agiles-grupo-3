﻿namespace Interfez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Items = new System.Windows.Forms.ListBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarProducto = new System.Windows.Forms.Button();
            this.EditarPedido = new System.Windows.Forms.Button();
            this.CrearPedido = new System.Windows.Forms.Button();
            this.textoProducto = new System.Windows.Forms.ComboBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoPrecio = new System.Windows.Forms.TextBox();
            this.textoCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EliminarPedido = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelMesaVacia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botonAbrirMesa = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p4 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.p9 = new System.Windows.Forms.Panel();
            this.p10 = new System.Windows.Forms.Panel();
            this.p11 = new System.Windows.Forms.Panel();
            this.p12 = new System.Windows.Forms.Panel();
            this.p13 = new System.Windows.Forms.Panel();
            this.p8 = new System.Windows.Forms.Panel();
            this.p7 = new System.Windows.Forms.Panel();
            this.p5 = new System.Windows.Forms.Panel();
            this.p6 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.barra = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 720);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Interfez.Properties.Resources.Pedidos1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel21);
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Controls.Add(this.panel19);
            this.panel1.Controls.Add(this.panel18);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.Items);
            this.panel1.Controls.Add(this.BtnVolver);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboEstado);
            this.panel1.Controls.Add(this.textDireccion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AgregarProducto);
            this.panel1.Controls.Add(this.EditarPedido);
            this.panel1.Controls.Add(this.CrearPedido);
            this.panel1.Controls.Add(this.textoProducto);
            this.panel1.Controls.Add(this.textoNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textoPrecio);
            this.panel1.Controls.Add(this.textoCantidad);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EliminarPedido);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 683);
            this.panel1.TabIndex = 2;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.Black;
            this.panel21.Location = new System.Drawing.Point(274, 405);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(167, 3);
            this.panel21.TabIndex = 29;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Black;
            this.panel20.Location = new System.Drawing.Point(276, 358);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(167, 3);
            this.panel20.TabIndex = 28;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Black;
            this.panel19.Location = new System.Drawing.Point(486, 308);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(54, 3);
            this.panel19.TabIndex = 27;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Black;
            this.panel18.Location = new System.Drawing.Point(274, 310);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(88, 3);
            this.panel18.TabIndex = 26;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Location = new System.Drawing.Point(274, 267);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(234, 3);
            this.panel17.TabIndex = 25;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Location = new System.Drawing.Point(275, 218);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(264, 3);
            this.panel16.TabIndex = 24;
            // 
            // Items
            // 
            this.Items.BackColor = System.Drawing.Color.Black;
            this.Items.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.ForeColor = System.Drawing.Color.White;
            this.Items.FormattingEnabled = true;
            this.Items.ItemHeight = 24;
            this.Items.Location = new System.Drawing.Point(167, 423);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(372, 172);
            this.Items.TabIndex = 4;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.Black;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(17, 628);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(92, 37);
            this.BtnVolver.TabIndex = 23;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11.25F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(448, 333);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 28);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Entregar";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(448, 376);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 32);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Pagado";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(162, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.ForeColor = System.Drawing.Color.Black;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "En preparación",
            "Listo",
            "Entregado"});
            this.comboEstado.Location = new System.Drawing.Point(274, 380);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(168, 28);
            this.comboEstado.TabIndex = 19;
            // 
            // textDireccion
            // 
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDireccion.ForeColor = System.Drawing.Color.Black;
            this.textDireccion.HideSelection = false;
            this.textDireccion.Location = new System.Drawing.Point(276, 341);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(167, 20);
            this.textDireccion.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dirección";
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarProducto.BackgroundImage")));
            this.AgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProducto.ForeColor = System.Drawing.Color.White;
            this.AgregarProducto.Location = new System.Drawing.Point(510, 242);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(29, 28);
            this.AgregarProducto.TabIndex = 14;
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // EditarPedido
            // 
            this.EditarPedido.BackColor = System.Drawing.Color.Black;
            this.EditarPedido.FlatAppearance.BorderSize = 0;
            this.EditarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarPedido.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarPedido.ForeColor = System.Drawing.Color.White;
            this.EditarPedido.Location = new System.Drawing.Point(319, 628);
            this.EditarPedido.Name = "EditarPedido";
            this.EditarPedido.Size = new System.Drawing.Size(166, 37);
            this.EditarPedido.TabIndex = 13;
            this.EditarPedido.Text = "Editar";
            this.EditarPedido.UseVisualStyleBackColor = false;
            // 
            // CrearPedido
            // 
            this.CrearPedido.BackColor = System.Drawing.Color.Black;
            this.CrearPedido.FlatAppearance.BorderSize = 0;
            this.CrearPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearPedido.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearPedido.ForeColor = System.Drawing.Color.White;
            this.CrearPedido.Location = new System.Drawing.Point(129, 628);
            this.CrearPedido.Name = "CrearPedido";
            this.CrearPedido.Size = new System.Drawing.Size(166, 37);
            this.CrearPedido.TabIndex = 12;
            this.CrearPedido.Text = "Agregar";
            this.CrearPedido.UseVisualStyleBackColor = false;
            this.CrearPedido.Click += new System.EventHandler(this.CrearPedido_Click);
            // 
            // textoProducto
            // 
            this.textoProducto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoProducto.ForeColor = System.Drawing.Color.Black;
            this.textoProducto.FormattingEnabled = true;
            this.textoProducto.Items.AddRange(new object[] {
            "Cerveza Negra",
            "Cerveza rubia",
            "Papas fritas con ajo",
            "Hamburguesa completa",
            "UltraShot"});
            this.textoProducto.Location = new System.Drawing.Point(274, 242);
            this.textoProducto.Name = "textoProducto";
            this.textoProducto.Size = new System.Drawing.Size(234, 28);
            this.textoProducto.TabIndex = 11;
            this.textoProducto.SelectedIndexChanged += new System.EventHandler(this.textoProducto_SelectedIndexChanged);
            // 
            // textoNombre
            // 
            this.textoNombre.BackColor = System.Drawing.Color.White;
            this.textoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoNombre.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNombre.ForeColor = System.Drawing.Color.Black;
            this.textoNombre.HideSelection = false;
            this.textoNombre.Location = new System.Drawing.Point(275, 198);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(264, 20);
            this.textoNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(162, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // textoPrecio
            // 
            this.textoPrecio.BackColor = System.Drawing.Color.White;
            this.textoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrecio.ForeColor = System.Drawing.Color.Black;
            this.textoPrecio.Location = new System.Drawing.Point(274, 291);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(88, 20);
            this.textoPrecio.TabIndex = 6;
            // 
            // textoCantidad
            // 
            this.textoCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCantidad.Location = new System.Drawing.Point(486, 291);
            this.textoCantidad.Name = "textoCantidad";
            this.textoCantidad.Size = new System.Drawing.Size(54, 20);
            this.textoCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(162, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // EliminarPedido
            // 
            this.EliminarPedido.BackColor = System.Drawing.Color.Black;
            this.EliminarPedido.FlatAppearance.BorderSize = 0;
            this.EliminarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarPedido.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarPedido.ForeColor = System.Drawing.Color.White;
            this.EliminarPedido.Location = new System.Drawing.Point(510, 628);
            this.EliminarPedido.Name = "EliminarPedido";
            this.EliminarPedido.Size = new System.Drawing.Size(166, 37);
            this.EliminarPedido.TabIndex = 0;
            this.EliminarPedido.Text = "Eliminar";
            this.EliminarPedido.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.labelMesaVacia);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.botonAbrirMesa);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mapa de mesas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelMesaVacia
            // 
            this.labelMesaVacia.AutoSize = true;
            this.labelMesaVacia.Font = new System.Drawing.Font("Microsoft JhengHei Light", 56F);
            this.labelMesaVacia.Location = new System.Drawing.Point(84, 495);
            this.labelMesaVacia.Name = "labelMesaVacia";
            this.labelMesaVacia.Size = new System.Drawing.Size(419, 95);
            this.labelMesaVacia.TabIndex = 7;
            this.labelMesaVacia.Text = "Mesa Vacía";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11F);
            this.button1.Location = new System.Drawing.Point(582, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar mesa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // botonAbrirMesa
            // 
            this.botonAbrirMesa.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.botonAbrirMesa.Location = new System.Drawing.Point(582, 16);
            this.botonAbrirMesa.Name = "botonAbrirMesa";
            this.botonAbrirMesa.Size = new System.Drawing.Size(104, 53);
            this.botonAbrirMesa.TabIndex = 5;
            this.botonAbrirMesa.Text = "Abrir Mesa";
            this.botonAbrirMesa.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(11, 424);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(563, 247);
            this.dataGridView2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.p4);
            this.groupBox1.Controls.Add(this.p2);
            this.groupBox1.Controls.Add(this.p3);
            this.groupBox1.Controls.Add(this.p1);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.p9);
            this.groupBox1.Controls.Add(this.p10);
            this.groupBox1.Controls.Add(this.p11);
            this.groupBox1.Controls.Add(this.p12);
            this.groupBox1.Controls.Add(this.p13);
            this.groupBox1.Controls.Add(this.p8);
            this.groupBox1.Controls.Add(this.p7);
            this.groupBox1.Controls.Add(this.p5);
            this.groupBox1.Controls.Add(this.p6);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 402);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapa de mesas";
            // 
            // p4
            // 
            this.p4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p4.BackgroundImage")));
            this.p4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p4.Location = new System.Drawing.Point(130, 307);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(66, 63);
            this.p4.TabIndex = 16;
            this.p4.Tag = "4";
            // 
            // p2
            // 
            this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2.BackgroundImage")));
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2.Location = new System.Drawing.Point(130, 189);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(66, 63);
            this.p2.TabIndex = 16;
            this.p2.Tag = "2";
            // 
            // p3
            // 
            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3.BackgroundImage")));
            this.p3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p3.Location = new System.Drawing.Point(28, 307);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(66, 63);
            this.p3.TabIndex = 15;
            this.p3.Tag = "3";
            // 
            // p1
            // 
            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1.BackgroundImage")));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1.Location = new System.Drawing.Point(28, 189);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(66, 63);
            this.p1.TabIndex = 14;
            this.p1.Tag = "1";
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // panel9
            // 
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Location = new System.Drawing.Point(3, 19);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(145, 142);
            this.panel9.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 20F);
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cocina";
            // 
            // p9
            // 
            this.p9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p9.BackgroundImage")));
            this.p9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p9.Location = new System.Drawing.Point(469, 84);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(91, 42);
            this.p9.TabIndex = 13;
            this.p9.Tag = "9";
            // 
            // p10
            // 
            this.p10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p10.BackgroundImage")));
            this.p10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p10.Location = new System.Drawing.Point(469, 148);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(91, 42);
            this.p10.TabIndex = 13;
            this.p10.Tag = "10";
            // 
            // p11
            // 
            this.p11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p11.BackgroundImage")));
            this.p11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p11.Location = new System.Drawing.Point(469, 210);
            this.p11.Name = "p11";
            this.p11.Size = new System.Drawing.Size(91, 42);
            this.p11.TabIndex = 13;
            this.p11.Tag = "11";
            // 
            // p12
            // 
            this.p12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p12.BackgroundImage")));
            this.p12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p12.Location = new System.Drawing.Point(469, 271);
            this.p12.Name = "p12";
            this.p12.Size = new System.Drawing.Size(91, 42);
            this.p12.TabIndex = 13;
            this.p12.Tag = "12";
            // 
            // p13
            // 
            this.p13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p13.BackgroundImage")));
            this.p13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p13.Location = new System.Drawing.Point(469, 338);
            this.p13.Name = "p13";
            this.p13.Size = new System.Drawing.Size(91, 42);
            this.p13.TabIndex = 13;
            this.p13.Tag = "13";
            // 
            // p8
            // 
            this.p8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p8.BackgroundImage")));
            this.p8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p8.Location = new System.Drawing.Point(469, 21);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(91, 42);
            this.p8.TabIndex = 12;
            this.p8.Tag = "8";
            // 
            // p7
            // 
            this.p7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p7.BackgroundImage")));
            this.p7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p7.Location = new System.Drawing.Point(276, 282);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(103, 88);
            this.p7.TabIndex = 13;
            this.p7.Tag = "7";
            // 
            // p5
            // 
            this.p5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p5.BackgroundImage")));
            this.p5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p5.Location = new System.Drawing.Point(276, 58);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(103, 88);
            this.p5.TabIndex = 11;
            this.p5.Tag = "5";
            // 
            // p6
            // 
            this.p6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p6.BackgroundImage")));
            this.p6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p6.Location = new System.Drawing.Point(276, 168);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(103, 88);
            this.p6.TabIndex = 12;
            this.p6.Tag = "6";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(692, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista de Pedidos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 357);
            this.dataGridView1.TabIndex = 4;
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.Black;
            this.barra.Controls.Add(this.BtnMinimizar);
            this.barra.Controls.Add(this.BtnCerrar);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(700, 23);
            this.barra.TabIndex = 0;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::Interfez.Properties.Resources.borrarBlanco;
            this.BtnMinimizar.Location = new System.Drawing.Point(651, 1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 740);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Los Birreros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel p9;
        private System.Windows.Forms.Panel p10;
        private System.Windows.Forms.Panel p11;
        private System.Windows.Forms.Panel p12;
        private System.Windows.Forms.Panel p13;
        private System.Windows.Forms.Panel p8;
        private System.Windows.Forms.Panel p7;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarProducto;
        private System.Windows.Forms.Button EditarPedido;
        private System.Windows.Forms.Button CrearPedido;
        private System.Windows.Forms.ComboBox textoProducto;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoPrecio;
        private System.Windows.Forms.TextBox textoCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EliminarPedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonAbrirMesa;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMesaVacia;
    }
}

