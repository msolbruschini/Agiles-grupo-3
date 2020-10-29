using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio2;

namespace Interfez
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        

        private void msgError(string msg)
        {
            errorMsg.Text = msg;
            errorMsg.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textPass.Text = "";
            textPass.UseSystemPasswordChar = false;
            textUsu.Text = " ";
            errorMsg.Visible = false;
            //this.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            if (textUsu.Text != " " && textUsu.TextLength > 2)
            {
                if (textPass.Text != " ")
                {
                    IniciarSesionUsuario user = new IniciarSesionUsuario();
                    var validLogin = user.LoginUser(textUsu.Text, textPass.Text);
                    if (validLogin == true)
                    {
                        Relleno rell = new Relleno();
                        rell.Show();
                        rell.FormClosed += Logout;
                        this.Close();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecta");
                        textPass.Text = " ";
                        textPass.UseSystemPasswordChar = false;
                        textUsu.Focus();
                    }
                }
                else
                {
                    msgError("Ingrese contraseña.");
                }
            }
            else
            {
                msgError("Ingrese usuario.");
            }

            /*if (textUsu.Text == "Admin" && textPass.Text == "123456")
            {
                Relleno rell = new Relleno();
                this.Hide();
                rell.ShowDialog();
                
            }
            else
            {
                errorMsg.Visible = true;
                
            }*/
        }

        
    }
}
