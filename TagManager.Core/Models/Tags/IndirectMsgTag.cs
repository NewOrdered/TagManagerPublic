using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IndirectMsgTag: IndirectTag, IListItem
    {
        public override string ToString()
        {
            return "Indirect Message";
        }
    }
}
