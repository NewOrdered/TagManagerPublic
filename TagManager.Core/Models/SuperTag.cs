using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace TagManager.Core.Models
{
    [Serializable]
    public class SuperTag: IListItem
    {
        public string Name { get; set; }

        public List<IListItem> Members { get; set; } = new List<IListItem>();

        [XmlIgnore]
        public int MembersCount
        { 
            get

            { return Members.Count; }
        }

        [XmlIgnore]
        public int LongestMemberNameLength
        {
            get 
            {
                if(Members.Count == 0)
                 return 0; 
                return Members.Max(r => r.Name.Length);
            }
        }

        [XmlIgnore]
        public int MaxNameLength
        {
            get
            {
                return 32 - LongestMemberNameLength;
            }
        }

        public override string ToString()
        {
            return "SuperTag";
        }

        [XmlIgnore]
        public string Type
        {
            get
            { return string.Format("{0}[{1}]", this.ToString(), MembersCount); }
        }

        public string Comment
        {
            get { return string.Empty; }
        }

        public void AddMember(IListItem newMember)
        {
            IListItem member = Members.GetItemByName(newMember.Name);

            if (member != null)
            {
                Members.Remove(member);
            }

            Members.Add(newMember);
        }
    }
}
