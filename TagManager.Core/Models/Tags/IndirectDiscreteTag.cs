using System;


namespace TagManager.Core.Models
{
    [Serializable]
    public class IndirectDiscreteTag: IndirectTag, IListItem
    {
        public override string ToString()
        {
            return "Indirect Discrete";
        }
    }
}
