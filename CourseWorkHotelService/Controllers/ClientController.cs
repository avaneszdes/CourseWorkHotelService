using System.Threading.Tasks;
using HotelServices.UserCommands.Commands.AddClient;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using ApplicationContext.Entities;
using System.Collections.Generic;
using HotelServices.UserCommands.Queries;

namespace CourseWorkHotelService.Controllers
{
    [ApiController]
    [Route("api/client")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;
        
        public ClientController(IMediator mediatr)
        {
            _mediator = mediatr;
        }

        [HttpPost]
        public async Task<long> AddClientAsync(AddClientCommand client)
        {
            return await _mediator.Send(client);
        }


        [HttpGet]
        public async Task<List<User>> GetAllClientAsync()
        {
            return await _mediator.Send(new GetAllClientsQuery());
        }
    }
}