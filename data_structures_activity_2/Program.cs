using DataStructuresActivity_2;

var circle = new Circle(nameof(Circle), 5);
var square = new Square(nameof(Square), 10);
var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
var kite = new Kite(nameof(Kite), 7, 6, 5, 8);
var rectangle = new Rectangle(nameof(Rectangle), 4.568m, 67.790m);
var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65m, 54.67m, 23.09m);
var triangle = new Triangle(nameof(Triangle), 45.56m, 12.34m, 27.09m, 15);
var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 20);

var figures = new List<GeometricFigure>() { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}