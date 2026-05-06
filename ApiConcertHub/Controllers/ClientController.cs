using ApiConcertHub.Interface;
using ApiConcertHub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiConcertHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles ="Admin")]
    public class ClientController : Controller
    {
        private readonly IClientService _clienteService;

        public ClientController (IClientService clienteService)
        {
            _clienteService = clienteService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] Clients client)
        {
            var created = await _clienteService.Create(client);
            return Ok(created);
        }
    }
}
