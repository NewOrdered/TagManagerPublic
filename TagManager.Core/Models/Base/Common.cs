using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public class Common
    {
        public string Name { get; set; }
        public string Group { get; set; } = "$System";
        public string Comment { get; set; } = string.Empty;
        public bool Logged { get; set; } = false;
        public bool EventLogged { get; set; } = false;
        public int EventLoggingPriority { get; set; } = 0;
        public string AlarmComment { get; set; } = string.Empty;
        public bool RetentiveValue { get; set; } = false;

    }
}
