using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AngularApp.Models;
using AngularApp.Managers;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularApp.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            HeroManager HM = new HeroManager();
            return HM.GetAll;
        }

        // GET api/values/7
        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            HeroManager HM = new HeroManager();
            return HM.GetHeroByID(id);
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
