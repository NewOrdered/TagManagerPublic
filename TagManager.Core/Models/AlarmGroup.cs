using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public class AlarmGroup
    {
        public string Name { get; set; }

        public List<AlarmGroup> AlarmGroups { get; private set; } = new List<AlarmGroup>();

        public string Group { get; set; } = "$System";

        public string Comment { get; set; } = string.Empty;

        public bool EventLogged { get; set; } = true;

        public int EventLoggingPriority { get; set; } = 999;

        public static AlarmGroup GetAlarmGroup(AlarmGroup alarmGroup, string name)
        {
            if (alarmGroup == null)
                return null;

            if (alarmGroup.Name == name)
                return alarmGroup;

            foreach (var child in alarmGroup.AlarmGroups)
            {
                var found = GetAlarmGroup(child, name);
                if (found != null)
                    return found;
            }

            return null;
        }

        public AlarmGroup GetChildGroupByName(string name)
        {
            foreach(AlarmGroup group in AlarmGroups)
            {
                if(group.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return group;
                }
            }
            return null;
        }

    }
}
