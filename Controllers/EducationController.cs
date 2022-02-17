using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EducationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationController : ControllerBase
    {
        private readonly ILogger<EducationController> _logger;

        public EducationController(ILogger<EducationController> logger)
        {
            _logger = logger;
        }

        /*
            this endpoint will return available educations for user with id
           endpoint url :  api/education/educations/123  
        */
        [HttpGet("educations/{id}")]
        public IEnumerable<Education> Get(string id)
        {
            var educations = new List<Education>{
                new Education{Id="1",Title="IOT Programming",Price=79.99},
                new Education{Id="2",Title="Rabbit MQ",Price=270.00},
            //    new Education{Id="3",Title="Micro services",Price=90.99},
                
            };

            return educations;
        }

        /*
         *  api/education/educationdetail/1
         *  this will return education detail
         */

        [HttpGet("educationdetail/{id}")]
        public Education EducationDetail(string id)
        {
            

            return new Education { Id = id, Title = "IOT Programming", Price = 49.99 };
        }

    }

    public class Education
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}