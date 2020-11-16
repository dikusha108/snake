using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Figure
    {

         protected List<Point> pList;

        public void Draw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }

        internal bool IsHit (Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p)) return true;
            }
            return false;
        } 

        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }

    }
}
