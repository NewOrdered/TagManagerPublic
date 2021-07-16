using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public abstract class IoAnalogTag : IIoTag
    {
        public Common Common { get; set; } = new Common();
        public Analog Analog { get; set; } = new Analog();
        public Io Io { get; set; } = new Io();
        public IoAnalog IoAnalog { get; set; } = new IoAnalog();

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
