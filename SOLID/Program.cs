using SOLID.Aula01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula 1
            var funcionario = new Funcionario(new Dba(), 8000);
            var funcionario2 = new Funcionario(new Desenvolvedor(), 5000);

            var calculadora = new CalculadoraSalario();

            Console.WriteLine(calculadora.Calcula(funcionario));
            Console.WriteLine(calculadora.Calcula(funcionario2));

            #endregion Aula 1

            Console.ReadKey();
        }
    }
}
