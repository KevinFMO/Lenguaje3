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
    public partial class FormPerro : Form
    {
        public FormPerro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar un objeto de la clase perro "miPerro"= cualquier nombre
            Perro miPerro = new Perro();

            //Perro miPerro2 = new Perro("Firulais");

            //Perro miPerro3 = new Perro("Bengi","pastir",55);

            miPerro.Nombre = "Bengi";
            miPerro.Raza = "Pastor Aleman";
            miPerro.Altura = 50;
            MessageBox.Show(miPerro.Nombre + " es de raza "+miPerro.Raza +" y tiene una altura de "
                +miPerro.DevuelveAltura() +" cm.");

        }
    }
}
