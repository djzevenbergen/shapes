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
      Circle newCircle = new Circle(2);
      double result = newCircle.GetDiameter();
      Assert.AreEqual(result, 4);
    }

    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      Circle newCircle2 = new Circle(2);
      double result = newCircle2.GetCircumference();
      Assert.AreEqual(result, 12.56);
    }
  }
}