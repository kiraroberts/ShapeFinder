using System;

namespace Shapes.Models
{
    public class Triangle
    {
        public int Bottom { get; set; }
        public int Height { get; set; }
       

    public Triangle(int bottom, int height)
    {
        Bottom = bottom;
        Height = height;
    }

    public double GetTriangleArea()

    {
        
        return Math.Round(Bottom * Height * (.5), 2);

    }



    }

}