using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public int Radius { get; set; }

        public Sphere(int radiusLength)
        {
            Radius = radiusLength;
        }

        public double GetSurfaceArea()
        {
            return Math.Round(4 * 3.14 * (Radius * Radius), 2);
        }
    }
}