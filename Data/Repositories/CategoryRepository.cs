using Core.Abstract.IRepositories;
using Core.Concrete.Entities;
using Data.Context;
using Utils.Wrappers;

namespace Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
