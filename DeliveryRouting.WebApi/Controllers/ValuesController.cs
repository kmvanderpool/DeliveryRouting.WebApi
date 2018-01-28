using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeliveryRouting.SQLData;
using DeliveryRouting.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryRouting.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DeliveryRoutingContext _context;
        public ValuesController(DeliveryRoutingContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var routes = _context.Routes
                .AsNoTracking()
                .Include(x => x.Addresses)
                .ToList();

            //filter out deleted
            foreach(var x in routes)
            {
                x.Addresses = x.Addresses.Where(y => !y.IsDeleted).ToList();
            }
            var deliveryProgram = new DeliveryProgram() {ProgramName ="my program", Routes = routes };
             return Ok(deliveryProgram);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
