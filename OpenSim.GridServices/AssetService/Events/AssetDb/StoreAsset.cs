using System;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;
using MediatR;

using OpenSim.Data.Models;
using OpenSim.GridServices.AssetService.Models;

namespace OpenSim.GridServices.AssetService.Events.AssetDb
{
    public class StoreAsset {
        public class Request : IRequest<string> 
        { 
            public Asset data { get; set; }
        }

        public class Command : IRequestHandler<Request, string>
        {
            private readonly AssetsDatabaseContext _database;
            private readonly IMapper _mapper;

            public Command(AssetsDatabaseContext database, IMapper mapper)
            {
                this._database = database;
                this._mapper = mapper;
            }

            public async Task<string> Handle(Request request, CancellationToken cancellationToken)
            {
                var asset = _mapper.Map<Asset>(request.data);
                throw new NotImplementedException();  
            }
        }
    }
}