using System;


namespace TagManager.Core.Models
{
    [Serializable]
    public class Io
    {
        public string AccessName { get; set; }
        public string ItemName { get; set; }
        public bool ReadOnly { get; set; } = false;

    }
}
