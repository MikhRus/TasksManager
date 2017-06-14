using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TasksManager.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static List<string> Values { get; } = new List<string>();

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(200,Type = typeof(string))]
        [ProducesResponseType(404)]

        public IActionResult Get(int id)
        {
           string value =  Values.FirstOrDefault(s => s.StartsWith(id.ToString()));
            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound($"Value with Id {id} not found");
            }
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string value)
        {
            string valueToAdd = Values.Count + "-" + value;
            Values.Add(valueToAdd);
            return "posted " + valueToAdd;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(404)]
        public IActionResult Put(int id, [FromBody]string value)
        {
            string foundValue = Values.FirstOrDefault(s => s.StartsWith(id.ToString()));
            if (foundValue == null)
            {
                return NotFound();
            }
            int index = Values.IndexOf(foundValue);
            string newValue = $"{id} - {value}";
            Values[index] = newValue;
            return Ok(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            string foundValue = Values.FirstOrDefault(s => s.StartsWith(id.ToString()));
            if (foundValue == null)
            {
                return;
            }
            Values.Remove(foundValue);
        }
    }
}
