using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]")]
    public class AboutControllers
    {
        [Route("")]
        public string Phone()
        {
            return "55+ (55)5555-5555";
        }
        [Route("[Action]")]
        public string Country()
        {
            return "Brazil";
        }
    }
}
