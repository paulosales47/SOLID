using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class Fatura
    {
        private double _valorMensal;
        private string _cliente;

        public double ValorMensal
        {
            get { return _valorMensal; }
        }
        
        public string Cliente
        {
            get { return _cliente; }
        }

        public Fatura(double valorMensal, string cliente)
        {
            _valorMensal = valorMensal;
            _cliente = cliente;
        }
    }
}
