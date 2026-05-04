using ApiConcertHub.Interface;
using ApiConcertHub.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ApiConcertHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model)
        {
            var result = await _authService.Register(model.email,
                model.password, model.role);

            if (result.Succeeded)
            {
                return Ok(new { message = $"Usuario {model.email} creado con éxito" });
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var token = await _authService.Login(login.Email, login.Password);
            if(token != null)
            {
                return Ok(new { Token = token });
            }

            return Unauthorized(new { Message = "Credenciales incorrectas" });
        } 
        public IActionResult Index()
        {
            return View();
        }
    }
}
