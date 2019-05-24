using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoFabricApplication.Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        [Route("GetSample")]
        public List<string> GetSample()
        {
            List<string> sample = new List<string>
            {
                Environment.MachineName
            };

            return sample;
        }
    }
}