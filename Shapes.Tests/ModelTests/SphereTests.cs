using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {
    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Circle circle = new Circle(2);
      Sphere sphere = new Sphere(circle);
      double result = sphere.GetVolume();
      Assert.AreEqual(result, 33.49);
    }
  }
}
