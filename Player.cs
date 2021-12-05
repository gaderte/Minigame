using System.Windows;

namespace ConsoleApp1
{
    class Player
    {
        public string name;
        Inventaire i;
        Stats s;
        public Point pos;

        public Player(string n, Stats st)
        {
            name = n;
            i = new Inventaire();
            s = st;
            pos = new Point(0, 0);
        }
        public override string ToString()
        {
            return "Nom du perso : " + name + "\nInventaire : " + i + "\nStats : " + s;
        }
    }
}
