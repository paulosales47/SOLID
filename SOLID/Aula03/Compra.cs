using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula03
{
    public class Compra
    {
        private string _cidade;
        private double _valor;

        public Compra(string cidade, double valor)
        {
            _cidade = cidade;
            _valor = valor;
        }

        public string Cidade
        {
            get { return _cidade; }
        }
        
        public double Valor
        {
            get { return _valor; }
        }
    }
}
