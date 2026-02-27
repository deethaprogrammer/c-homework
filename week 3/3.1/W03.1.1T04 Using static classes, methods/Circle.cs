public class Circle
{
    public double Radius;
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public double GetArea() => Math.PI * Math.Pow(this.Radius, 2);
}