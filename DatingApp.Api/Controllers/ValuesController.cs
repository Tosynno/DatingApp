using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.Api.Models.Data;

namespace DatingApp.Api.Controllers
{
    //http:localhost:5000/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var value = await _context.Values.ToListAsync();

            return Ok(value);
        }

        //GET api/value/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(c => c.Id == id);
            return Ok(value);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        
        [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
        {

        }

         [HttpDelete("{id}")]
         public void Delete(int id)
        {

        }
    }
}