using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SnakeCS
{
    class Something
    {
        static void Main(string[] args)
        {
            DotClass dot = new DotClass(20, 4, '*');

            Snakke snake = new Snakke(dot, 6, Direction.RIGHT);
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Draw();
            }
        }
    }
}