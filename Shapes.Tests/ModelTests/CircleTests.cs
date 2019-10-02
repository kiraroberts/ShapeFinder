using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_GetDiameter_DiameterOfCircle()
        {
            //Arrange
            Circle newCircle = new Circle(5);
            //Act
            int result = newCircle.GetDiameter();
            //Assert
            Assert.AreEqual(result, 10);
        }
    }
}