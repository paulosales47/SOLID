using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula03
{
    public interface IDesconto
    {
        double Calcula(Compra compra);
    }
}
