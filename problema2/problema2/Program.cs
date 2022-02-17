using System;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avem triunghiul: ");
            triunghi t = new triunghi(
                p1: new Point(10, 10),
                p2: new Point(20, 20),
                p3: new Point(10, 30));


            Console.WriteLine("Avem dreprunghiul: ");
            dreptunghi d = new dreptunghi(
               topLeft: new Point(10, 10),
               width: 10,
               height: 5);


            Console.WriteLine("Avem patratul : ");
            patrat p = new patrat(
               topLeft: new Point(10, 10),
               width: 10
              );

            t.Print();
            d.Print();
            p.Print();

            Console.WriteLine("aria pentru  : ");
            Console.WriteLine(GeometryUtils.GetAria(t,d,p));
           

            Console.WriteLine("Facem move pentru triunghi , dreptungi si pentru patrat : ");
            GeometryUtils.Move(10, 10, t, d,p);
            t.Print();
            d.Print();
            p.Print();


            Console.WriteLine("Facem rotate pentru triunghi , dreptungi si pentru patrat : ");
            GeometryUtils.Rotate(50.89, t, d, p);
            t.Print();
            d.Print();
            p.Print();




        }
    }
}
