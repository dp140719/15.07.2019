using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Circle : IProtoType<Circle>
    {

        public Point Center { get; set; }

        public double Area { get; set;  }

        public Circle(Point center, double area)
        {
            this.Center = center;
            this.Area = area;
        }

        public override string ToString()
        {
            return $"Circle center {Center} area = {Area}";
        }

        public Circle clone()
        {
            return new Circle(Center.clone(), Area);
        }
    }
}
