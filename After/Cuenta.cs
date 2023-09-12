using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    public class Cuenta
    {
        public Cuenta()
        {
            this._nroCuenta = 0;
            this.Saldo = 0;
            this.FechaApertura = DateTime.Now;
            this.TipoInteres = String.Empty;
        }
        public Cuenta(int nroCuenta, float saldo, DateTime fechaApertura, string tipoInteres)
        {
            this._nroCuenta = nroCuenta;
            this.Saldo = saldo;
            this.FechaApertura = fechaApertura;
            this.TipoInteres = tipoInteres;
        }
        protected string _nroCuentaEspecial;
        private int _nroCuenta;
        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }
        public DateTime FechaApertura { get; set; }
        public float Saldo { get; set; }
        public string TipoInteres { get; set; }
        public Cliente Cliente { get; set; }
        public void Depositar(float importeDeposito)
        {
            this.Saldo += importeDeposito;
        }
        public void Retiro(float importeRetiro)
        {
            this.Saldo -= importeRetiro;
        }
        public float CalcularTasa(string tipoInteres)
        {
            if (TipoInteres == "Variable")
            {
                return 5;
            }
            else
            {
                return 10;
            }

        }
        //public string Tipo { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public double DNI { get; set; }

    }
}
