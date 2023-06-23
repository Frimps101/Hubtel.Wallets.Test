using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hubtel.Wallets.Application.Services
{
    // This class reps a generic response structure that can be used
    public class BaseResponse
    {
        [DefaultValue(0)]
        public int Id { get; set; } // If no value is explicitly set, default to 0
        [DefaultValue(false)]
        public bool Success { get; set; } // If no value is explicitly set, default to false
        public string Message { get; set; } // Reps a message associated with the response
        public int StatusCode { get; set; } // To indicate the outcome or status of an operation

        public IList<string> Errors { get; set; }
    }
}
