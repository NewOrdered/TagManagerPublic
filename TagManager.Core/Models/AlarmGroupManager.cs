using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public class AlarmGroupManager
    {
        public List<AlarmGroup> Groups { get; private set; } = new List<AlarmGroup>();

        public AlarmGroupManager()
        {
            //root Alarm Group is always $System
            
            Groups.Add(new AlarmGroup() { Name = "$System" });
        }

        public AlarmGroup GetAlarmGroupByName(string alarmGroupName) //returns null if nothing found
        {
            AlarmGroup result = null;

            foreach(AlarmGroup group in Groups)
            {
                result = AlarmGroup.GetAlarmGroup(group, alarmGroupName);
            }
            return result;
        }

        public void AddGroup(AlarmGroup parentGroup, AlarmGroup group)
        {
            parentGroup.AlarmGroups.Add(group);
        }

        public void RemoveGroup(AlarmGroup parentGroup, AlarmGroup group)
        {
            parentGroup.AlarmGroups.Remove(group);
        }



    }
}
