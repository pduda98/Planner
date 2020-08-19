using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlannerApi.Models;
using PlannerApi.Repositories;

namespace PlannerApi.Controllers
{
    public class CalendarEventsController : ControllerBase
    {
        private readonly CalendarEventsRepository _calendarEventsRepository;
        CalendarEventsController(CalendarEventsRepository calendarEventsRepository)
        {
            _calendarEventsRepository = calendarEventsRepository;
        }
        [HttpGet("/api/v1/events")]
        public async Task<ActionResult> GetCalendarEventsByDateAsync(DateTime date, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpGet("/api/v1/events/{eventId}")]
        public async Task<ActionResult> GetCalendarEventByIdAsync(string eventId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpPost("/api/v1/events")]
        public async Task<ActionResult> AddCalendarEventAsync(CalendarEvent callendarEvent, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpPut("/api/v1/events")]
        public async Task<ActionResult> EditCalendarEventAsync(CalendarEvent callendarEvent, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
        [HttpDelete("/api/v1/events")]
        public async Task<ActionResult> DeleteCalendarEventAsync(string eventId, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
    }
}