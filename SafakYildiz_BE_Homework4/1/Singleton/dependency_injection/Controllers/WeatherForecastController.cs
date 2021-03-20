using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dependency_injection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly INumGenerator numGenerator;
        public WeatherForecastController(INumGenerator NumGenerator)
        {
            numGenerator = NumGenerator;
        }


        [HttpGet]
        public String Get()
        {
            NumGenerator n = new NumGenerator();

            int num = n.GetRandomNumber();
            return num.ToString();
        }
    }
}
