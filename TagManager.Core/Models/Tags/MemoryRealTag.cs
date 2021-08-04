using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryRealTag: MemoryAnalogTag
    {
        public override string ToString()
        {
            return "Memory Real";
        }
    }
}
