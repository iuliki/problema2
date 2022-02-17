using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
    public  class triunghi : Shape
    {
        public triunghi(Point p1, Point p2, Point p3)
        {
            this.P1 = p1 ?? new Point(0, 0);//verifica daca p1 exista, il compara cu new point ca sa vada cine e mai mare...
            this.P2 = p2 ?? new Point(0, 0); 
            this.P3 = p3 ?? new Point(0, 0);
  
        }

        public Point P1 { get; }
        public Point P2 { get; }
        public Point P3 { get; }


       public override double Aria
        {
            get
            {
                double aria=Math.Abs(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y)) / 2;
                return Math.Round(aria, 2);
            
            }
        }

        public override Point[] Points
        {
            get
            {
                return new Point[] { this.P1, this.P2, this.P3 };
            }
        }

        public override void Move(double dx, double dy)
        {
            P1.MoveThePoint(dx, dy);

            P2.MoveThePoint(dx, dy);

            P3.MoveThePoint(dx, dy);
        }

        public override void Print()
        {
            Console.WriteLine("Un triunghi cu urmatoarele coordonate:");
            Console.WriteLine($"    - P1: (x = {P1.X}, y={P1.Y})");
            Console.WriteLine($"    - P2: (x = {P2.X}, y={P2.Y})");
            Console.WriteLine($"    - P3: (x = {P3.X}, y={P3.Y})");
        }


    }
}
