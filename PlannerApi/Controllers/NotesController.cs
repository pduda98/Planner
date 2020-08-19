using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlannerApi.Repositories;
using PlannerApi.Models;

namespace PlannerApi.Controllers
{
    public class NotesController : ControllerBase
    {
        private readonly NotesRepository _notesRepository;
        public NotesController(NotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        [HttpPost("/api/v1/notes")]
        public async Task<ActionResult> AddNoteAsync(Note note, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }

        [HttpGet("/api/v1/notes")]
        public async Task<ActionResult> GetNotesAsync(int limit = 20, int page = 0, int sortDirection = -1, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpPut("/api/v1/notes/{noteId}")]
        public async Task<ActionResult> EditNotesAsync(string noteId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpDelete("/api/v1/notes/{noteId}")]
        public async Task<ActionResult> DeleteNotesAsync(string noteId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
    }
}