using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class Snake
    {
        static void Main(string[] args)
        {
            int x1 = 20;
            int y1 = 4;

            int x2 = 4;
            int y2 = 5;

            char sym1 = '*';
            char sym2 = '#';

            Draw(x1, y1, sym1);
            Draw(x2, y2, sym2);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}