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
    public partial class Vectores : Form
    {
        public Vectores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vectores
            int[] vector1 = new int[5];

            //para llenar el vector inicilizandolo
            int []vector2 = new int[5] { 1,2,3,4,5 };

            //sin asignarle el tamaño
            int[] vector3 = new int[] { 1, 2, 3, 4, 5, 6 };
            //otra forma de lo de arriba
            int[] vector4 = { 1, 2, 3 };

            //vector tipo string
            string[] vector5 = { "Juan", "Fernando","Julian", "Marcos" };

            for (int i = 0; i < vector5.Length; i++)
            {
              //  listBox1.Items.Add(vector5[i]);

            }

            //FOR EACH para iumprimir vector
            foreach(string impresion in vector5)
            {
                listBox1.Items.Add(impresion);
            }
                  
        }

        private void MatrizButton_Click(object sender, EventArgs e)
        {
            //declarar una matriz
            int[,] matrizDeEjemplo = new int[2, 3] { { 2, 3, 5 }, { 5, 8, 9 } };
            //para definir un valor en la posicion que queramos
            matrizDeEjemplo[0,0] = 1;



            //llenar una matriz
            int[,] matriz = new int[2, 3];

            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {

                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    matriz[fila, columna] = 1 + (fila + 3) * (columna + 1);
                }

            }

            //impresion de la matriz
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {

                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    listBox2.Items.Add("La posición: [" + fila + " " + columna + "] = " + matriz[fila,columna]);
                }

            }

        }
    }
}
