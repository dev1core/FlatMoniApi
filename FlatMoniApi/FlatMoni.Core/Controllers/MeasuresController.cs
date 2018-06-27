using System;
using System.Collections.Generic;
using FlatMoniApi.FlatMoni.Infrastructure.DTO;
using FlatMoniApi.FlatMoni.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlatMoniApi.Controllers
{
    [Route("[controller]")]
    public class MeasuresController : Controller
    {
        private readonly IMeasureService _measureService;

        public MeasuresController(IMeasureService measureService)
        {
            _measureService = measureService;
        }

        // GET: api/measures
        [HttpGet("{name}")]
        public MeasureDto Get(string name)
        {
                     return _measureService.Get(name);
        }
    }
}
