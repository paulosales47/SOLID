using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula04
{
    public class Boleto : FormaPagamento
    {
        public Boleto(double valor) : base(valor)
        {
        }
    }
}
