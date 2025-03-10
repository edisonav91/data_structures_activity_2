using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Rectangle : Square
    {
        private decimal _b;

        public Rectangle(string name, decimal a, decimal b) : base(name, a)
        {
            B = ValidarLado(b); 
        }

        public decimal B { get => _b; set => _b = ValidarLado(value); }

        public override decimal GetArea() => A * B;

        public override decimal GetPerimeter() => 2 * (A + B);
    }
}