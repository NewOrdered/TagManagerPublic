using System;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    [Serializable]
    public abstract class IndirectTag : ITag, IListItem
    {
        public Common Common { get; set; } = new Common();

        public string SymbolicName { get; set; }

        [XmlIgnore]
        public string Name
        {
            get
            { return Common.Name; }

            set
            { Common.Name = value; }
        }

        public string Comment
        {
            get { return Common.Comment; }
        }
        public string Type
        {
            get { return ToString(); }
        }

        public static SuperTag IndirectFromSuperTag(SuperTag superTag, string name)
        {
            SuperTag newSuperTag = new SuperTag() { Name = name };

            foreach (ITag tag in superTag.Members)
            {
                switch(tag.GetType().Name)
                {
                    case nameof(IoDiscreteTag):
                    case nameof(MemoryDiscreteTag):
                        IndirectDiscreteTag indirectDiscrete = new IndirectDiscreteTag() { Name = tag.Common.Name };
                        newSuperTag.AddMember(indirectDiscrete);
                        break;

                    case nameof(IoIntegerTag):
                    case nameof(MemoryIntegerTag):
                    case nameof(IoRealTag):
                    case nameof(MemoryRealTag):
                        IndirectAnalogTag indirectAnalog = new IndirectAnalogTag() { Name = tag.Common.Name };
                        newSuperTag.AddMember(indirectAnalog);
                        break;

                    case nameof(IoMsgTag):
                    case nameof(MemoryMsgTag):
                        IndirectMsgTag indirectMsg = new IndirectMsgTag() { Name = tag.Common.Name };
                        newSuperTag.AddMember(indirectMsg);
                        break;
                }
            }

            return newSuperTag;
        }

    }
}
