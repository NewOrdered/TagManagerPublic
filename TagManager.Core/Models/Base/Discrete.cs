using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class Discrete
    {
        public string OnMessage { get; set; } = "ON";
        public string OffMessage { get; set; } = "OFF";
        public AlarmState AlarmState { get; set; } = AlarmState.None;
        public int AlarmPriority { get; set; } = 0;
        public bool InitialValue { get; set; } = false;

    }
}
