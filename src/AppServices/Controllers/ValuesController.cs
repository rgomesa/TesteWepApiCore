using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppServices.Models;

namespace AppServices.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        

        // GET api/values
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            Produto p = new Produto();
            return p.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            Produto p = new Produto();
            return p.Get(id);
        }

        // GET api/values/5
        [HttpGet("{usuario}/{senha}")]
        public Boolean Get(string usuario, string senha )
        {
            return false;
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
