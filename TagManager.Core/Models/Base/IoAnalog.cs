using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoAnalog
    {
        public decimal MinRaw { get; set; } = 0;
        public decimal MaxRaw { get; set; } = 100;
    }
}
