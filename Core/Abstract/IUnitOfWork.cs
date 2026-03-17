using Core.Abstract.IRepositories;
using System;

namespace Core.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IPostRepository PostRepository { get; }

        ITagRepository TagRepository { get; }

        void Commit();
    }
}
