using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public abstract class DescontoSalarioTemplate : IDescontoSalario
    {
        public double CalculaDesconto(Funcionario funcionario)
        {
            if (VerificaMaiorTaxa(funcionario))
            {
                return MaiorDesconto(funcionario);
            }

            return MenorDesconto(funcionario);
        }

        protected abstract bool VerificaMaiorTaxa(Funcionario funcionario);

        protected abstract double MaiorDesconto(Funcionario funcionario);

        protected abstract double MenorDesconto(Funcionario funcionario);

    }
}
