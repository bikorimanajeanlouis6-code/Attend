using Domain.Entities;

using Application.Interfaces;
using Infrastructure.Data;
namespace Infrastructure.Repositories
{
    public class ClassRepository : IClass
    {
          private readonly ApplicationDbContext _dbcontext;
           public ClassRepository(ApplicationDbContext dbcontext)
        {
              _dbcontext= dbcontext;
            
    }
     public List<Classs> GetAllClasses()
        {
            return _dbcontext.Classses.ToList();
           
        }
}    }