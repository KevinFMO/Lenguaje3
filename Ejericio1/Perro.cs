using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1
{
    public class Perro
    {
        //atributos de la clase
        private string nombre, raza;
        private decimal altura;

        //propiedades
        public string Nombre { 
            get { return nombre;  } 
            set { nombre = value; } 
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        //otra manera de crear propiedades
        //public string Nombre { get; set; }
        //public string Raza { get; set; }
        //public decimal Altura { get; set; }

        //CONSTRUCTROR VACIO
        public Perro()
        {
        }
        //constructor
        public Perro(string nombre, string raza, decimal altura)
        {
            Nombre = nombre;
            Raza = raza;
            Altura = altura;
        }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }


        //metodos
        public decimal DevuelveAltura()
        {
            return Altura;
        }

        public string Comer(string comida)
        {
            return nombre + " comerá "+comida;
        }

       
    }
}
