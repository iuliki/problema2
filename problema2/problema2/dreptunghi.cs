using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
   public class dreptunghi : Shape
    {
        public dreptunghi(Point topLeft, int width, int height)
        {
            topLeft ??= new Point(0, 0);

            
            TopLeft = topLeft;

            TopRight = new Point(topLeft.X + width, topLeft.Y);
            BottomRight = new Point(topLeft.X + width, topLeft.Y + height);
            BottomLeft = new Point(topLeft.X, topLeft.Y + height);

            Width = width;
            Height = height;
        }
        public Point TopLeft { get; }

        public Point TopRight { get; }

        public Point BottomRight { get; }

        public Point BottomLeft { get; }

        public int Width { get; }

        public int Height { get; }

        public override double Aria
        {
            get
            {
                return Width * Height;
            }
        }

        public override Point[] Points
        {
            get
            {
                return new Point[] {
                    TopLeft,
                    TopRight,
                    BottomRight,
                    BottomLeft
                };
            }
        }

        public override void Move(double dx, double dy)
        {
            TopLeft.MoveThePoint(dx, dy);
            TopRight.MoveThePoint(dx, dy);
            BottomRight.MoveThePoint(dx, dy);
            BottomLeft.MoveThePoint(dx, dy);
        }

        //luat din clasa
        public override void Print()
        {
            Console.WriteLine("Un dreptunghi cu urmatoarele coordonate:");
            Console.WriteLine($"    - TopLeft: (x = {TopLeft.X}, y={TopLeft.Y})");
            Console.WriteLine($"    - TopRight: (x = {TopRight.X}, y={TopRight.Y})");
            Console.WriteLine($"    - BottomRight: (x = {BottomRight.X}, y={BottomRight.Y})");
            Console.WriteLine($"    - BottomRight: (x = {BottomLeft.X}, y={BottomLeft.Y})");
            Console.WriteLine($"    - Width: {Width}");
            Console.WriteLine($"    - Height: {Height}");

        }
    }
}
