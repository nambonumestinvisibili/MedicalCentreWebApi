using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicCentre.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : Controller
    {

        private readonly ILogger<PatientsController> _logger;

        public PatientsController(ILogger<PatientsController> logger)
        {
            _logger = logger;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return PatientsRepository.FindAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name =nameof(Get))]
        public PatientDTO Get(int id)
        {
            Patient patient = PatientsRepository.FindById(id);
            PatientDTO pat = PatientsRepository.ConvertPatientToPatientDTO(patient);
            //PatientDTO finalpat = this.CreateLinksForPatient(pat);
            return pat;
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

        //public PatientDTO CreateLinksForPatient(PatientDTO patient)
        //{
        //    var idObj = new { id = patient.Id };

        //    patient.Links.Add(
        //        //new LinkDTO(this.urlHelper.Link(nameof(this.Get), idObj),
        //        //"self",
        //        //"GET"
        //        //));
        //        new LinkDTO(_generator.GetPathByAction(nameof(this.Get)))

        //    return patient;
        //}
    }
}
