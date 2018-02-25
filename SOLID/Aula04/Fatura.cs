using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula04
{
    public class Fatura
    {
        private IList<Pagamento> _listaPagamento;
        private string _nomeCliente;
        private double _valor;
        private bool _pago;
        
        public string NomeCliente
        {
            get { return _nomeCliente; }
        }

        public double Valor
        {
            get { return _valor; }
        }

        public bool Pago
        {
            get { return _pago; }
        }

        public Fatura(string nomeCliente, double valor)
        {
            _nomeCliente = nomeCliente;
            _valor = valor;
            _listaPagamento = new List<Pagamento>();
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            _listaPagamento.Add(pagamento);
            VerificaPagamento();
        }

        private void VerificaPagamento()
        {
            double total = 0;

            foreach (var pagamento in _listaPagamento)
            {
                total += pagamento.Valor;

                if(_valor <= total)
                {
                    _pago = true;
                    break;
                }
            }
        }
    }
}
