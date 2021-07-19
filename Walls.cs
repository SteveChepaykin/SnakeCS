using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class Walls
    {
        List<Figure> walllist;
        //Random ran = new Random();

        public Walls(int _x, int _y)
        {
            walllist = new List<Figure>();

            Line upLine = new Line(0, _x, 0, '+', true);
            Line downLine = new Line(0, _x, _y - 1, '+', true);
            Line leftLine = new Line(1, _y - 1, 0, '+', false);
            Line rightLine = new Line(1, _y - 1, _x - 1, '+', false);
            walllist.Add(upLine);
            walllist.Add(downLine);
            walllist.Add(leftLine);
            walllist.Add(rightLine);
        }

        internal bool IsHit(Figure fig)
        {
            foreach(var wall in walllist)
            {
                if(wall.IsHit(fig)) return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach(var wall in walllist)
            {
                wall.Draw();
            }
        }



        // public override void Draw()
        // {
        //     for(int i = 0; i >= amount; i++)
        //     {
        //         int b = ran.Next(1, 3);
        //         if(b == 1)
        //         {
        //             Line l = new Line(ran.Next(3, 5), ran.Next(4, 10), ran.Next(0, 25),  '#', true);
        //             l.Draw();
        //         }
        //         else if(b == 2)
        //         {
        //             Line l = new Line(ran.Next(3, 5), ran.Next(4, 10), ran.Next(0, 80),  '#', false);
        //             l.Draw(); 
        //         }
        //     }
        //     base.Draw();
    }
}