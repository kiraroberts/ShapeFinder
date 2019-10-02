using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void Sphere_GetSurfaceArea_AreaOfSphere()
        {
            //Arrange
            Sphere newSphere = new Sphere(5);
            //Act
            double result = newSphere.GetSurfaceArea();
            //Assert
            Assert.AreEqual(result, 314);
        }
        [TestMethod]
        public void Sphere_GetVolume_VolumeOfSphere()
        {
            //Arrange
            Sphere newSphere = new Sphere(5);
            //Act
            double result = newSphere.GetVolume();
            //Assert
            Assert.AreEqual(523.6, result);
        }
    }
}