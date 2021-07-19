using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class DotClass
    {
        public int x;
        public int y;
        public char sym; 

        public DotClass(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public DotClass(DotClass dot)
        {
            x = dot.x;
            y = dot.y;
            sym = dot.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction dir)
        {
            if(dir == Direction.RIGHT) x += offset;
            else if(dir == Direction.LEFT) x -= offset;
            else if(dir == Direction.UP) y -= offset;
            else if(dir == Direction.DOWN) y += offset;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}