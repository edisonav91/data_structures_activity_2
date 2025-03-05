namespace DataStructuresActivity_2
{
    public interface ITriangle
    {
        decimal A { get; set; }
        decimal B { get; set; }
        decimal C { get; set; }
        decimal H { get; set; }

        decimal GetArea();
        decimal GetPerimeter();
    }
}