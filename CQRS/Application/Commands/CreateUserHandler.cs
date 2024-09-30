using MediatR;

namespace CQRS.Application.Commands
{
    public class CreateUserHandler:IRequest<bool>
    {
        public int IdUsuario { get; set; }
        public string User { get; set; }
        public string Password {  get; set; }
    }
}
