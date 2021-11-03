using System.Collections.Generic;
using MediatR;

namespace HotelServices.HotelCommands.Queries.GetHotelNames
{
    public class GetHotelNamesQuery : IRequest<List<string>>
    {
    }
}
