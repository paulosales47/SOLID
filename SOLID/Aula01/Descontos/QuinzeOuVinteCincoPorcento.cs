using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public class QuinzeOuVinteCincoPorcento : DescontoSalarioTemplate
    {
        protected override double MaiorDesconto(Funcionario funcionario)
        {
            return (funcionario.SalarioBase * 0.75);
        }

        protected override double MenorDesconto(Funcionario funcionario)
        {
            return (funcionario.SalarioBase * 0.85);
        }

        protected override bool VerificaMaiorTaxa(Funcionario funcionario)
        {
            return (funcionario.SalarioBase > 2000);
        }
    }
}
