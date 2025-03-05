using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Rectangle : GeometricFigure
    {
        private decimal _a, _b;

        public Rectangle(decimal a, decimal b)
        {
            A = ValidateSide(a);
            B = ValidateSide(b);
        }

        public decimal A { get => _a; set => _a = ValidateSide(value); }
        public decimal B { get => _b; set => _b = ValidateSide(value); }

        public override decimal GetArea() => A * B;

        public override decimal GetPerimeter() => 2 * (A + B);

        private decimal ValidateSide(decimal side)
        {
            if (side <= 0)
                throw new ArgumentException($"Invalid side length: {side}");
            return side;
        }
    }
}
