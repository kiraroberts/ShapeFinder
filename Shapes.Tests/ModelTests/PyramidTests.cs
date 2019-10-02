using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class PyramidTests
  {

      [TestMethod]
    public void Pyramid_GetSurfaceArea_SurfaceAreaOfPyramid()
    {
      // Arrange
      Triangle newTriangle = new Triangle(4, 5);
      Pyramid newPyramid = new Pyramid(newTriangle);
      // Act
      double result = newPyramid.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 56);
    }


  }
}