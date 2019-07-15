using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(5, 5), 50.5);

            Console.WriteLine(c);

            DoStuffWithCircle(c.clone());

            Console.WriteLine(c);
        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }
    }
}
