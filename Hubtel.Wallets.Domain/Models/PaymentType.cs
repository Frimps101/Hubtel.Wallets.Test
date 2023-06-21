using Hubtel.Wallets.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Domain.Models
{
    public class PaymentType:BaseModel
    {
        public DateTime CreationDate { get; set; }
        public DateTime EditedDate { get; set; }
    }
}
