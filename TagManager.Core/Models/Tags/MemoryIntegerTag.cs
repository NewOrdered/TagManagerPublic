using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryIntegerTag: MemoryAnalogTag//, IListItem
    {
        public override string ToString()
        {
            return "Memory Integer";
        }

    }
}
