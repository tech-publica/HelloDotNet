using System;

namespace it.Finsa.HelloDotNetCore.Inheritance.Conti
{
    public class SaldoInsufficienteException : Exception
    {

        public decimal Saldo { get; private set; }
        public decimal Importo { get; private set; }

        public SaldoInsufficienteException(string message, decimal saldo, decimal importo) : base(message)
        {
            //this.Message = message;
            this.Saldo = saldo;
            this.Importo = importo;
        }
    }
}