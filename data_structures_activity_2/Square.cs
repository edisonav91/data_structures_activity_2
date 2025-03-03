using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2;

public class Square : GeometricFigure
{
    private decimal _a;

    public Square(decimal _a)
    {
        _A = _a;

    }

    public decimal _A { get => _a; set => _a = value; }

    public override double GetArea()
    {
        throw new NotImplementedException();
    }

    public override double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public decimal square 
}
