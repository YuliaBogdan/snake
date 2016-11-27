using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontLine Upline = new HorizontLine(0, 78, 0, '+');
            HorizontLine Downline = new HorizontLine(0, 78, 24, '+');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            LeftLine.Drow();
            Rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}
