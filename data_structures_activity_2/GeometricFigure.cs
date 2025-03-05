using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public abstract class GeometricFigure
    {
        public string? Name { get; set; }

        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();

        public override string ToString()
        {
            return $"Figura: {Name}, Área: {GetArea()}, Perímetro: {GetPerimeter()}";
        }
    }
}
