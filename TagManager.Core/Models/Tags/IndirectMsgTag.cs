using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IndirectMsgTag: IndirectTag
    {
        public override string ToString()
        {
            return "Indirect Message";
        }
    }
}
