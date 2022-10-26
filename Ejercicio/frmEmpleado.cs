using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Empleado nuevo = new Empleado();
            EmpleadoConexion conexion = new EmpleadoConexion();

            nuevo.NombreCompleto = textNombreCompleto.Text;
            nuevo.DNI = textDNI.Text;
            nuevo.Edad = int.Parse(textEdad.Text);
            nuevo.Casado = checkBoxCasado.Checked ? true : false;
            nuevo.Salario = decimal.Parse(textSalario.Text);

            conexion.agregar(nuevo);

            MessageBox.Show("Se agregó satisfactoriamente.");
            Close();
        }
    }
}
