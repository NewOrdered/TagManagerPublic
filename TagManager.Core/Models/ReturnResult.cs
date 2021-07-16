using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public class ReturnResult
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public object ReturnObject { get; set; } = null;
    }
}
