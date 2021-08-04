

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
        Mode,
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
        MemoryMsg,
        IndirectDisc,
        IndirectAnalog,
        IndirectMsg
    }

    public enum DDEProtocol
    {
        No,
        Yes,
        MX
    }

    public enum DBLoadMode
    {
        Replace,
        Update,
        Ask,
        Ignore,
        Terminate,
        Test
    }
}
