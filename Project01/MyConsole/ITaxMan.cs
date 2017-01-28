using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public interface ITaxMan
    {
        void Visit(Person P);
        double GetIncomeTax();
    }
}
