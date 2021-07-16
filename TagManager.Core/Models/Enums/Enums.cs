using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public enum  AlarmState
    {
        None,
        Off,
        On
    }
    public enum SectionHeader
    {
        None,
        Other,
        IOAccess,
        AlarmGroup,
        IOInt,
        IODisc,
        IOReal,
        IOMsg,
        MemoryInt,
        MemoryDisc,
        MemoryReal,
        MemoryMsg
    }

    public enum DDEProtocol
    {
        No,
        Yes,
        MX
    }
}
