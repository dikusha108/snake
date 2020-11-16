using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class HLine : Figure
    {
        public HLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x=xLeft; x < xRight; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }

        
    }
}
