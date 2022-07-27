using APIExercise.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdoptionController : ControllerBase
    {
        public AdoptionDBContext adoptionDBContext = new AdoptionDBContext();

        [HttpGet("GetPetById")]
        public Pet GetById(int id)
        {
            //return adoptionDBContext.Pets.FirstOrDefault(p => p.Id == id);
            return adoptionDBContext.Pets.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
        }

        [HttpGet("GetAllPets")]
        public List<Pet> GetAll()
        {
            return adoptionDBContext.Pets.Include(p => p.Category).ToList();
        }
        
    }
}
