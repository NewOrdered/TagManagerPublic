using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IndirectAnalogTag: IndirectTag
    {
        public override string ToString()
        {
            return "Indirect Analog";
        }
    }
}
