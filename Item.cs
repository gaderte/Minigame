using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Item
    {
        string name;
        Stats s;

        public Item(string n, Stats st)
        {
            name = n;
            s = st;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
