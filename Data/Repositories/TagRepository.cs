using Core.Abstract.IRepositories;
using Core.Concrete.Entities;
using Data.Context;
using Utils.Wrappers;

namespace Data.Repositories
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
