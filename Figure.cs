using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCS
{
    class Figure
    {
        public List<DotClass> plist;

        public virtual void Draw()
        {
            foreach(DotClass i in plist)
            {
                i.Draw();
            }
        }

        public bool IsHit(Figure fig)
        {
            foreach(var p in plist)
            {
                if(fig.IsHit(p)) return true;
            }
            return false;
        }

        private bool IsHit(DotClass dot)
        {
            foreach(var d in plist)
            {
                if(d.IsHit(dot)) return true;
            }
            return false;
        }
    }
}