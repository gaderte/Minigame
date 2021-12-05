using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inventaire
    {
        Item[] inventaire;
        
        public Inventaire()
        {
            inventaire = new Item[10];
        }

        public override string ToString()
        {
            string temp = "";
            for(int i = 0; i < inventaire.Length; i++)
            {
                if(inventaire[i] == null)
                {
                    temp += "[X]";
                } else
                {
                    temp += "[" + inventaire[i] + "]";
                }
            }
            return temp;
        }
    }
}
