using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyApp.Data;
using UdemyApp.Models;

namespace UdemyApp.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext dataContext;
        public ValuesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }


        // GET api/values
        [HttpGet("profiles")]
        public async Task<IEnumerable<Value>> Get()
        {
            var result = await dataContext.Values
                //.Select(u => u.Name)
                .ToListAsync();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}/name")]
        public async Task<string> Get(int id )
        {
            var result = await dataContext.Values.Where(v => v.Id == id)
                .Select(v => v.Name)
                .FirstOrDefaultAsync();

            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
