using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;

namespace SimpleAPI.test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController(null);
    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = controller.Get();
        Console.WriteLine(returnValue);
        //Assert.NotNull(returnValue);
        Assert.Null(returnValue);
    }



    [Fact]
    public void Test1()
    {

    }
}