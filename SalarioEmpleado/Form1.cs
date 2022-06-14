using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateTimePicker1.Value;

            double valorVentas = Convert.ToDouble(ValorVentasTextBox.Text);
            int aniosAntiguedad = Convert.ToInt32(AñosTextBox.Text);
            double nuevoSalario;
            //MessageBox.Show("La edad del cliente es. "+DevuelveEdadPersona(fechaNacimiento).ToString());
            if (valorVentas >= 10000 && DevuelveEdadPersona(fechaNacimiento) >=30 && aniosAntiguedad >= 10)
            {
                nuevoSalario = valorVentas;
                valorVentas = valorVentas * 0.05;
                nuevoSalario = nuevoSalario + valorVentas;
                
                SalarioTextBox.Text = Convert.ToString(nuevoSalario);
            }
            else
            {
                MessageBox.Show("No cumple con los requisitos para el aumento del salario");
            }

        }

        private int DevuelveEdadPersona(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento >= fechaActual)
            {
                edad = 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;

                if (fechaNacimiento .Month > fechaActual.Month)
                {
                    --edad;
                }
            }

            return edad;
           
        }

    }
}
