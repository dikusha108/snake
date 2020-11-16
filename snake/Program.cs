using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            Wall walls = new Wall(120, 30);
            walls.Draw();
        
            Point p = new Point(50, 10, '*');
            Snake snake = new Snake(p, 4, Direction.left);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(120, 30, 'o');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }


                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                    snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(400);
                snake.Move();
            }
         
        }

        

    }
}
