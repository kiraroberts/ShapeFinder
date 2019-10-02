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

        public double GetVolume()
        {
            // return Math.Round((4/3) * 3.14 * (Radius * Radius * Radius), 2);

            return Math.Round(( 4.0 / 3.0 ) * Math.PI * Math.Pow( Radius, 3 ), 2);
        }
    }
}