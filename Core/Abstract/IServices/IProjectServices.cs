using Core.Concrete.DTTOs;
using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract.IServices
{
    public interface IProjectServices
    {
        IEnumerable<ProjectDto> GetAllProjects();

        IEnumerable<ProjectDto> GetProjectByCategory(int categoryId);

        ProjectDto GetProjectById(int id);

        IEnumerable<CategoryDto> GetCategories();

        void NewProject(NewProjectDto model);

        void DeleteProject(int id);
        void UpdateProject(UpdateProjectDto model);
    }
}
