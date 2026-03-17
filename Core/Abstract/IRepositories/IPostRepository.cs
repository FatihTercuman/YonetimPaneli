using Core.Concrete.Entities;
using Utils.Wrappers;

namespace Core.Abstract.IRepositories
{
    public interface IPostRepository:IRepository<Post> { }
    
    public interface ITagRepository: IRepository<Tag> { }
    
}
