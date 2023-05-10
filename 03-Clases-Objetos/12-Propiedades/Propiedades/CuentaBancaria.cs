namespace Propiedades
{
    public class CuentaBancaria
    {
        //Auto properties (propiedades automáticas)
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        //backing field
        private decimal _saldo;

        //Full property (propiedad completa)
        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                //evitar que el saldo sea negativo
                /*if (value < 0)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }*/
                _saldo = value < 0 ? 0 : value;
            }
        }

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
    }
}