using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula04
{
    public abstract class FormaPagamento
    {
        protected double _valor;

        public double Valor { get { return _valor; } }

        protected FormaPagamento(double valor)
        {
            _valor = valor;
        }
    }
}
