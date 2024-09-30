using CQRS.Domain.Entities;
using CQRS.Domain.Interfaces;
using CQRS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUser()
        {
            var response = await _dbContext.Users.ToListAsync();
            return response;
        }
    }
}
