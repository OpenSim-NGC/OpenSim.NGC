using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OpenSim.Data.Models;
using OpenSim.GridServices.AssetService.Models;

namespace OpenSim.GridServices.AssetService.Events.AssetDb
{
    public class GetData {
        public class Request : IRequest<AssetDto> 
        { 
            public string Id { get; set; }
        }

        public class Command : IRequestHandler<Request, AssetDto>
        {
            private readonly AssetsDatabaseContext _database;
            private readonly IMapper _mapper;

            public Command(AssetsDatabaseContext database, IMapper mapper)
            {
                this._database = database;
                this._mapper = mapper;
            }

            public async Task<AssetDto> Handle(Request request, CancellationToken cancellationToken)
            {
                var asset = await _database.Assets.SingleAsync(e => e.Id == request.Id);
                
                return _mapper.Map<AssetDto>(asset);
            }
        }
    }
}