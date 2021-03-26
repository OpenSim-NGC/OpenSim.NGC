using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using OpenSim.Data.Models;
using MediatR;

using OpenSim.GridServices.AssetService.Events.AssetDb;
using OpenSim.GridServices.AssetService.Models;
using System.Collections.Generic;

namespace AssetService.Controllers
{
    [Route("assets/")]
    [ApiController]
    public class AssetServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AssetServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: assets
        // Returns HTML message about who we are
        [HttpGet]
        public ActionResult GetIndex()
        {
            return base.Content(
                "<html><head><title>OpenSimulator NGC Assets Server</title></head><body><h1>OpenSimulator Assets Server</h1></body></html>", 
                "text/html");
        }

        // GET: assets/<asset-id>
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetDto>> GetAsset(string id)
        {
            var asset = await _mediator.Send(new GetAssetById.Request { Id = id });
            if (asset == null)
                return NotFound();

            return asset;
        }

        // POST: assets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Asset>> PostAsset(AssetDto asset)
        {
            return BadRequest();
        }

        // GET: assets/{id}/metadata
        [HttpHead("{id}")]
        [HttpGet("{id}/metadata")]
        public async Task<ActionResult<AssetDto>> GetAssetMetaData(string id)
        {
            var asset = await _mediator.Send(new GetAssetById.Request { Id = id });
            if (asset == null)
                return NotFound();

            return asset;
        }

        // GET: assets/{id}/data
        [HttpGet("{id}/data")]
        public async Task<ActionResult<AssetDto>> GetAssetData(string id)
        {
            var asset = await _mediator.Send(new GetAssetById.Request { Id = id });
            if (asset == null)
                return NotFound();

            return asset;
        }

        // PUT: assets/{id}
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> AssetUpdate(string id, Asset asset)
        {
            return BadRequest();
        }

        // DELETE: assets/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsset(string id)
        {
            return BadRequest();
        }

        // GET: /get_assets_exists
        [HttpGet("/get_assets_exist")]
        public async Task<ActionResult<AssetDto>> GetAssetsExist(List<string> ids)
        {
            if (ids is null)
            {
                throw new System.ArgumentNullException(nameof(ids));
            }

            return NotFound();
        }
    }
}
