using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public abstract class MemoryAnalogTag : ITag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Analog Analog { get; set; } = new Analog();

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
