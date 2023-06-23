using Hubtel.Wallets.Application.DTOs.Wallet.Create;
using Hubtel.Wallets.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Application.Actions.WalletActions.Commands.CreateWallet
{
    public class CreateWalletCommand:IRequest<BaseResponse>
    {
        public CreateWalletDto Dto { get; set; }
    }
}
