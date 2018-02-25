using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public class CalculadoraSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaDescontoSalario();
        }
    }
}
