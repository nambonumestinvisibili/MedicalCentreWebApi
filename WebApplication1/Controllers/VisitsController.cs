using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitsController : Controller
    {

        private readonly ILogger<PatientsController> _logger;

        public VisitsController(ILogger<PatientsController> logger)
        {
            _logger = logger;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Visit> Get()
        {
            return VisitsRepository.FindAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Visit Get(int id)
        {
            return VisitsRepository.FindById(id);
        }

        //// POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
