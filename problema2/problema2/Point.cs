using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
    public  class Point
    {   
       
        public  Point( double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; private set; } = 0;
        public double Y { get; private set; } = 0;

        public void MoveThePoint(double dx, double dy)
        {
            X = X + dx;
            Y = Y + dy;
        }

        public void RotateAngle(double angleD)
        {
            /*noul X = X*cos(theta) - Y*sin(theta)
            -- noul Y = X*sin(theta) + Y*cos(theta)
            - daca doriti, puteti specifica unghiul theta si in grade, acesta putand fi convertit in radiani conform formulei urmatoare:
            -- theta(radiani) = (PI / 180) * theta(grade)
            */
            double angleR = (Math.PI / 180) * angleD;
            
            double firstX = this.X;
            double fistY = this.Y;

            this.X = (firstX * Math.Cos(angleR) - fistY * Math.Sin(angleR));
            this.Y = (firstX * Math.Sin(angleR) + fistY * Math.Cos(angleR));


             
        }

     
    }

   
}
