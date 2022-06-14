using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        //Propiedades de la clase
        public string Identidad { get; set; } 
        public string Nombre{ get; set; }

        //CONSTRUCTOR VACIO
        public Cliente()
        {
        }

        public Cliente(string identidad, string nombre)
        {
            Identidad = identidad;
            Nombre = nombre;
        }
    }
}
