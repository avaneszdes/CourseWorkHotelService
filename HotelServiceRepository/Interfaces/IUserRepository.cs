using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationContext.Entities;

namespace HotelServiceRepository.Interfaces
{
    public interface IUserRepository
    {
        Task<long> AddUserAsync(User client);
        Task DeleteUserAsync(long userId);
        Task UpdateUserAsync(User client);
        Task GetUserByIdAsync(long userId);
        Task<List<User>> GetAllUsers();
    }
}