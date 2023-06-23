using Hubtel.Wallets.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Domain.Models
{
    public class Wallet:BaseModel
    {
        public int PymtTypeIdfk { get; set; }
        public int AccSchemeIdfk { get; set; }
        public string AccountNumber { get; set; }
        // Owner Repped by Phone Number
        public string PhoneNumber { get; set; }

        public ICollection<PaymentType> PaymentTypes { get; set; }
    }
}
