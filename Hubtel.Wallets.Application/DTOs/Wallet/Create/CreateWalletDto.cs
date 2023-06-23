using Hubtel.Wallets.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Application.DTOs.Wallet.Create
{
    public class CreateWalletDto: CommonDto
    {
        public int PymtTypeIdfk { get; set; }
        public int AccSchemeIdfk { get; set; }
        public string AccountNumber { get; set; }
        public string AccountScheme { get; set; }
        public string PhoneNumber { get; set; }

    }
}
