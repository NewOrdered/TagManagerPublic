using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoIntegerTag: IoAnalogTag, IListItem
    {
        public override string ToString()
        {
            return "I/O Integer";
        }

        //public string Type
        //{
        //    get
        //    { return this.ToString(); }
        //}
    }
}
