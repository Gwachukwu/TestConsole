// using TestConsole.Classes;
// using TestConsole.Shape;

// TestClass y = new TestClass(){square = 5};

// Console.WriteLine(y.square);

// TestClass x = new TestClass(-3);

// Console.WriteLine(x.square);

// TestClass? y =  null;

// Console.WriteLine(y);

// Shape s = new Square(4);

// Shape r = new Rectangle(5, 2);

// Console.WriteLine(s.Area());

// namespace TestConsole;

// Person p = new("Gwachukwu","Elebeke");
// Person p2 = new("Gwachukwu","Elebeke");
// Person p3 = p2 with { FirstName = "Chidalu"};

// Console.WriteLine(p);
// Console.WriteLine(p3);
// Console.WriteLine($"{p} == {p2} = {p == p2}");
// Console.WriteLine(ReferenceEquals(p,p2));

// public record Person(string FirstName, string LastName);

// IEnumerable<int> e = new System.Collections.Concurrent.ConcurrentQueue<int>();

Square s = new();
s.Size = 4;

Circle c = new();
c.Radius = 4;

IEnumerable<IGeometry> ig = new List<IGeometry>() { s, c };

foreach (IGeometry x in ig)
{
    Console.WriteLine($"Area is {x.Area()}");
}

foreach (IPositionable3D x in ig)
{
    Console.WriteLine($"Drawing at 2d position {x.X}, {x.Y}");
}

interface IPositionable3D : IPositionable2D
{
    int Z { get; }
}

interface IPositionable2D
{
    int X { get; }
    int Y { get; }
}
interface IGeometry
{
    double Area();
    double Perimeter();
}

public class Square : IGeometry, IPositionable2D
{
    public int X { get; set; }
    public int Y { get; set; }
    public double Size { get; set; }

    public double Area()
    {
        return Size * Size;
    }

    public double Perimeter()
    {
        return Size * 4;
    }
}

public class Circle : IGeometry, IPositionable3D
{
    public double Radius { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public double Area()
    {
        return Math.PI * (Radius * Radius);
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}