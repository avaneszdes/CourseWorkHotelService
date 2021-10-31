using MediatR;

namespace HotelServices.UserCommands.Commands.AddClient
{
    public class AddClientCommand :  IRequest<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomic { get; set; }
        public string PassportNumber { get; set; }
        public string PassportSeries { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}