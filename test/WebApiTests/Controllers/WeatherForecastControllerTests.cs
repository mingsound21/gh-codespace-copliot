// add a namespace for the WeatherForecastController
// Path: test/WebApiTests/Controllers/WeatherForecastControllerTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        
    }
    // add a test method that tests the GetRange method of WeatherForecastContoller
    // Path: test/WebApiTests/Controllers/WeatherForecastControllerTests.cs
    [TestMethod]
    public void GetRangeTest()
    {
        // arrange
        var controller = new WeatherForecastController(null);
        var range = new DateRange { Length = 5 };
        // act
        var result = controller.GetRange(range);
        // assert
        Assert.AreEqual(5, result.Count());
    }
    
   
}