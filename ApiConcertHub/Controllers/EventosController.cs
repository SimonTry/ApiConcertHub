using ApiConcertHub.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiConcertHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : Controller
    {
        private readonly IEventosService _eventService;

        public EventosController(IEventosService eventoService)
        {
            _eventService = eventoService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _eventService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _eventService.GetById(id);
            return result != null ? Ok(result) : NotFound();

        }
    }
}
