using ApiConcertHub.Interface;
using ApiConcertHub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ApiConcertHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles ="Client")]
    public class TicketController : Controller
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] Tickets objTk)
        {
            var createdTk = await _ticketService.Create(objTk);
            return Ok(createdTk);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> getByClientId(Guid Id)
        {
            string UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var tk = await _ticketService.GetByClientId(Id, UserId);

            return tk != null ? Ok(tk) : NotFound("No me engañes perro");
        }
    }
}
