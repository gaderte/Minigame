using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Map
    {
        public int[,] maps;
        public Point exit;
        public Map(int x, int y)
        {
            maps = new int[x, y];
            exit = new Point(x - 1, y - 1);
            fillMap();
        }

        public void fillMap()
        {
            for(int i = 0; i < maps.GetLength(0); i++)
            {
                for(int j = 0; j < maps.GetLength(1); j++)
                {
                    maps[i, j] = 0;
                }
            }
        }
    }
}
