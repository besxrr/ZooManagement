using System.Linq;
using ZooManagement.Models.Database;

namespace ZooManagement.Repositories
{
    public interface IAnimalsRepo
    {
        public Animal GetAnimalById(int id);
    }
    
    
    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly ZooManagementDbContext _context;

        public AnimalsRepo(ZooManagementDbContext context)
        {
            _context = context;
        }
        
        public Animal GetAnimalById(int id)
        {
            return _context.Animals.Single(animal => animal.Id == id);
        }
    }
}