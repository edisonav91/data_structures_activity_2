using DataStructuresActivity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Kite : Rhombus
    {
        private decimal _b;

        public Kite(string name, decimal a, decimal d1, decimal d2, decimal b) : base(name, a, d1, d2)
        {
            B = ValidarLado(b);
        }

        public decimal B { get => _b; set => _b = ValidarLado(value); }

        public override decimal GetPerimeter() => 2 * (A + B);
        public override decimal GetArea() => (D1 * D2) / 2;
    }
}