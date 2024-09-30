using CQRS.Application.DTOs.Responses;
using CQRS.Domain.Entities;

namespace CQRS.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<bool> AddUser(User user);
    }
}
