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
    public partial class ABMempleados : Form
    {
        public ABMempleados()
        {
            InitializeComponent();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            bool tx = true;
            Inicio ini = new Inicio(tx);
            this.Hide();
            ini.ShowDialog();
        }

        private void ABMempleados_Load(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            Empleado emp = new Empleado();
            DS = emp.MostrarEmpleado();
            dataGridView1.DataSource = DS.Tables[0];
            dataGridView1.Columns["idEmpleado"].Visible = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            NuevoEmpleado nuevo = new NuevoEmpleado();
            this.Hide();
            nuevo.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Id;
                int IdAux;
                Id = dataGridView1.CurrentRow.Cells["idEmpleado"].Value.ToString();
                IdAux = int.Parse(Id);
                Empleado emp = new Empleado();
                if (emp.EliminarEmpleado(IdAux) == true)
                {
                    MessageBox.Show("El empleado se borro con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el empleado");
                }
                DataSet DS = new DataSet();
                emp = new Empleado();
                DS = emp.MostrarEmpleado();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar");
            }

        }

        private void EditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre, direccion, Id, dni, horas, valor, sueldo;
                int IdAux, dniAux, horasAux, valorAux, sueldoAux;
                


                Empleado emp = new Empleado();
                Id = dataGridView1.CurrentRow.Cells["idEmpleado"].Value.ToString();
                dni = dataGridView1.CurrentRow.Cells["dni"].Value.ToString();
                nombre = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                direccion = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                horas = dataGridView1.CurrentRow.Cells["horas"].Value.ToString();
                valor = dataGridView1.CurrentRow.Cells["Xhs"].Value.ToString();
                sueldo = dataGridView1.CurrentRow.Cells["Sueldo"].Value.ToString();
                
                IdAux = int.Parse(Id);
                dniAux = int.Parse(dni);
                horasAux = int.Parse(horas);
                valorAux = int.Parse(valor);
                sueldoAux = int.Parse(sueldo);
              



                if (emp.ModificarEmpleado(IdAux, dniAux, nombre, direccion, horasAux, valorAux, sueldoAux) == true)
                {
                    MessageBox.Show("El empleado se modifico con exito");
                }
                else
                {
                    MessageBox.Show("La modificacion no se pudo realizar");
                }
                DataSet DS = new DataSet();
                emp = new Empleado();
                DS = emp.MostrarEmpleado();
                dataGridView1.DataSource = DS.Tables[0];


            }
            else
            {
                MessageBox.Show("Seleccione la fila modificar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Refresh();
            if (!AgregarNuevo.Text.Trim().Equals(""))
            {
                DataSet DS = new DataSet();
                Empleado emp = new Empleado();
                DS = emp.MostrarEmpleadoBuscado(AgregarNuevo.Text.Trim());
                try
                {
                    dataGridView1.DataSource = DS.Tables[0];
                }
                finally
                {

                }
            }
        }
    }

       
    
}
