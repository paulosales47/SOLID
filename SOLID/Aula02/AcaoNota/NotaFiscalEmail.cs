using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class NotaFiscalEmail: IAcaoNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando a nota fiscal por e-mail");
        }
    }
}
