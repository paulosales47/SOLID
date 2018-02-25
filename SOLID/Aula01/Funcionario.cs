using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public class Funcionario
    {
        private Cargo _cargo;
        private double _salarioBase;

        public Funcionario(Cargo cargo, double salarioBase)
        {
            _cargo = cargo;
            _salarioBase = salarioBase;
        }

        public Cargo Cargo
        {
            get { return _cargo; }
        }
        
        public double SalarioBase
        {
            get { return _salarioBase; }
        }
        
        public double CalculaDescontoSalario()
        {
            return Cargo.Desconto.CalculaDesconto(this);
        }

    }
}
