using DataStructuresActivity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Rhombus : Square
    {
        private decimal _d1, _d2;

        public Rhombus(string name, decimal a, decimal d1, decimal d2) : base(name, a)
        {
            D1 = ValidarDiagonal(d1);
            D2 = ValidarDiagonal(d2);
        }

        public decimal D1 { get => _d1; set => _d1 = ValidarDiagonal(value); }
        public decimal D2 { get => _d2; set => _d2 = ValidarDiagonal(value); }

        public override decimal GetArea() => (D1 * D2) / 2;

        private decimal ValidarDiagonal(decimal d)
        {
            if (d <= 0)
                throw new ArgumentException($"La diagonal no es válida: {d}. Debe ser mayor que 0.");
            return d;
        }
    }
}