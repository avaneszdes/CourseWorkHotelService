using System.Threading;
using System.Threading.Tasks;
using ApplicationContext.Entities;
using HotelServiceRepository.Interfaces;
using MediatR;

namespace HotelServices.UserCommands.Commands.AddClient
{
    public class AddClientCommandHandler: IRequestHandler<AddClientCommand, long>
    {
        private readonly IUserRepository _userRepository;
        public AddClientCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        
        public async Task<long> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            var client = new User
            {
                FirstName = request.FirstName,
                LastName = request.FirstName,
                Patronomic = request.Patronomic,
                PassportNumber = request.PassportNumber,
                PassportSeries = request.PassportSeries,
                PhoneNumber = request.PhoneNumber,
                Password = request.Password

            };
            
           return await _userRepository.AddUserAsync(client);
        }
    }
}