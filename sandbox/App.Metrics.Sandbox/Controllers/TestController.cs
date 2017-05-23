﻿using Microsoft.AspNetCore.Mvc;

namespace App.Metrics.Sandbox.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}