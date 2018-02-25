using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula04
{
    public class ProcessaPadrao
    { 
        public void Processa(IList<FormaPagamento> listaFormaPagamento, Fatura fatura)
        {
            foreach(var pag in listaFormaPagamento)
            {
                Pagamento pagamento = new Pagamento(pag.Valor);
                fatura.AdicionaPagamento(pagamento);
            }
        }
    }
}
