namespace Shapes.Models
{
    public class Circle
    {
        public int Radius { get; set; }
        public Circle(int radiusLength)
        {
            Radius = radiusLength;
        }
        public int GetDiameter()
        {
            return Radius * 2;
        }
    }
}