using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("getall")]
        public IActionResult GetAllCities()
        {
            var cities = _cityService.GetAll();
            return Ok(cities);
            //var result = _cityService.GetAll();
            //if (result.Success)
            //{
            //    return Ok(result.Data);
            //}
            //return BadRequest(result.Message);

        }
    }
}
