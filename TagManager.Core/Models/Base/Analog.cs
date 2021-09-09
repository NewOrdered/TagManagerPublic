using System;

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
