using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula04
{
    class Cartao : FormaPagamento
    {
        
        public Cartao(double valor) : base(valor * 0.95)
        {
        }
    }
}
