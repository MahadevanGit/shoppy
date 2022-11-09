using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shoppy.client.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeartBeatController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Shoppy.client.api service running. Copy this url ' /api/product ' to check product list.";
        }
    }
}