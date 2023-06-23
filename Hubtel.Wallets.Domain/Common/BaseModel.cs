    using System;
using System.Collections.Generic;
using System.Text;

namespace Hubtel.Wallets.Domain.Common
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
