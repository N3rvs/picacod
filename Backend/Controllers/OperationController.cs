using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Entidades;
using System.Reflection.PortableExecutable;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet("all")]
        public List<People> GetPeoples() => Repository.People;

        [HttpGet("{id}")]

        //=> Repository.People.First(p => p.Id == id);
        public ActionResult<People> Get(int id)
        {
            var people = Repository.People.FirstOrDefault(P => P.Id == id);
            if (people == null)
            {
                return NotFound();
            }
            return Ok(people);
        }

        [HttpPost]
        public IActionResult Add(People people)
        {
            if (string.IsNullOrEmpty(people.Name))
            {
               return BadRequest();
            }
                Repository.People.Add(people);
            return NoContent ();
            }

        [HttpGet("search/{search}")]
        public List<People> Get (string search) =>
                Repository.People.Where(p => p.Name.ToUpper().Contains(search.ToUpper())).ToList();
        }
   


        
    
}

