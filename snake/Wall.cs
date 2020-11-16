using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Wall
    {

        List<Figure> wallList;

        public Wall (int mapWidth, int mapHeidht)
        {
            wallList = new List<Figure>();

            HLine upline = new HLine(0, mapWidth-1, 0, '+');
            HLine downline = new HLine(0, mapWidth-1, mapHeidht-1, '+');
            VLine leftline = new VLine(0, mapHeidht - 1, 0, '+');
            VLine rightline = new VLine(0, mapHeidht - 1, mapWidth-1, '+');

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsHit (Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }

        public void Draw ()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }


        public void makeWalls (List<Figure> newWalls)
        {
            foreach (var wall in newWalls)
            {
                this.wallList.Add(wall);
            }
        }

    }
}
