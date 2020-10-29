﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfez
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if(textUsu.Text == "Admin" && textPass.Text == "123456")
            {
                Relleno rell = new Relleno();
                this.Hide();
                rell.ShowDialog();
                
            }
            else
            {
                errorUsu.Visible = true;
                
            }




        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
