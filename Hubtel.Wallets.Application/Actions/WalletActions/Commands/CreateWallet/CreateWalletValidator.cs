using FluentValidation;
using Hubtel.Wallets.Application.DTOs.Wallet.Create;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Application.Actions.WalletActions.Commands.CreateWallet
{
    public class CreateWalletValidator:AbstractValidator<CreateWalletDto>
    {
        public CreateWalletValidator()
        {
            RuleFor(item => item.Name).NotEmpty().WithMessage("{PropertyName} must not be empty");
        }
    }
}
