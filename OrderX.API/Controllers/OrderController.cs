using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderX.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }
        
        [HttpPost(Name = "CreateOrder")]
        public bool CreateOrder()
        {
            return true;
        }
    }
}
