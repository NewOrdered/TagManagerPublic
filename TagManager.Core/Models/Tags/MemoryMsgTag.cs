﻿using System;

namespace TagManager.Core.Models
{
    [Serializable]
    public class MemoryMsgTag: ITag, IListItem
    {
        public Common Common { get; set; } = new Common();
        public Msg Msg { get; set; } = new Msg();
        public string Name
        {
            get
            { return Common.Name; }
            set
            { Common.Name = value; }
        }

        public override string ToString()
        {
            return "Memory Message";
        }

        public string Type
        {
            get
            { return this.ToString(); }
        }

        public string Comment
        {
            get { return Common.Comment; }
        }
    }
}