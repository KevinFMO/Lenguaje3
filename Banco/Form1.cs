using LibreriaCoches;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //OBJETO de las clases
        Cliente cliente;
        Cuenta cuenta;
        MovimientoCuenta movimientoCuenta;


        private void CrearCuentaButton_Click(object sender, EventArgs e)
        {
            //instancia del objeto cliente
            cliente = new Cliente(IdentidadTextBox.Text, NombreClienteTextBox.Text);

            cuenta = new Cuenta(NumeroCuentaTextBox.Text, cliente, DateTime.Now, 0);
            MessageBox.Show("Cuenta creada exitosamente");

            SaldoTextBox.Text = cuenta.Saldo.ToString("N"); //"N" para agregarle , decimal
        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            if (MontoMovimientoTextBox.Text == "")
            {
                errorProvider1.SetError(MontoMovimientoTextBox, "Digito un monto,");
                MontoMovimientoTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TipoMovimientoComboBox.Text))
            {
                errorProvider1.SetError(TipoMovimientoComboBox, "Seleccione un Tipo movimiento");
                return;
            }

            if (TipoMovimientoComboBox.Text == "Depósito")
            {
                cuenta.Depositar(Convert.ToDecimal(MontoMovimientoTextBox.Text));

                movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, Convert.ToDecimal(MontoMovimientoTextBox.Text),
                    TipoMovimientoComboBox.Text);

                MovimientoListBox.Items.Add("Depósito a la cuenta N. " + cuenta.NumeroCuenta
                                            + " Por la cantidad de L. " + movimientoCuenta.Monto
                                            + " Con fecha: " + movimientoCuenta.Fecha);

                SaldoTextBox.Text = cuenta.Saldo.ToString();
            }
            else if (TipoMovimientoComboBox.Text == "Retiro")
            {
                bool pudoRetirar = cuenta.Retirar(Convert.ToDecimal(MontoMovimientoTextBox.Text));

                if (pudoRetirar)
                {
                    movimientoCuenta = new MovimientoCuenta(cuenta, DateTime.Now, 
                                                 Convert.ToDecimal(MontoMovimientoTextBox.Text), TipoMovimientoComboBox.Text);

                }
                else
                {
                    MessageBox.Show("La cuenta No. " + cuenta.NumeroCuenta + " no tiene saldo disponible para trasnsaccionar");
                }
            }
            

        }
    }
}
