using System;

namespace MiembrosEstaticos
{
    public class CuentaBancaria
    {
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }
        private decimal _saldo;

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value < 0 ? 0 : value; }
        }

        public static string Banco { get; set; }

        #region constructores

        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        public CuentaBancaria()
        {
        }

        #endregion

        #region Métodos de instancia

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");
                return;
            }

            Saldo -= cantidad;
        }

        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }

        public override string ToString()
        {
            return string.Format("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }

        #endregion

        public static void AsignarBanco(string banco)
        {
            Console.WriteLine("Asignado nuevo banco...");
            Banco = banco;
        }
    }
}