using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stats
    {
        int force;
        int hp;
        int vitesse;
        int cc;

        public Stats(int f, int h, int v, int c)
        {
            force = f;
            hp = h;
            vitesse = v;
            cc = c;
        }

        public override string ToString()
        {
            return "for : " + force + " / hp : " + hp + " / vit : " + vitesse + " / cc : " + cc; ;
        }
    }
}
