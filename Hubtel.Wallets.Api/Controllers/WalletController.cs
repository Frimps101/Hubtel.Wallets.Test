
using Hubtel.Wallets.Application.Actions.WalletActions.Commands.CreateWallet;
using Hubtel.Wallets.Application.DTOs.Wallet.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WalletController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateWallet([FromBody] CreateWalletDto dto)
        {
            await _mediator.Send(new CreateWalletCommand { Dto = dto });

            return NoContent();
        }
        
        /*
        public async Task<IActionResult> GetAllWallets()
        {
            if (!ModelState.IsValid{
                return BadRequest(ModelState);
            }

            var result = await _mediator.Send(new GetAllWalletsQuery { });
            return Ok(result);
        }
        */
    }
}
