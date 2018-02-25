using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula03
{
    public class CalculadorPreco
    {
        private IFrete _frete;
        private IDesconto _desconto;

        public CalculadorPreco(IFrete frete, IDesconto desconto)
        {
            _frete = frete;
            _desconto = desconto;
        }

        public double Calcula(Compra compra)
        {
            double desconto = _desconto.Calcula(compra);
            double frete = _frete.ValorFrete(compra);

            double novoPreco = (compra.Valor - desconto) + frete;

            return novoPreco;
        }
    }
}
