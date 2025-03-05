using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Triangle : GeometricFigure
    {
        private decimal _a, _b, _c, _h;

        public Triangle(decimal a, decimal b, decimal c, decimal h)
        {
            A = ValidateSide(a);
            B = ValidateSide(b);
            C = ValidateSide(c);
            H = ValidateSide(h);
        }

        public decimal A { get => _a; set => _a = ValidateSide(value); }
        public decimal B { get => _b; set => _b = ValidateSide(value); }
        public decimal C { get => _c; set => _c = ValidateSide(value); }
        public decimal H { get => _h; set => _h = ValidateSide(value); }

        public override decimal GetArea() => (B * H) / 2;

        public override decimal GetPerimeter() => A + B + C;

        private decimal ValidateSide(decimal side)
        {
            if (side <= 0)
                throw new ArgumentException($"Invalid side length: {side}");
            return side;
        }
    }
}