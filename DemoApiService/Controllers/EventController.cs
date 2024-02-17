using DemoApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Event>> GetEvents()
        { 
            // Create a demo list of 10 events 
            var events = new List<Event>(); 
            for (int i = 0; i < 10; i++)
            {
                events.Add(new Event
                {
                    Id = i,
                    Name = $"Event {i}",
                    Description = $"Description for Event {i}",
                    StartTime = DateTime.Now.AddDays(i),
                    EndTime = DateTime.Now.AddDays(i + 1),
                    Location = $"Location for Event {i}"
                });
            }

            return Ok(events);

        }

    }
}
