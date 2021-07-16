using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    [Serializable]
    public class SuperTag: IListItem
    {
        public string Name { get; set; }

        public List<IListItem> Members { get; set; } = new List<IListItem>();

        public int MembersCount
        { 
            get

            { return Members.Count; }
        }

        public override string ToString()
        {
            return "SuperTag";
        }

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
