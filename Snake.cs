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
            DotClass dot = new DotClass();
            dot.x = 20;
            dot.y = 4;
            dot.sym = '*';
            DotClass dot2 = new DotClass();
            dot2.x = 4;
            dot2.y = 5;
            dot2.sym = '#';

            dot.Draw();
            dot2.Draw();

            Console.ReadLine();
        }
    }
}