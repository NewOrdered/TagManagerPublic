using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public class SuperTagTemplate
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public SuperTagTemplate(string name)
        {
            Name = name;
        }

        public SuperTagTemplate()
        {

        }

        public List<IoDiscreteTag> IoDiscreteTags { get; private set; } = new List<IoDiscreteTag>();
        public List<IoIntegerTag> IoIntegerTags { get; private set; } = new List<IoIntegerTag>();
        public List<IoRealTag> IoRealTags { get; private set; } = new List<IoRealTag>();
        public List<IoMsgTag> IoMsgTags { get; private set; } = new List<IoMsgTag>();

        public List<MemoryDiscreteTag> MemoryDiscreteTags { get; private set; } = new List<MemoryDiscreteTag>();
        public List<MemoryIntegerTag> MemoryIntegerTags { get; private set; } = new List<MemoryIntegerTag>();
        public List<MemoryRealTag> MemoryRealTags { get; private set; } = new List<MemoryRealTag>();
        public List<MemoryMsgTag> MemoryMsgTags { get; private set; } = new List<MemoryMsgTag>();

        [XmlIgnore]
        public string DisplayName
        {
            get
            {
                return string.Format("{0}[{1}]", Name, MembersCount);
            }
        }

        [XmlIgnore]
        public int MembersCount
        {
            get
            {
                return IoDiscreteTags.Count + IoIntegerTags.Count + IoRealTags.Count + IoMsgTags.Count +
                       MemoryDiscreteTags.Count + MemoryIntegerTags.Count + MemoryRealTags.Count + MemoryMsgTags.Count;
            }
        }

        public SuperTag GenerateSuperTag(string superTagName)
        {
            SuperTag s = new SuperTag()
            {
                Name = superTagName,
                Members = GetMembers()
            };

            return s;
        }

        private List<IListItem> GetMembers()
        {
            List<IListItem> members = new List<IListItem>();

            foreach (var tag in IoDiscreteTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in IoIntegerTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in IoRealTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in IoMsgTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in MemoryDiscreteTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in MemoryIntegerTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in MemoryRealTags.Clone())
            {
                members.Add(tag as IListItem);
            }
            foreach (var tag in MemoryMsgTags.Clone())
            {
                members.Add(tag as IListItem);
            }


            return members;
        }

        public static SuperTagTemplate FromSuperTag(SuperTag superTag, string name)
        {
            SuperTagTemplate s = new SuperTagTemplate(name);

            foreach(var tag in superTag.Members.Clone())
            {
                switch(tag.GetType().Name)
                {
                    case nameof(IoDiscreteTag):
                        s.IoDiscreteTags.Add(tag as IoDiscreteTag);
                        break;
                    case nameof(IoIntegerTag):
                        s.IoIntegerTags.Add(tag as IoIntegerTag);
                        break;
                    case nameof(IoRealTag):
                        s.IoRealTags.Add(tag as IoRealTag);
                        break;
                    case nameof(IoMsgTag):
                        s.IoMsgTags.Add(tag as IoMsgTag);
                        break;

                    case nameof(MemoryDiscreteTag):
                        s.MemoryDiscreteTags.Add(tag as MemoryDiscreteTag);
                        break;
                    case nameof(MemoryIntegerTag):
                        s.MemoryIntegerTags.Add(tag as MemoryIntegerTag);
                        break;
                    case nameof(MemoryRealTag):
                        s.MemoryRealTags.Add(tag as MemoryRealTag);
                        break;
                    case nameof(MemoryMsgTag):
                        s.MemoryMsgTags.Add(tag as MemoryMsgTag);
                        break;
                }
            }

            return s;
        }
    }
}
