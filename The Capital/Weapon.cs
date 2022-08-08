using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_Capital
{
    public class Weapon
    {
        public string Name;
        public int Value, Cost;

        public Weapon(string Name, int Value, int Cost)
        {
            this.Name = Name;
            this.Value = Value;
            this.Cost = Cost;
        }

    }
}
