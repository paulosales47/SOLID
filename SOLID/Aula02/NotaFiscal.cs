using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula02
{
    public class NotaFiscal
    {
        private double _valorBruto;
        private double _impostos;
        
        public double ValorBruto
        {
            get { return _valorBruto; }
        }
        
        public double Impostos
        {
            get { return _impostos; }
        }
        
        public double ValorLiquido
        {
            get { return _valorBruto - _impostos; }
        }

        public NotaFiscal(double valorBruto, double Impostos)
        {
            _valorBruto = valorBruto;
            _impostos = Impostos;
        }
        
    }
}
