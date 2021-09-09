using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryIntegerTag: MemoryAnalogTag
    {
        public override string ToString()
        {
            return "Memory Integer";
        }

    }
}
