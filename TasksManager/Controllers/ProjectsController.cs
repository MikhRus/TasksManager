using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TasksManager.ViewModels.Filters;
using TasksManager.ViewModels.Request;
using TasksManager.ViewModels.Response;

namespace TasksManager.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController:Controller
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ListResponse<ProjectResponse>))]
        public async Task<IActionResult> GetProjectsListAsync(ProjectFilter filter)
        {
            throw new NotImplementedException();
    }



        [HttpPost]
        [ProducesResponseType(201, Type = typeof(ProjectResponse))]

        [ProducesResponseType(400)]
        public async Task<IActionResult> PostAsync(CreateProjectRequest request)
        {
            throw new NotImplementedException();
        }


        [HttpGet("{projectId}")]
        [ProducesResponseType(200, Type = typeof(ProjectResponse))]
        [ProducesResponseType(404)]
        public Task<IActionResult> GetProjectAsync(int projectId)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{projectId}")]
        [ProducesResponseType(200, Type = typeof(ProjectResponse))]
        [ProducesResponseType(404)]
        public Task<IActionResult> UpdateProjectAsync(int projectId, [FromBody]UpdateProjectRequest projectUpdate)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{projectId}")]
        [ProducesResponseType(204)]
        public Task<IActionResult> DeleteProjectAsync(int projectId)
        {
            throw new NotImplementedException();
        }
    }
}
