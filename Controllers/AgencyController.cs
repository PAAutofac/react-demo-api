using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using React_NaturalONE_API.Models;

namespace React_NaturalONE_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        List<Agency> agencies = new List<Agency>();

        public AgencyController()
        {
            agencies.Add(new Agency { name = "Cupcake", address = "Reading", town = "Berkshire", postcode = "RG2 7EH", status = "Pending" });
            agencies.Add(new Agency { name = "Donut", address = "Accrington", town = "Lancashire", postcode = "RG1 7SA", status = "Current" });
            agencies.Add(new Agency { name = "Frozen yoghurt", address = "Slough", town = "Berkshire", postcode = "RG2 7EH", status = "Current" });
            agencies.Add(new Agency { name = "Gingerbread", address = "Alton", town = "Hampshire", postcode = "RG1 7SA", status = "Current" });
            agencies.Add(new Agency { name = "Honeycomb", address = "Abingdon", town = "Oxfordshire", postcode = "RG1 7SA", status = "Current" });
            agencies.Add(new Agency { name = "Jelly Bean", address = "Amersham", town = "Buckinghamshire", postcode = "RG1 7SA", status = "Current" });
        }

        [HttpGet]
        public ActionResult<IEnumerable<Agency>> Get() {
            return agencies;
        }
    }
}