using Microsoft.AspNetCore.Identity;

namespace ApiConcertHub.Interface
{
    public interface IAuthService
    {

        Task<IdentityResult> Register(string email,
            string password, string role);

        Task<string> Login(string email, string pwd);
    }
}
