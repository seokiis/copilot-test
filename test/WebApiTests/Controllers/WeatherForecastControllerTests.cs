// add a namespace for the WeatherForecastController
using WebApi.Controllers;
namespace WebApiTests;

[TestClass]
public class WeatherForecastControllerTests
{
    [TestMethod]
    public void TestMethod1()
    {
    }
    // add a test method that tests the GetRange method of WeatherForecastController
    // Path: test/WebApiTests/UnitTest1.cs
    [TestMethod]
    public void TestMethod2()
    {
        // arrange
        var controller = new WeatherForecastController(null);
        var range = new DateRange
        {
            Length = 5,
            Start = DateOnly.FromDateTime(DateTime.Now)
        };
        // act
        var result = controller.GetRange(range);
        // assert
        Assert.AreEqual(5, result.Count());
    }
}