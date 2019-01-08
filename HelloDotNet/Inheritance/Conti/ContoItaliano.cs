using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Inheritance.Conti
{
    public class ContoItaliano : Conto
    {
        protected DateTime onomastico;

        public ContoItaliano(decimal saldo, string codice, DateTime apertura, DateTime onomastico)
            : base(saldo, codice, apertura)
        {
            this.onomastico = onomastico;
        }

        public override void Deposita(decimal importo)
        {
            if (3 > 2)
            {
                //base.Deposita(importo);
                return;
            }
            saldo += importo*0.99m;
     
        }

        public DateTime Onomastico
        {
            get
            {
                return onomastico;
            }
        }

        //public ContoItaliano(decimal importo, string codice, DateTime apertura,
        //    DateTime onomastico) : base()
        //{
        //    saldo = importo;
        //    this.codice = codice;
        //    this.apertura = apertura;
        //    this.onomastico = onomastico;
        //}
    }
}
