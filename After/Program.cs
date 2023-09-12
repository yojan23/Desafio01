// See https://aka.ms/new-console-template for more information
using After;
using System.Reflection;


Cuenta cuenta = new Cuenta();
Console.WriteLine("Cuenta Default");
Console.WriteLine("Nro Cuenta " + cuenta.NroCuenta + Environment.NewLine
                   + "Fecha de Apertura " + cuenta.FechaApertura + Environment.NewLine
                   + "Saldo " + cuenta.Saldo + Environment.NewLine
                   + "Tipo de Interes " + cuenta.TipoInteres);
cuenta.NroCuenta = 1;
cuenta.FechaApertura = new DateTime(2023, 8, 8);
cuenta.Saldo = 10000.00f;
cuenta.TipoInteres = "Variable";
Console.WriteLine("Cuenta Modificada");
Console.WriteLine("Nro Cuenta " + cuenta.NroCuenta + Environment.NewLine
                   + "Fecha de Apertura " + cuenta.FechaApertura + Environment.NewLine
                   + "Saldo " + cuenta.Saldo + Environment.NewLine
                   + "Tipo de Interes " + cuenta.TipoInteres);


Cuenta myCuenta = new Cuenta(2, 50000, new DateTime(2023, 8, 8), "Fija");
Console.WriteLine("Nro Cuenta " + myCuenta.NroCuenta + Environment.NewLine
                   + "Fecha de Apertura " + myCuenta.FechaApertura + Environment.NewLine
                   + "Saldo " + myCuenta.Saldo + Environment.NewLine
                   + "Tipo de Interes " + myCuenta.TipoInteres);

myCuenta.Depositar(50000);
Console.WriteLine("Su Saldo es " + myCuenta.Saldo);
myCuenta.Retiro(50000);
Console.WriteLine("Su Saldo es " + myCuenta.Saldo);

//tasa = myCuenta.CalcularTasa(myCuenta.TipoInteres);

CajaDeAhorro cajaAhorro = new CajaDeAhorro();

cajaAhorro.Saldo = 60000;
cajaAhorro.NroCuenta = 2;
cajaAhorro.FechaApertura = new DateTime(2023, 5, 5);
cajaAhorro.TipoInteres = "variable";
cajaAhorro.NroCuentaEspecial = "1234";

Console.WriteLine("Nro Cuenta " + cajaAhorro.NroCuenta + Environment.NewLine
                   + "Fecha de Apertura " + cajaAhorro.FechaApertura + Environment.NewLine
                   + "Saldo " + cajaAhorro.Saldo + Environment.NewLine
                   + "Tipo de Interes " + cajaAhorro.TipoInteres + Environment.NewLine
                   + "Nro Cuenta Special " + cajaAhorro.NroCuentaEspecial);


CuentaCorriente cuentaCorriente = new CuentaCorriente();

cuentaCorriente.Saldo = 60000;
cuentaCorriente.NroCuenta = 3;
cuentaCorriente.FechaApertura = new DateTime(2023, 5, 5);
cuentaCorriente.TipoInteres = "variable";
cuentaCorriente.NroCuentaEspecial = "1234";

Console.WriteLine("Nro Cuenta " + cuentaCorriente.NroCuenta + Environment.NewLine
                   + "Fecha de Apertura " + cuentaCorriente.FechaApertura + Environment.NewLine
                   + "Saldo " + cuentaCorriente.Saldo + Environment.NewLine
                   + "Tipo de Interes " + cuentaCorriente.TipoInteres + Environment.NewLine
                   + "Nro Cuenta Special " + cuentaCorriente.NroCuentaEspecial);


Console.ReadKey();