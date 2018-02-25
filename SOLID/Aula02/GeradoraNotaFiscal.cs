using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class GeradoraNotaFiscal
    {
        private IList<IAcaoNota> _listaAcaoNota;

        public GeradoraNotaFiscal(IList<IAcaoNota> listaAcaoNota)
        {
            _listaAcaoNota = listaAcaoNota;
        }

        public NotaFiscal Gera(Fatura fatura, IImposto imposto)
        {
            double valor = fatura.ValorMensal;
            double valorImposto = imposto.Calcula(fatura);

            var notaFiscal = new NotaFiscal(valor, valorImposto);

            ExecutaAcaoNota(notaFiscal);

            return notaFiscal;
        }

        public void ExecutaAcaoNota(NotaFiscal notaFiscal)
        {
            foreach(var acao in _listaAcaoNota)
            {
                acao.Executa(notaFiscal);
            }
        }



    }
}
