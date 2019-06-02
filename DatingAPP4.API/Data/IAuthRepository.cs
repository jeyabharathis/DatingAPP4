using System.Threading.Tasks;
using DatingAPP4.API.Models;

namespace DatingAPP4.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}