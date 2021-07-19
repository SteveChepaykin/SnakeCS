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
            //Console.SetBufferSize(80, 25);

            DotClass dot = new DotClass(20, 4, '*');
            Snakke snake = new Snakke(dot, 6, Direction.RIGHT);
            snake.Draw();

            FoodCreator fc = new FoodCreator(80, 25, '$');
            DotClass food = fc.CreateFood();
            food.Draw();

            Walls walls = new Walls(80, 25);
            walls.Draw();

            while(true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    break;
                }
                if(snake.Eat(food))
                {
                    food = fc.CreateFood();
                    food.Draw();
                }
                else snake.Move();

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}