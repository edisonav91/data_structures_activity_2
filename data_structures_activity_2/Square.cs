using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresActivity_2;

public class Square : GeometricFigure
{
    private decimal _a;

    public Square(decimal a)
    {
        A = ValidateA(a);
    }

    public decimal A { get => _a; set => _a = ValidateA(value); }

    public override decimal GetArea() => A * A;

    public override decimal GetPerimeter() => 4 * A;

    private decimal ValidateA(decimal a)
    {
        if (a <= 0)
            throw new ArgumentException($"Invalid side length: {a}");
        return a;
    }
}
