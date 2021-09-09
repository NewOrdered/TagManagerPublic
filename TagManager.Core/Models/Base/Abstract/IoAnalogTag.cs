using System;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public abstract class IoAnalogTag : IIoTag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Analog Analog { get; set; } = new Analog();
        public Io Io { get; set; } = new Io();
        public IoAnalog IoAnalog { get; set; } = new IoAnalog();

        [XmlIgnore]
        public string Name
        {
            get
            { return Common.Name; }

            set
            { Common.Name = value; }
        }

        public string Type
        {
            get { return this.ToString(); }
        }

        public string Comment
        {
            get { return Common.Comment; }
        }
    }
}
