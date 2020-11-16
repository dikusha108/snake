using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i<length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move ()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }


        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
                direction = Direction.left;
            else if (key.Key == ConsoleKey.RightArrow)
                direction = Direction.right;
            if (key.Key == ConsoleKey.UpArrow)
                direction = Direction.up;
            if (key.Key == ConsoleKey.DownArrow)
                direction = Direction.down;
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else return false;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i=0; i< pList.Count-2; i++)
            {
                if (head.IsHit(pList[i])) return true;
            }
            return false;
        }

    }
}
