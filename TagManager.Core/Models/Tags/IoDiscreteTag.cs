using System;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoDiscreteTag: IIoTag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Discrete Discrete { get; set; } = new Discrete();
        public Io Io { get; set; } = new Io();

        [XmlIgnore]
        public string Name
        { 
            get
            { return Common.Name; }

            set
            { Common.Name = value; }
        }

        public override string ToString()
        {
            return "I/O Discrete";
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
