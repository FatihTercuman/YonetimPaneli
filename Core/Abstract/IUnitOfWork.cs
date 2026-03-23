using Core.Abstract.IRepositories;
using Core.Abstract.IServices;
using System;

namespace Core.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IPostRepository PostRepository { get; }

        ITagRepository TagRepository { get; }
        IProjectRepository ProjectRepository { get; }
        ICategoryRepository CategoryRepository { get; }

        void Commit();
    }
}
