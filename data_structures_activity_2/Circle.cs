using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Circle : GeometricFigure
    {
        private decimal _r;

        public Circle(decimal r)
        {
            R = ValidateR(r);
        }

        public decimal R { get => _r; set => _r = ValidateR(value); }

        public override decimal GetArea() => (decimal)Math.PI * R * R;

        public override decimal GetPerimeter() => 2 * (decimal)Math.PI * R;

        private decimal ValidateR(decimal r)
        {
            if (r <= 0)
                throw new ArgumentException($"Invalid radius: {r}");
            return r;
        }
    }
    
}
