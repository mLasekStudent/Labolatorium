using Data;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3___App.Controllers
{
    [Route("api/reservations")]
    [ApiController]
    public class ReservationApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReservationApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFiltered(string filter)
        {
            return Ok(_context.Reservations
                .Where(r => r.miasto.StartsWith(filter))
                .Select(r => new { r.miasto, r.Id })
                .ToList());
        }
    }
}
