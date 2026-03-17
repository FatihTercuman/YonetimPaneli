using Core.Abstract.IRepositories;
using Core.Concrete.Entities;
using Data.Context;
using Utils.Wrappers;

namespace Data.Repositories
{
    internal class PostRepository:Repository<Post>,IPostRepository
    {
        public PostRepository(ApplicationDbContext context) : base(context) 
        {

        }
    }
}
