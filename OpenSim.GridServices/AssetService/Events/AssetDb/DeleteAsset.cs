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
    public class DeleteAsset {
        public class Request : IRequest<bool> 
        { 
            public string Id { get; set; }
        }

        public class Command : IRequestHandler<Request, bool>
        {
            private readonly AssetsDatabaseContext _database;

            public Command(AssetsDatabaseContext database)
            {
                this._database = database;
            }

            public async Task<bool> Handle(Request request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
                //return await _database.Assets.AnyAsync(e => e.Id == request.Id);
            }
        }
    }
}