using DataStructuresActivity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Square : GeometricFigure
    {
        private decimal _a;

        public Square(string name, decimal a) : base(name)
        {
            A = ValidarLado(a);
        }

        public decimal A { get => _a; set => _a = ValidarLado(value); }

        public override decimal GetArea() => A * A;

        public override decimal GetPerimeter() => 4 * A;

        protected decimal ValidarLado(decimal lado)
        {
            if (lado <= 0)
                throw new ArgumentException($"El lado no es válido: {lado}. Debe ser mayor que 0.");
            return lado;
        }
    }
}