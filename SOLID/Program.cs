
using SOLID.Aula01;
using SOLID.Aula04;
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
            //var funcionario = new Funcionario(new Dba(), 8000);
            //var funcionario2 = new Funcionario(new Desenvolvedor(), 5000);

            //var calculadora = new CalculadoraSalario();

            //Console.WriteLine(calculadora.Calcula(funcionario));
            //Console.WriteLine(calculadora.Calcula(funcionario2));

            #endregion Aula 1

            #region Aula 4

            //var processador = new ProcessaPadrao();
            //var listaFormaPagamento = new List<FormaPagamento>();
            //var fatura = new Fatura("Cliente A", 4250);

            //for(int i = 0; i < 5; i++)
            //{
            //    var random = new Random();
            //    listaFormaPagamento.Add(new Boleto(random.Next(0, 100)));
            //    listaFormaPagamento.Add(new Cartao(random.Next(0, 1000)));
            //}

            //processador.Processa(listaFormaPagamento, fatura);
            //Console.WriteLine(fatura.Pago);

            #endregion Aula 4


            Console.ReadKey();
        }
    }
}
