using System;
using System.Collections.Generic;
using System.Text;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.sym);
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x +=  dx;
            p.y += dy;
        }

        public void Move(int offset, Direction d)
        {
            if (d == Direction.right)
                x += offset;
            else if (d == Direction.left)
                x -= offset;
            else if (d == Direction.up)
                y -= offset;
            else if (d == Direction.down)
                y += offset;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public bool IsHit (Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
