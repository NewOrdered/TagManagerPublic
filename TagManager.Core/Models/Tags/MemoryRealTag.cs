using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryRealTag: MemoryAnalogTag, IListItem
    {
        public override string ToString()
        {
            return "Memory Real";
        }
    }
}
