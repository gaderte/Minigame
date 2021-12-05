using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Game
    {
        Map m1, m2, m3, m4;
        public Player p1;
        Item i1, i2, i3, i4, i5, i6;
        List<Item> listeItems;
        public Map actMap;

        public Game()
        {
            //Création Map
            createMap();
            //Création Joueur
            createJoueur();
            //Création Items
            listeItems = new List<Item>();
            createItem();
            actMap = m1;
        }
        public void createMap()
        {
            m1 = new Map(5, 5);
            m2 = new Map(8, 8);
            m3 = new Map(10, 10);
            m4 = new Map(12, 12);
        }
        public void createJoueur()
        {
            p1 = new Player("", new Stats(10, 100, 5, 0));
        }
        public void createItem()
        {
            i1 = new Item("Epee en bois", new Stats(1, 10, 0, 10));
            listeItems.Add(i1);
            i2 = new Item("Epee normale", new Stats(2, 20, 3, 15));
            listeItems.Add(i2);
            i3 = new Item("Epee en fer", new Stats(3, 30, 6, 20));
            listeItems.Add(i3);
            i4 = new Item("Epee en platine", new Stats(4, 40, 9, 25));
            listeItems.Add(i4);
            i5 = new Item("Epee diamant", new Stats(5, 50, 12, 30));
            listeItems.Add(i5);
            i6 = new Item("Epee en Adamontium", new Stats(10, 100, 20, 50));
            listeItems.Add(i6);
        }

        public void setPlayerName(string name)
        {
            p1.name = name;
        }

        public void movePlayer(ConsoleKeyInfo x)
        {
            switch (x.KeyChar)
            {
                case 'z':
                    moveUp();
                    break;

                case 'q':
                    moveLeft();
                    break;

                case 's':
                    moveDown();
                    break;

                case 'd':
                    moveRight();
                    break;

                default:
                    break;
            }
        }

        bool canMove(double x, double y)
        {
            if(0 <= x && x < actMap.maps.GetLength(1) && 0 <= y && y < actMap.maps.GetLength(0))
            {
                Console.WriteLine("Le joueur peut se déplacer");
                return true;
            }
            Console.WriteLine("Le joueur ne peut pas se déplacer");
            return false;            
        }

        public void moveUp()
        {
            if(canMove(p1.pos.X, p1.pos.Y - 1))
            {
                p1.pos.Y -= 1;
            }
        }
        public void moveDown()
        {
            if(canMove(p1.pos.X, p1.pos.Y + 1))
            {
                p1.pos.Y += 1;
            }
        }
        public void moveLeft()
        {
            if(canMove(p1.pos.X - 1, p1.pos.Y))
            {
                p1.pos.X -= 1;
            }
        }
        public void moveRight()
        {
            if(canMove(p1.pos.X + 1, p1.pos.Y))
            {
                p1.pos.X += 1;
            }
        }
    }
}
