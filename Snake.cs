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
            DotClass dot = new DotClass(20, 4, '*');
            DotClass dot2 = new DotClass(4, 5, '#');

            dot.Draw();
            dot2.Draw();

            Console.ReadLine();
        }
    }
}