using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class MovimientoCuenta
    {
        //propiedades
        public Cuenta MiCuenta { get; set; }    
        public DateTime Fecha { get; set; } 
        public Decimal Monto { get; set; }
        public string TipoMivimiento { get; set; }

        //constructor
        public MovimientoCuenta()
        {
        }

        public MovimientoCuenta(Cuenta miCuenta, DateTime fecha, decimal monto, string tipoMivimiento)
        {
            MiCuenta = miCuenta;
            Fecha = fecha;
            Monto = monto;
            TipoMivimiento = tipoMivimiento;
        }
    }
}
