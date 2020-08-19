using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlannerApi.Repositories;

namespace PlannerApi.Controllers
{
    public class CalendarDaysController : ControllerBase
    {
        private readonly CalendarEventsRepository _calendarEventsRepository;
        private readonly SingleTasksRepository _singleTasksRepository;
        private readonly RoutineTasksRepository _routineTasksRepository;
        CalendarDaysController(CalendarEventsRepository calendarEventsRepository, SingleTasksRepository singleTasksRepository, RoutineTasksRepository routineTasksRepository)
        {
            _calendarEventsRepository = calendarEventsRepository;
            _singleTasksRepository = singleTasksRepository;
            _routineTasksRepository = routineTasksRepository;
        }
        
        [HttpGet("/api/v1/calendarDay")]
        public async Task<ActionResult> GetCalendarDayAsync(DateTime date, CancellationToken cancellationToken = default)
        {
            throw new System.Exception();
        }
    }
}