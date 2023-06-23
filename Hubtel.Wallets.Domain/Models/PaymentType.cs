using Hubtel.Wallets.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Domain.Models
{
    public class PaymentType:BaseModel
    {
        public ICollection<AccountScheme> AccountSchemes { get; set; }
    }
}
