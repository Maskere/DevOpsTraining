using Microsoft.AspNetCore.Mvc;
using ClassLibraryTrophy;

namespace MyApp.Namespace {
    [Route("api/[controller]")]
    [ApiController]
    public class TrophiesController : ControllerBase {
        private TrophiesRepository repo = new();

        // GET: api/<TrophiesController>
        [HttpGet]
        public List<Trophy> Get() {
            List<Trophy>? trophies = repo.Get();
            if(trophies == null){
                throw new ArgumentNullException("Collection not found");
            }

            return new List<Trophy>(trophies);
        }

        // GET api/<TrophiesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrophiesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrophiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrophiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
