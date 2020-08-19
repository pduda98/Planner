using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using PlannerApi.Models;
using PlannerApi.Repositories;

namespace PlannerApi.Controllers
{
    public class SingleTasksController : ControllerBase
    {
        private readonly SingleTasksRepository _singleTasksRepository;
        SingleTasksController(SingleTasksRepository singleTasksRepository)
        {
            _singleTasksRepository = singleTasksRepository;
        }
        [HttpPost("/api/v1/singleTasks")]
        public async Task<ActionResult> AddSingleTaskAsync(SingleTask singleTask, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }

        [HttpGet("/api/v1/singleTasks/{taskId}")]
        public async Task<ActionResult> GetSingleTaskByIdAsync(string taskId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpGet("/api/v1/singleTasks")]
        public async Task<ActionResult> GetSingleTasksAsync(int limit = 20, int page = 0, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpPut("/api/v1/singleTasks/{taskId}")]
        public async Task<ActionResult> EditSingleTaskAsync(string taskId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpDelete("/api/v1/singleTasks/{taskId}")]
        public async Task<ActionResult> DeleteSingleTaskAsync(string taskId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
    }
}