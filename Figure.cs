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

        public void Draw()
        {
            foreach(DotClass i in plist)
            {
                i.Draw();
            }
        }
    }
}