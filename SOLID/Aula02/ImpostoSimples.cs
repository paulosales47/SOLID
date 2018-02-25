using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class ImpostoSimples : IImposto
    {
        public double Calcula(Fatura fatura)
        {
            return (fatura.ValorMensal * 0.06);
        }
    }
}
