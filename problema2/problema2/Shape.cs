using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
    public abstract class Shape
    {
       public abstract Point[] Points
        {
            get;
        }

        public abstract double Aria
        {
            get;
        }

        public virtual void Move(double dx, double dy)
        {
            foreach (Point p in Points)
            {
                p.MoveThePoint(dx, dy);
            }
        }

        public virtual void Rotate(double angleD)
        {
            foreach (Point p in Points)
            {
                p.RotateAngle(angleD);
            }
                
         }

        public abstract void Print();
       
    }
}
