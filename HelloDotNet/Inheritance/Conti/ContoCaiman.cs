using System;
using System.Collections.Generic;
using System.Text;

namespace it.Finsa.HelloDotNetCore.Inheritance.Conti
{
    public  class ContoCaiman : Conto
    {
        public string CodiceSegreto { get; set; }
        private Random generatore;
        public override void Deposita(decimal importo)
        {
            
            if(generatore.Next()%2==0)
            {
                importo += 2;
                
            }

            saldo += importo;
        }

        public ContoCaiman(decimal importo, string codice, DateTime apertura, string codiceSegreto)
           : base(importo, codice, apertura)
        {
            this.generatore = new Random();
            this.CodiceSegreto = codiceSegreto;
        }


        public void EvadiTasse()
        {

        }
    }
}
