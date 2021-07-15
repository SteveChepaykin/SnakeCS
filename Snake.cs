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
            int y1 = 10;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);

            Console.ReadLine();
        }
    }
}