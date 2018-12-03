using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Inheritance.Conti
{
    public abstract class Conto
    {
        protected decimal saldo;
        protected string codice;
        protected DateTime apertura;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }

        public Conto()
        { }

        public Conto(decimal importo)
        {
            saldo = importo;
        }

        public Conto(decimal importo, string codice) : this(importo)
        {
            this.codice = codice;
        }

        public Conto(decimal importo, string codice, DateTime apertura) : this(importo, codice)
        {
            this.apertura = apertura;
        }

        //public Conto(decimal importo) : this(importo, null)
        //{

        //}

        //public Conto(decimal importo, string codice) : this(importo, codice, DateTime.Now)
        //{

        //}

        //public Conto(decimal importo, string codice, DateTime apertura)
        //{
        //    this.apertura = apertura;
        //    this.codice = codice;
        //    saldo = importo;
        //}

        public abstract void Deposita(decimal importo);
      

        public void Ritira(decimal importo)
        {
            saldo -= importo;
        }

        public void Bonifica (decimal importo, Conto destinatario)
        {
            this.Ritira(importo);
            destinatario.Deposita(importo);
        }

    }
}
