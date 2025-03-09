using DataStructuresActivity_2;
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

        public Circle(string name, decimal r) : base(name)
        {
            R = ValidarRadio(r);
        }

        public decimal R { get => _r; set => _r = ValidarRadio(value); }

        public override decimal GetArea() => (decimal)Math.PI * R * R;

        public override decimal GetPerimeter() => 2 * (decimal)Math.PI * R;

        private decimal ValidarRadio(decimal r)
        {
            if (r <= 0)
                throw new ArgumentException($"El radio no es válido: {r}. Debe ser mayor que 0.");
            return r;
        }
    }

}

