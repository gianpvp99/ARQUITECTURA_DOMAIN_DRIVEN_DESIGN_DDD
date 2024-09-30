using CQRS.Application.Commands;
using CQRS.Application.Querys;
using CQRS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [Route("GetAllUser")]
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            try
            {
                var response = await _mediator.Send(new GetAllUserQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
