using System;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public abstract class MemoryAnalogTag : ITag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Analog Analog { get; set; } = new Analog();

        [XmlIgnore]
        public string Name
        {
            get
            { return Common.Name; }

            set
            { Common.Name = value; }
        }

        public string Comment
        {
            get { return Common.Comment; }
        }
        public string Type
        {
            get { return this.ToString(); }
        }
    }
}
