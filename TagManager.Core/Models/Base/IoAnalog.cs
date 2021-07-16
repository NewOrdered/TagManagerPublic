using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoAnalog
    {
        public decimal MinRaw { get; set; } = 0;
        public decimal MaxRaw { get; set; } = 100;
    }
}
