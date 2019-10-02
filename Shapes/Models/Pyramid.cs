using System;

namespace Shapes.Models
{
  public class Pyramid
  {
    public Triangle Face { get; set; }

    public Pyramid (Triangle side)
    {
      Face = side;
    }


    public double GetSurfaceArea()
    {
        
        return Math.Round(Face.Bottom * Face.Height * (.5) * 4 + Math.Pow((Face.Bottom), 2), 2);

    }
  }
}