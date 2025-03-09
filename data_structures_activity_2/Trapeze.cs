using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Trapeze : Triangle
    {
        private decimal _d;

        public Trapeze(string name, decimal a, decimal b, decimal c, decimal d, decimal h) : base(name, a, b, c, h)
        {
            D = ValidarLado(d);
        }

        public decimal D { get => _d; set => _d = ValidarLado(value); }

        public override decimal GetArea() => (B + D) * H / 2;
        public override decimal GetPerimeter() => A + B + C + D;
    }
}
