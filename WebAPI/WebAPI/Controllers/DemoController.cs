﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("demo")]

    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Docker World";
        }
    }
}
