namespace TestConsole.Shape;

public abstract class Shape
{
    protected double Width { set; get; }
    protected double Height { set; get; }
    public virtual double Area()
    {
        return Width * Height;
    }
};