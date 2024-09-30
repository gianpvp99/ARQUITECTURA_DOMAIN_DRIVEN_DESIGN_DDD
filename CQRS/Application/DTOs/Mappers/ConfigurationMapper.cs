using AutoMapper;
using CQRS.Application.DTOs.Requests;
using CQRS.Application.DTOs.Responses;
using CQRS.Domain.Entities;

namespace CQRS.Application.DTOs.Mappers
{
    public class ConfigurationMapper: Profile
    {
        public ConfigurationMapper()
        {
            // Mapeo de Entidad -> Response DTO
            CreateMap<User, UserResponse>();
            // Mapeo de Request DTO -> Entidad
            CreateMap<UserRequest, User>();
        }
    }
}
