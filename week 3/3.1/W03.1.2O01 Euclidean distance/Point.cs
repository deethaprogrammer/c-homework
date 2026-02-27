public class Point
{
    public double X;
    public double Y;

    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
    }
    public static double GetEuclideanDistance(Point p1, Point p2)
    {
        double dx = p2.X - p1.X;
        double dy = p2.Y - p1.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}
