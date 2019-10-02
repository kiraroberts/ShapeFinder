using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{

    [TestClass]

    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_GetTriangleArea_AreaofTriangle()
        {
            Triangle newTriangle = new Triangle(4, 5);
            double result = newTriangle.GetTriangleArea();
            Assert.AreEqual(result, 10);

        }
    }




}