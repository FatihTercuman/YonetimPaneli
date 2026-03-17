using Core.Abstract;
using Core.Abstract.IRepositories;
using Data.Context;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
    
      public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
        }

        private IPostRepository postRepository;
        public IPostRepository PostRepository => postRepository=postRepository??new PostRepository(context);

        private ITagRepository tagRepository;
        public ITagRepository TagRepository => tagRepository=tagRepository??new TagRepository(context);

        public void Commit()
        {
            try
            {
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                context.Dispose();
                throw ex;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
