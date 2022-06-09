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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }


        private void GenerarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;


            if(cadena.Length == 0)
            {
                MessageBox.Show("Debe ingresar una cedena");
                CadenaTextBox.Focus(); //focus vuelve acolocar el curso en la caja de texto
                return; //corta la ejcución
            }


                                              //ToString para covertir a string
            LongitudLabel.Text = cadena.Length.ToString();  //para ver la longitud de una cadena

            PrimerCaracterLabel.Text = cadena.Substring(0, 1); //devuelve caracteres que queramos con l posicion

            UltimoCaracterLabel.Text = cadena.Substring(cadena.Length - 1); //devuelve la ultima posicion de la cadena

            MayusculasLabel.Text = cadena.ToUpper(); //convierte todo en mayusculas

            MinusculasLabel.Text = cadena.ToLower(); //convierte todo a minusculas

            ReemplazarLabel.Text = cadena.Replace("f", "*");  //reemplaza el caracter que queramos por lo que queramos
        }

        
    }
}
