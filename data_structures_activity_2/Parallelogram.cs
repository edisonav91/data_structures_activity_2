using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Parallelogram : Rectangle
    {
        private decimal _h;

        public Parallelogram(string name, decimal a, decimal b, decimal h) : base(name, a, b)
        {
            H = ValidarAltura(h);
        }

        public decimal H { get => _h; set => _h = ValidarAltura(value); }

        public override decimal GetArea() => B * H;

        private decimal ValidarAltura(decimal h)
        {
            if (h <= 0)
                throw new ArgumentException($"La altura no es válida: {h}. Debe ser mayor que 0.");
            return h;
        }
    }

}
