using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class NotaFiscalDao: IAcaoNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Gravando a nota no banco de dados");
        }
    }
}
