using System;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public class IoMsgTag: IIoTag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Io Io { get; set; } = new Io();
        public Msg Msg { get; set; } = new Msg();

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
            return "I/O Message";
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
