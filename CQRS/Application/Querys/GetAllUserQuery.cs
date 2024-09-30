using CQRS.Application.DTOs.Responses;
using CQRS.Domain.Entities;
using MediatR;

namespace CQRS.Application.Querys
{
    public class GetAllUserQuery:IRequest<List<UserResponse>>
    {
        public List<User> Users { get; set; }
    }
}
