using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicScale.Services;

namespace MusicScale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScaleFinderController : ControllerBase
    {
        //private readonly ScaleMakerService _scaleMakerService;

        // GET: api/ScaleFinder
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ScaleFinder/"C"
        [HttpGet("{note}", Name = "Get")]
        public List<string> Get(string note)
        {
            return ScaleMakerService.FindMajor(note);
        }

        //// POST: api/ScaleFinder
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/ScaleFinder/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ScaleFinder/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
