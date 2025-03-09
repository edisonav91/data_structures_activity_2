using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract decimal GetArea();
        public abstract decimal GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-15} => Área.....: {GetArea(),10:F5}  Perímetro: {GetPerimeter(),10:F5}";
        }
    }
}