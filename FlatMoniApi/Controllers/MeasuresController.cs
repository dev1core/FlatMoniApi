using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FlatMoniApi.FlatMoni.Infrastructure.Command.Users;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoniApi.FlatMoni.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlatMoniApi.Controllers
{
    [Route("[controller]")]
    public class MeasuresController : ControllerBase
    {
        private readonly IMeasureService _measureService;

        public MeasuresController(IMeasureService measureService)
        {
            _measureService = measureService;
        }

        // GET: api/measures
        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name) {
            var measure =  await _measureService.GetAsync(name);

            if(measure == null)
            {
                return NotFound();
            }
            return Ok(measure);
        }

        [HttpPost("")]
        public async Task Post([FromBody]CreateMeasure request)
        {
            await _measureService.RecordAsync(request.Name, request.Value, request.Unit, request.Date);
        }
    }
}
