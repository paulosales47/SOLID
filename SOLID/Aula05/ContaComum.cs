using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula05
{
    public class ContaComum
    {
        public double Saldo { get; private set; }
        private ManipuladorConta manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorConta();
        }

        public virtual void Deposita(double valor)
        {
            this.manipulador.Deposita(valor);
        }

        public void Saca(double valor)
        {
            this.manipulador.Saca(valor);
        }

        public void somaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }

    }
}
