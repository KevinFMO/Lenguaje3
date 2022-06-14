using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejericio1
{
    public partial class FuncionesDataTime : Form
    {
        public FuncionesDataTime()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

            //MessageBox.Show("Año: " +fecha.Year,"Formato de fecha", MessageBoxButtons.OK,MessageBoxIcon.Information);
            // MessageBox.Show("Mes: " + fecha.Month, "Formato de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
              MessageBox.Show("Día: " + fecha.Day, "Formato de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MessageBox.Show("Día: " + fecha.DayOfWeek, "Formato de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MessageBox.Show(fecha.AddDays(-3).ToLongDateString(), "Formato de fecha", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // MessageBox.Show(DevuelveEdadPersona(fecha).ToString(), "Edad", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        //funcion que devuelve la edad de la persona
        private int DevuelveEdadPersona(DateTime FechaNacimiento)
        {
            DateTime _fechaNacimiento = FechaNacimiento;

            DateTime _fechaActual = DateTime.Now; //Now es la fecha de la pc

            int edad = 0; ;

            if (_fechaNacimiento >=_fechaActual)
            {
                edad = 0;
            }
            else
            {
                edad = _fechaActual.Year - _fechaNacimiento.Year;

                if ( _fechaNacimiento.Month > _fechaActual.Month)
                {
                    --edad;
                }
            }


            return edad;

        }
    }
}
