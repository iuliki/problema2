using System;
using System.Collections.Generic;
using System.Text;

namespace problema2
{
    public static class HelpPoint
    {
       
        public static void  translate(Point A, int dx,int dy)
        { 
            A.x = A.x + dx;
            A.y = A.x + dy;
            

        }

        public static void rotate(Point B,int unghi)
        {
            B.x = B.x * Math.Cos(unghi)- B.y*Math.Sin(unghi);
            B.y = B.x * Math.Sin(unghi) +B.y * Math.Cos(unghi);
        }
        
    }
}
