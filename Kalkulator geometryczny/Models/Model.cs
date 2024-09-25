namespace KalkulatorGeometryczny.Models
{
    public class Model
    {
        public double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}