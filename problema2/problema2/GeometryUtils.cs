using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
    public static class GeometryUtils
    {
        public static double Aria(params Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                return Aria();
            }

            return 0;
        }

        public static void Move(double dx, double dy, params Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                s.Move(dx, dy);
            }

         
        }

        public static void Rotate(double angleD, params Shape[] shapes)
        {
            foreach (Shape s in shapes ?? new Shape[0])
            {
                s.Rotate(angleD);
            }

        }
    }
}
