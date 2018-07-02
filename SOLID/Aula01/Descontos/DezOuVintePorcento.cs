using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public class DezOuVintePorcento : DescontoSalarioTemplate
    {
        protected override double MaiorDesconto(Funcionario funcionario)
        {
            return (funcionario.SalarioBase * 0.8);
        }

        protected override double MenorDesconto(Funcionario funcionario)
        {
            return (funcionario.SalarioBase * 0.9);
        }

        protected override bool VerificaMaiorTaxa(Funcionario funcionario)
        {
            return (funcionario.SalarioBase > 3000);
        }
    }
}
