using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        // GET api/projects?search=crm
        [HttpGet]
        public IActionResult Get(string search)
        {
            return Ok();
        }

        // GET api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //POST api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        //PUT api/projects/1234
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        //DELETE api/projects/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        // PUT api/projects/1234/start
        [HttpPut("{id}")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // PUT api/projects/1234/complete
        [HttpPut("{id}")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }
    }
}
