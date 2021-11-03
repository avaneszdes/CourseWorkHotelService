using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ApplicationContext.Entities;
using HotelServiceRepository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HotelServices.HotelCommands.Queries.GetHotelNames
{
    class GetHotelNamesQueryHandler : IRequestHandler<GetHotelNamesQuery, List<string>>
    {
        private readonly IHotelRepository _hotelRepository;

        public GetHotelNamesQueryHandler(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<List<string>> Handle(GetHotelNamesQuery request, CancellationToken cancellationToken)
        {
            return await _hotelRepository.GetAllHotelNames().ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
