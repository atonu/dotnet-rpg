using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.Character
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(User user, string password);
        Task<bool> UserExists(string username);
    }
}