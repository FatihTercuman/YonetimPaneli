using Core.Abstract;
using Core.Abstract.IServices;
using Core.Concrete.DTTOs;
using Core.Concrete.Entities;
using Data;
using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProjectService:IProjectServices
    {
        private readonly ApplicationDbContext context = ApplicationDbContext.Create();
        private readonly IUnitOfWork unitOfWork;

        public ProjectService()
        {
            this.unitOfWork=new UnitOfWork(context);
        }

        public IEnumerable<ProjectDto> GetAllProjects()
        {
            return from p in unitOfWork.ProjectRepository.ReadMany(null, "Category")
                   select new ProjectDto
                   {
                       Id = p.Id,
                       Title = p.Title,
                       Description = p.Description,
                       CategoryId = p.CategoryId,
                       DemoUrl = p.DemoUrl,
                       GitUrl = p.GitUrl,
                       IsDraft = !p.Active,
                       PublishDate = p.PublishDate,
                       CategoryName = p.Category.Name
                   };
        }

        public IEnumerable<CategoryDto> GetCategories()
        {
            return unitOfWork.CategoryRepository.ReadMany().Select(c => new CategoryDto { Id = c.Id, Name = c.Name });
        }

        public IEnumerable<ProjectDto> GetProjectByCategory(int categoryId)
        {
            return from p in unitOfWork.ProjectRepository.ReadMany(x => x.CategoryId == categoryId, "Category")
                   select new ProjectDto
                   {
                       Id = p.Id,
                       Title = p.Title,
                       Description = p.Description,
                       CategoryId = p.CategoryId,
                       DemoUrl = p.DemoUrl,
                       GitUrl = p.GitUrl,
                       IsDraft = !p.Active,
                       PublishDate = p.PublishDate,
                       CategoryName = p.Category.Name
                   };
        }

        public ProjectDto GetProjectById(int id)
        {
            Project p = unitOfWork.ProjectRepository.ReadById(id);
            return new ProjectDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                CategoryId = p.CategoryId,
                DemoUrl = p.DemoUrl,
                GitUrl = p.GitUrl,
                IsDraft = !p.Active,
                PublishDate = p.PublishDate,
                CategoryName = p.Category.Name
            };
        }
    }
}
