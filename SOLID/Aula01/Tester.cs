using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Aula01
{
    public class Tester : Cargo
    {
        public Tester() : base(new QuinzeOuVinteCincoPorcento())
        {
        }
    }
}
