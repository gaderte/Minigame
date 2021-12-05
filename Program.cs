using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            setPName(g);
            Console.WriteLine(g.p1);
            printMaps(g);

            //Démarrage du jeu
            while(true)
            {
                Console.WriteLine("En attente d'une touche...");
                ConsoleKeyInfo x = Console.ReadKey();
                g.movePlayer(x);
                Console.Clear();
                Console.WriteLine(g.p1);
                printMaps(g);
            }
        }

        static void setPName(Game g)
        {
            Console.WriteLine("Donnez le nom du perso : ");
            string s = Console.ReadLine();
            g.setPlayerName(s);
        }

        static void printMaps(Game g)
        {
            for(int i = 0; i < g.actMap.maps.GetLength(0); i++)
            {
                for(int j = 0; j < g.actMap.maps.GetLength(1); j++)
                {
                    if (i == g.p1.pos.Y && j == g.p1.pos.X)
                    {
                        Console.Write("[P] ");
                    } else if (i == g.actMap.exit.Y && j == g.actMap.exit.X) {
                        Console.Write("[E] ");
                    } else
                    {
                        Console.Write("[" + g.actMap.maps[i, j] + "] ");
                    }
                }
                Console.Write('\n');
            }
        }
    }
}
