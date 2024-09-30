using AutoMapper;
using CQRS.Application.DTOs.Responses;
using CQRS.Domain.Entities;
using CQRS.Domain.Interfaces;
using MediatR;

namespace CQRS.Application.Querys
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, List<UserResponse>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public GetAllUserHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<UserResponse>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var repository = await _userRepository.GetAllUser();
            var response = _mapper.Map<List<UserResponse>>(repository);
            return response;
        }
    }
}
