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
    public class GetMetaData {
        public class Request : IRequest<AssetDto> 
        { 
            public string Id { get; set; }
        }

        public class Command : IRequestHandler<Request, AssetDto>
        {
            private readonly AssetsDatabaseContext _database;

            public Command(AssetsDatabaseContext database)
            {
                this._database = database;
            }

            public async Task<AssetDto> Handle(Request request, CancellationToken cancellationToken)
            {
                var asset = await _database.Assets.SingleAsync(e => e.Id == request.Id);
                
                throw new NotImplementedException();
            }
        }
    }
}