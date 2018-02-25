using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public abstract class Cargo
    {
        public IDescontoSalario Desconto;

        protected Cargo(IDescontoSalario desconto)
        {
            Desconto = desconto;
        }
    }
}
