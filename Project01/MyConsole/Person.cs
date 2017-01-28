using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Person
    {
        private string name;
        private double taxableIncome;

        public string Name { get { return name; } }
        public double TaxableIncome { get { return taxableIncome; } }

        private Person()
        {
            name = "No Name";
            taxableIncome = 0.0;
        }
        public Person(string Name, double TaxableIncome)
        {
            name = Name;
            taxableIncome = TaxableIncome;
        }

        public override string ToString()
        {
            return string.Concat(name,": ",Convert.ToString(taxableIncome));
        }
    }
}
