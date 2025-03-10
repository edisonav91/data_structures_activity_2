using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public class Triangle : Rectangle
    {
        private decimal _c;
        private decimal _h; 

        public Triangle(string name, decimal a, decimal b, decimal c, decimal h) : base(name, a, b)
        {
            C = ValidarLado(c);
            H = ValidarAltura(h);
        }

        private decimal ValidarAltura(decimal h)
        {
            if (h <= 0) 
                throw new ArgumentException($"La altura no es válida: {h}. Debe ser mayor que 0.");

            return h;
        }

        public decimal C { get => _c; set => _c = ValidarLado(value); }
        public decimal H { get => _h; private set => _h = value; } // 🔹 Ahora se puede asignar en el constructor

        public override decimal GetArea() => B * H / 2;
        public override decimal GetPerimeter() => A + B + C;

    }
}