using System;
using Microsoft.AspNetCore.Mvc;

namespace ChristmasChecker.Controllers
{
    [Route("is_christmas")]
    [ApiController]
    public class ChristmasController : ControllerBase
    {
        [HttpGet]
        public object IsChristmas()
        {
            var today = DateTime.Today;
            if (today.Day == 25 && today.Month == 12)
                return new {is_christmas = "yes"};
            return new {is_christmas = "no"};
        }
    }
}