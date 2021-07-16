using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoRealTag: IoAnalogTag, IListItem
    {
        public override string ToString()
        {
            return "I/O Real";
        }

        //public string Type
        //{
        //    get
        //    { return this.ToString(); }
        //}
    }
}
