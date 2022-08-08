using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Capital
{
    internal class Potion
    {
        public string Name;
        public int Value, Cost;

        public Potion(string Name, int Value, int Cost)
        {
            this.Name = Name;
            this.Value = Value;
            this.Cost = Cost;
        }

    }
}
