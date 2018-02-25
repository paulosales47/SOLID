using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula03
{
    public class DescontoPadrao : IDesconto
    {
        public double Calcula(Compra compra)
        {
            double valor = compra.Valor;

            if (valor > 5000) return (0.03 * valor);
            if (valor > 1000) return (0.05 * valor);
            return 0;
        }
    }
}
