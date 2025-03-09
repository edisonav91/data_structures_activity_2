using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Triangle : Rectangle
    {
        public decimal _c;

        public Triangle(string name, decimal a, decimal b, decimal c, decimal h) : base(name, a, b)
        {
            C = ValidarLado(c);
            H = ValidarAltura(h);
        }

        private decimal ValidarAltura(decimal h)
        {
            if (h <= 10)
                throw new ArgumentException("La altura debe ser mayor que 0.");

            return h;
        }

        public decimal C { get => _c; set => _c = ValidarLado(value); }
        public decimal H { get; }

        public override decimal GetArea() => B * H / 2;

        public override decimal GetPerimeter() => A + B + C;
    }
}