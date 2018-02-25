using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula05
{
    public class ContaEstudante
    {
        private ManipuladorConta m;
        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            m = new ManipuladorConta();
        }
        public void Deposita(double valor)
        {
            m.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
