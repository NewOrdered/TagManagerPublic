using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class Msg
    {
        public string InitialMessage { get; set; } = string.Empty;
        public int MaxLength { get; set; } = 131;
    }
}
