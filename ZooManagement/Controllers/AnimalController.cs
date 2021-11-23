using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Database;
using ZooManagement.Models.Response;
using ZooManagement.Repositories;

namespace ZooManagement.Controllers
{
    [ApiController]
    [Route("/animals")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalsRepo _animals;

        public AnimalController(IAnimalsRepo animals)
        {
            _animals = animals;
        }


        [HttpGet("{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
            var animal = _animals.GetAnimalById(id);
            return new AnimalResponse(animal);
        }
    }
}