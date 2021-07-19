using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class Line : Figure
    {
        public Line(int xx, int yy, int zz, char sym, bool hor)
        {
            plist = new List<DotClass>();
            if(hor)
            {
                for(int x = xx; x <= yy; x++)
                {
                    DotClass dot = new DotClass(x, zz, sym);
                    plist.Add(dot);
                } 
            } 
            else 
            {
                for(int y = xx; y <= yy; y++)
                {
                    DotClass dot = new DotClass(zz, y, sym);
                    plist.Add(dot);
                }
            } 
        }
    }
}