using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        public async Task createWallet()
        {

        }

        public async Task GetWallet()
        {
            if (!ModelState.IsValid)
            {

            }
            
        }
    }
}
