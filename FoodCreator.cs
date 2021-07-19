using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class FoodCreator
    {
        int X;
        int Y;
        char sym;
        public FoodCreator(int screenX, int screenY, char foodsym)
        {
            X = screenX;
            Y = screenY;
            sym = foodsym;
        }

        public DotClass CreateFood()
        {
            Random r = new Random();
            int xx = r.Next(2, X - 2);
            int yy = r.Next(2, Y - 2);
            DotClass dot = new DotClass(xx, yy, sym);
            return dot;
        }
    }
}