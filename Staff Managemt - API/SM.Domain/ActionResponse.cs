using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMBA.Domain
{
    public class ActionResponse
    {
        public string? ErrorMessage { get; set; }
        public string? InfoMessage { get; set; }
        public bool IsSuccess { get; set; }
        public object? Data { get; set; }

    }
}
