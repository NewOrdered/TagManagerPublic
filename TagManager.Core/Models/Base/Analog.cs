using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public class Analog
    {
        public decimal MinEU { get; set; } = 0;
        public decimal MaxEU { get; set; } = 100;
        public string EngUnits { get; set; } = "";
        public decimal InitialValue { get; set; } = 0;

    }
}
