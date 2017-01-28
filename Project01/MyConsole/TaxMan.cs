using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TaxMan : ITaxMan
    {
        private Person person;
        public double GetIncomeTax()
        {
            throw new NotImplementedException();
        }

        public void Visit(Person P)
        {
            person = P;
        }
    }
}
