using Hubtel.Wallets.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Domain.Models
{
    public class AccountScheme:BaseModel
    {
        public int PymtTypeIdfk { get; set; }

        public ICollection<PaymentType> PaymentTypes { get; set; }
    }
}
