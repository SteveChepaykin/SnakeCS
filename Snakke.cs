using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class Snakke: Figure
    {
        Direction dir;

        public Snakke(DotClass tail, int len, Direction _dir)
        {
            dir = _dir;
            plist = new List<DotClass>();
            for(int i = 0; i <= len; i++)
            {
                DotClass dot = new DotClass(tail);
                dot.Move(i, _dir);
                plist.Add(dot);
            }
        }

        internal void Move()
        {
            DotClass tail = plist.First();
            plist.Remove(tail);
            DotClass head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }

        public DotClass GetNextPoint()
        {
            DotClass head = plist.Last();
            DotClass nextPoint = new DotClass(head);
            nextPoint.Move(1, dir);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if(key == ConsoleKey.LeftArrow) dir = Direction.LEFT;
            else if(key == ConsoleKey.RightArrow) dir = Direction.RIGHT;
            else if(key == ConsoleKey.UpArrow) dir = Direction.UP;
            else if(key == ConsoleKey.DownArrow) dir = Direction.DOWN;
        }

        internal bool Eat(DotClass food)
        {
            DotClass head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else return false;
        }

        public bool IsHitTail()
        {
            var head = plist.Last();
            for(int i = 0; i <= plist.Count - 2; i++)
            {
                if(head.IsHit(plist[i])) return true;
            }
            return false;
        }
    }
}