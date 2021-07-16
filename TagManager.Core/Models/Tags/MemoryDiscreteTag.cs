using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryDiscreteTag: ITag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Discrete Discrete { get; set; } = new Discrete();

        public string Name
        {
            get
            { return Common.Name; }

            set
            { Common.Name = value; }
        }

        public override string ToString()
        {
            return "Memory Discrete";
        }

        public string Type
        {
            get
            { return this.ToString(); }
        }

        public string Comment
        {
            get { return Common.Comment; }
        }

    }
}
