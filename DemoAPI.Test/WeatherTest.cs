using DemoAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoAPI.Test
{
    public class WeatherTest
    {
        [Fact]
        public void WeatherGetSuccess()
        {
            var wc = new WeatherForecastController();

            var actual = wc.Get();

            var expected = "Hello World";

            Assert.Equal(expected, actual);
        }
    }
}
