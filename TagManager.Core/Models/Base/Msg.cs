using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public class Msg
    {
        public string InitialMessage { get; set; } = string.Empty;
        public int MaxLength { get; set; } = 131;
    }
}
