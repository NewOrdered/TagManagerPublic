using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public interface ITag
    { 
        Common Common { get; set; }
        string Type { get; }
        
    }
}
