﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        
    [HttpGet]
        public IActionResult Get()
        {
            return Ok("Healthy");
        }
    }
}

