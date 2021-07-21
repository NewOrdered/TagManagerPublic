using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TagManager.Core.Models
{
    public class TagExporter
    {
        private List<IListItem> itemsForExport;

        private List<IoDiscreteTag> ioDiscreteTags = new List<IoDiscreteTag>();
        //private List<IoIntegerTag> ioIntegerTags = new List<IoIntegerTag>();
        private List<IoAnalogTag> ioIntegerTags = new List<IoAnalogTag>();
        //private List<IoRealTag> ioRealTags = new List<IoRealTag>();
        private List<IoAnalogTag> ioRealTags = new List<IoAnalogTag>();
        private List<IoMsgTag> ioMsgTags =  new List<IoMsgTag>();
       
        private List<MemoryDiscreteTag> memoryDiscreteTags = new List<MemoryDiscreteTag>();
        //private List<MemoryIntegerTag> memoryIntegerTags = new List<MemoryIntegerTag>();
        private List<MemoryAnalogTag> memoryIntegerTags = new List<MemoryAnalogTag>();
        //private List<MemoryRealTag> memoryRealTags = new List<MemoryRealTag>();
        private List<MemoryAnalogTag> memoryRealTags = new List<MemoryAnalogTag>();
        private List<MemoryMsgTag> memoryMsgTags = new List<MemoryMsgTag>();
        
        private List<IndirectTag> indirectDiscreteTags = new List<IndirectTag>();
        private List<IndirectTag> indirectAnalogTags = new List<IndirectTag>();
        private List<IndirectTag> indirectMsgTags = new List<IndirectTag>();

        private void AssignTagToList(ITag tag)
        {
            if (tag is IoDiscreteTag)
                ioDiscreteTags.Add(tag as IoDiscreteTag);
            if (tag is IoIntegerTag)
                ioIntegerTags.Add(tag as IoAnalogTag);
            if (tag is IoRealTag)
                ioRealTags.Add(tag as IoAnalogTag);
            if (tag is IoMsgTag)
                ioMsgTags.Add(tag as IoMsgTag);

            if (tag is MemoryDiscreteTag)
                memoryDiscreteTags.Add(tag as MemoryDiscreteTag);
            if (tag is MemoryIntegerTag)
                memoryIntegerTags.Add(tag as MemoryAnalogTag);
            if (tag is MemoryRealTag)
                memoryRealTags.Add(tag as MemoryAnalogTag);
            if (tag is MemoryMsgTag)
                memoryMsgTags.Add(tag as MemoryMsgTag);

            if (tag is IndirectDiscreteTag)
                indirectDiscreteTags.Add(tag as IndirectTag);
            if (tag is IndirectAnalogTag)
                indirectAnalogTags.Add(tag as IndirectTag);
            if (tag is IndirectMsgTag)
                indirectMsgTags.Add(tag as IndirectTag);

        }

        public void Export(List<IListItem> items, List<AlarmGroup> alarmGroups, List<AccessName> accessNames, string filePath)
        {
            PrepareTagsForExport(items);
            StringBuilder allLines = new StringBuilder();

            allLines.Append(GetImportModeLine());

            allLines.Append(Environment.NewLine);
            allLines.Append(GetAccessNameLines(accessNames));

            allLines.Append(Environment.NewLine);
            allLines.Append(GetAlarmGroupLines(alarmGroups));

            allLines.Append(Environment.NewLine);
            allLines.Append(GetMemoryDiscreteLines());

            allLines.Append(Environment.NewLine);
            allLines.Append(GetIoDiscreteLines());

            allLines.Append(Environment.NewLine);
            //allLines.Append(GetMemoryIntegerLines());
            allLines.Append(GetMemoryAnalogLines(":MemoryInt", memoryIntegerTags));

            allLines.Append(Environment.NewLine);
            //allLines.Append(GetIoIntegerLines());
            allLines.Append(GetIoAnalogLines(":IoInt", ioIntegerTags));

            allLines.Append(Environment.NewLine);
            //allLines.Append(GetMemoryRealLines());
            allLines.Append(GetMemoryAnalogLines(":MemoryReal", memoryRealTags));

            allLines.Append(Environment.NewLine);
            //allLines.Append(GetIoRealLines());
            allLines.Append(GetIoAnalogLines(":IoReal", ioRealTags));

            allLines.Append(Environment.NewLine);
            allLines.Append(GetMemoryMessageLines());

            allLines.Append(Environment.NewLine);
            allLines.Append(GetIoMessageLines());

            allLines.Append(Environment.NewLine);
            allLines.Append(GetIndirectLines(":IndirectDisc", indirectDiscreteTags));

            allLines.Append(Environment.NewLine);
            allLines.Append(GetIndirectLines(":IndirectAnalog", indirectAnalogTags));

            allLines.Append(Environment.NewLine);
            allLines.Append(GetIndirectLines(":IndirectMsg", indirectMsgTags));


            File.WriteAllText(filePath, allLines.ToString(), Encoding.GetEncoding("Windows-1251"));
        }

        private void ClearExportLists()
        {
            ioDiscreteTags.Clear();
            ioIntegerTags.Clear();
            ioRealTags.Clear();
            ioMsgTags.Clear();

            memoryDiscreteTags.Clear();
            memoryIntegerTags.Clear();
            memoryRealTags.Clear();
            memoryMsgTags.Clear();

            indirectDiscreteTags.Clear();
            indirectAnalogTags.Clear();
            indirectMsgTags.Clear();
        }

        private void PrepareTagsForExport(List<IListItem> items)
        {
            itemsForExport = items.Clone();

            ClearExportLists();

            foreach (IListItem item in itemsForExport)
            {
                if(item is ITag)
                {
                    AssignTagToList(item as ITag);
                }
                if (item is SuperTag)
                {
                    foreach (ITag member in (item as SuperTag).Members)
                    {
                        member.Common.Name = item.Name + "\\" + member.Common.Name;
                        AssignTagToList(member);
                    }
                }

            }
        }
        private StringBuilder GetIoDiscreteLines()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(":IODisc;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;InitialDisc;OffMsg;OnMsg;AlarmState;AlarmPri;DConversion;AccessName;ItemUseTagname;ItemName;ReadOnly;AlarmComment;AlarmAckModel;DSCAlarmDisable;DSCAlarmInhibitor;SymbolicName");
            foreach(IoDiscreteTag tag in ioDiscreteTags)
            {
                stringBuilder.AppendLine(GetIoDiscreteLine(tag));
            }

            return stringBuilder;
        }

        private StringBuilder GetMemoryDiscreteLines()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(":MemoryDisc;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;InitialDisc;OffMsg;OnMsg;AlarmState;AlarmPri;AlarmComment;AlarmAckModel;DSCAlarmDisable;DSCAlarmInhibitor;SymbolicName");
            foreach (MemoryDiscreteTag tag in memoryDiscreteTags)
            {
                stringBuilder.AppendLine(GetMemoryDiscreteLine(tag));
            }

            return stringBuilder;
        }

        private StringBuilder GetIoAnalogLines(string sectionHeader, List<IoAnalogTag> tags)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{sectionHeader};Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;RetentiveAlarmParameters;AlarmValueDeadband;AlarmDevDeadband;EngUnits;InitialValue;MinEU;MaxEU;Deadband;LogDeadband;LoLoAlarmState;LoLoAlarmValue;LoLoAlarmPri;LoAlarmState;LoAlarmValue;LoAlarmPri;HiAlarmState;HiAlarmValue;HiAlarmPri;HiHiAlarmState;HiHiAlarmValue;HiHiAlarmPri;MinorDevAlarmState;MinorDevAlarmValue;MinorDevAlarmPri;MajorDevAlarmState;MajorDevAlarmValue;MajorDevAlarmPri;DevTarget;ROCAlarmState;ROCAlarmValue;ROCAlarmPri;ROCTimeBase;MinRaw;MaxRaw;Conversion;AccessName;ItemUseTagname;ItemName;ReadOnly;AlarmComment;AlarmAckModel;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;SymbolicName");
            foreach (IoAnalogTag tag in tags)
            {
                stringBuilder.AppendLine(GetIoAnalogLine(tag));
            }

            return stringBuilder;
        }


        private StringBuilder GetMemoryAnalogLines(string sectionHeader, List<MemoryAnalogTag> tags)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{sectionHeader};Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;RetentiveAlarmParameters;AlarmValueDeadband;AlarmDevDeadband;EngUnits;InitialValue;MinValue;MaxValue;Deadband;LogDeadband;LoLoAlarmState;LoLoAlarmValue;LoLoAlarmPri;LoAlarmState;LoAlarmValue;LoAlarmPri;HiAlarmState;HiAlarmValue;HiAlarmPri;HiHiAlarmState;HiHiAlarmValue;HiHiAlarmPri;MinorDevAlarmState;MinorDevAlarmValue;MinorDevAlarmPri;MajorDevAlarmState;MajorDevAlarmValue;MajorDevAlarmPri;DevTarget;ROCAlarmState;ROCAlarmValue;ROCAlarmPri;ROCTimeBase;AlarmComment;AlarmAckModel;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;SymbolicName");
            foreach (MemoryAnalogTag tag in tags)
            {
                stringBuilder.AppendLine(GetMemoryAnalogLine(tag));
            }

            return stringBuilder;
        }

        private StringBuilder GetMemoryMessageLines()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(":MemoryMsg;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;MaxLength;InitialMessage;AlarmComment;SymbolicName");
            foreach (MemoryMsgTag tag in memoryMsgTags)
            {
                stringBuilder.AppendLine(GetMemoryMsgLine(tag));
            }

            return stringBuilder;
        }

        private StringBuilder GetIoMessageLines()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(":IOMsg;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;MaxLength;InitialMessage;AccessName;ItemUseTagname;ItemName;ReadOnly;AlarmComment;SymbolicName");
            foreach (IoMsgTag tag in ioMsgTags)
            {
                stringBuilder.AppendLine(GetIoMsgLine(tag));
            }

            return stringBuilder;
        }


        public StringBuilder GetIndirectLines(string sectionHeader, List<IndirectTag> tags)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{sectionHeader};Group;Comment;EventLogged;EventLoggingPriority;RetentiveValue;SymbolicName");
            foreach (IndirectTag tag in tags)
            {
                stringBuilder.AppendLine(GetIndirectLine(tag));
            }

            return stringBuilder;
        }


        private string GetIoDiscreteLine(IoDiscreteTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}"+ 
                               
                                "Off;" +                        //InitialDisc
                                 $"{GetDiscretePart(tag.Discrete)}" +
                                 "Direct;" +                    //Conversion
                                 $"{GetIoPart(tag.Io)}"+ 
                                 $"{tag.Common.AlarmComment.AddQuotes()};" +
                                 $"0;0;{string.Empty.AddQuotes()};{string.Empty.AddQuotes()}"); //0; 0; ""; ""


            //:IODisc;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;InitialDisc;OffMsg;OnMsg;AlarmState;AlarmPri;DConversion;AccessName;ItemUseTagname;ItemName;ReadOnly;AlarmComment;AlarmAckModel;DSCAlarmDisable;DSCAlarmInhibitor;SymbolicName
            //"LT_730_2\VHL";"Precleaning";"Авария. Очень высокий уровень";No;No;0;No;Off;"СНЯТ";"АВАРИЯ";On;20;Direct;"SODRU3_PREP";No;"DB111,X283.0";No;"Авария. Очень высокий уровень";0;0;"";""
        }

        private string GetMemoryDiscreteLine(MemoryDiscreteTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}" +
                               
                                "Off;" +                        //InitialDisc
                                 $"{GetDiscretePart(tag.Discrete)}" +
                                 $"{tag.Common.AlarmComment.AddQuotes()};" +
                                 $"0;0;{string.Empty.AddQuotes()};{string.Empty.AddQuotes()}"); //0; 0; ""; ""


            //:MemoryDisc;          Group;          Comment;                  Logged; EventLogged;EventLoggingPriority;RetentiveValue;InitialDisc;OffMsg;OnMsg;   AlarmState;AlarmPri;AlarmComment;AlarmAckModel;DSCAlarmDisable;DSCAlarmInhibitor;SymbolicName
            //"TT_78CIP\VHLAlarm";  "ZeroEffluents";"Температура в емк. 78CIP";No;    No;         0;                   No;            Off;       "СНЯТ";"АВАРИЯ";  On;       20;      "";          0;            0;              ""                ;""
        }

        private string GetIoMsgLine(IoMsgTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}" +
                               
                                 $"{GetMsgPart(tag.Msg)}" +
                                 $"{GetIoPart(tag.Io)}" +
                                 $"{tag.Common.AlarmComment.AddQuotes()};" +
                                 $"{string.Empty.AddQuotes()}"); // ""


            //:IOMsg;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;MaxLength;InitialMessage;AccessName;ItemUseTagname;ItemName;ReadOnly;AlarmComment;SymbolicName
        }

        private string GetMemoryMsgLine(MemoryMsgTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}" +
                               
                                $"{GetMsgPart(tag.Msg)}" +
                                $"{tag.Common.AlarmComment.AddQuotes()};" +
                                $"{string.Empty.AddQuotes()}"); // ""

            //:MemoryMsg;   Group;    Comment;Logged; EventLogged; EventLoggingPriority;RetentiveValue;MaxLength;InitialMessage;AlarmComment;SymbolicName
            //"FileNameIDX";"$System";"";     No;     No;           0;                  No;            131;       "";            "";           ""
        }

       
        private string GetIoAnalogLine(IoAnalogTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}" +
                                
                                "No;" +                         //RetentiveAlarmParameters
                                "0;" +                          //AlarmValueDeadband
                                "0;" +                          //AlarmDevDeadband
                                $"{GetAnalogPart(tag.Analog)}" +
                                "0;0;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;0;Off;0;1;Min;" +
                                $"{GetIoAnalogPart(tag.IoAnalog)}" + 
                                "Linear;" +                       //Conversion
                                $"{GetIoPart(tag.Io)}" +
                                $"{tag.Common.AlarmComment.AddQuotes()};" +
                                "0;0;0;0;0;0;0;0;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\""     //0;0;0;0;0;0;0;0;"";"";"";"";"";"";"";""
                                );


            //:IOInt;Group;Comment;Logged;EventLogged;EventLoggingPriority; RetentiveValue;RetentiveAlarmParameters;AlarmValueDeadband;AlarmDevDeadband;EngUnits;InitialValue;MinEU;MaxEU;      Deadband;LogDeadband;LoLoAlarmState;LoLoAlarmValue;LoLoAlarmPri;LoAlarmState;LoAlarmValue;LoAlarmPri;HiAlarmState;HiAlarmValue;HiAlarmPri;HiHiAlarmState;HiHiAlarmValue;HiHiAlarmPri;MinorDevAlarmState;MinorDevAlarmValue;MinorDevAlarmPri;MajorDevAlarmState;MajorDevAlarmValue;MajorDevAlarmPri;DevTarget;ROCAlarmState;ROCAlarmValue;ROCAlarmPri;ROCTimeBase;MinRaw;MaxRaw;Conversion;AccessName;  ItemUseTagname; ItemName;       ReadOnly;AlarmComment;  AlarmAckModel;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;SymbolicName
            //"R1619B\ST";"$System";"";No;No;               0;              No;            No;                      0;                 0;               "";      0;           -32768;32767;     0;0;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;0;Off;0;1;Min;                                                                                                                                                                                                                                                                                               -32768;32767; Linear;    "SODRU3_PREP";No;           "DB102,INT1166";  No;     "";            0;0;0;0;0;0;0;0;"";"";"";"";"";"";"";""
        }

        private string GetMemoryAnalogLine(MemoryAnalogTag tag)
        {
            return string.Format($"{GetCommonPart(tag.Common)}" +
                                
                                "No;" +                         //RetentiveAlarmParameters
                                "0;" +                          //AlarmValueDeadband
                                "0;" +                          //AlarmDevDeadband
                                $"{GetAnalogPart(tag.Analog)}" +
                                "0;0;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;0;Off;0;1;Min;" +
                                $"{tag.Common.AlarmComment.AddQuotes()};" +
                                "0;0;0;0;0;0;0;0;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\""     //0;0;0;0;0;0;0;0;"";"";"";"";"";"";"";""
                                );



            //:MemoryInt;Group;Comment;Logged;EventLogged;EventLoggingPriority;RetentiveValue;RetentiveAlarmParameters;AlarmValueDeadband;AlarmDevDeadband;EngUnits;InitialValue;MinValue;MaxValue;Deadband;LogDeadband;LoLoAlarmState;LoLoAlarmValue;LoLoAlarmPri;LoAlarmState;LoAlarmValue;LoAlarmPri;HiAlarmState;HiAlarmValue;HiAlarmPri;HiHiAlarmState;HiHiAlarmValue;HiHiAlarmPri;MinorDevAlarmState;MinorDevAlarmValue;MinorDevAlarmPri;MajorDevAlarmState;MajorDevAlarmValue;MajorDevAlarmPri;DevTarget;ROCAlarmState;ROCAlarmValue;ROCAlarmPri;ROCTimeBase;AlarmComment;AlarmAckModel;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;SymbolicName
            //"Mol_Route";"$System";"Направление слива мелассы";No;Yes;600;No;No;0;0;"";0;0;10;0;0;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;Off;0;1;0;Off;0;1;Min;"";0;0;0;0;0;0;0;0;"";"";"";"";"";"";"";""
        }


        private string GetIndirectLine(IndirectTag tag)
        {
            return string.Format($"{tag.Common.Name.AddQuotes()};" + 
                                 $"{tag.Common.Group.AddQuotes()};" +
                                 $"{tag.Common.Comment.AddQuotes()};"+
                                 $"{tag.Common.EventLogged.ToYesNoString()};" +
                                 $"{tag.Common.EventLoggingPriority};" +
                                 $"{tag.Common.RetentiveValue.ToYesNoString()};" +
                                 $"{tag.SymbolicName}"
                                 );
        }


        private string GetMsgPart(Msg msg)
        {
            return string.Format($"{msg.MaxLength};" +
                                 $"{msg.InitialMessage.AddQuotes()};");
        }

        private string GetCommonPart(Common common)
        {
            return string.Format($"{common.Name.AddQuotes()};" +
                                 $"{common.Group.AddQuotes()};" +
                                 $"{common.Comment.AddQuotes()};" +
                                 $"{common.Logged.ToYesNoString()};" +
                                 $"{common.EventLogged.ToYesNoString()};" +
                                 $"{common.EventLoggingPriority};" +
                                 $"{common.RetentiveValue.ToYesNoString()};");

        }

        private string GetDiscretePart(Discrete discrete)
        {
            return string.Format($"{discrete.OffMessage.AddQuotes()};" + 
                                 $"{discrete.OnMessage.AddQuotes()};" +
                                 $"{discrete.AlarmState};" + 
                                 $"{discrete.AlarmPriority};");
        }

        private string GetIoPart(Io io)
        {
            return string.Format($"{io.AccessName.AddQuotes()};"+
                                 "No;" +                            //ItemUseTagName
                                 $"{io.ItemName.AddQuotes()};" +
                                 $"{io.ReadOnly.ToYesNoString()};");
        }

        private string GetAnalogPart(Analog analog)
        {
            return string.Format($"{analog.EngUnits.AddQuotes()};" +
                                 "0;" +                            //InitialValue    
                                 $"{analog.MinEU};" +
                                 $"{analog.MaxEU};");
        }

        private string GetIoAnalogPart(IoAnalog ioAnalog)
        {
            return string.Format($"{ioAnalog.MinRaw};{ioAnalog.MaxRaw};");
        }


        private StringBuilder GetAlarmGroupLines(List<AlarmGroup> alarmGroups)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(":AlarmGroup;Group;Comment;EventLogged;EventLoggingPriority;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;DSCAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;DSCAlarmInhibitor");
            stringBuilder.AppendLine(string.Empty);
            foreach(AlarmGroup alarmGroup in alarmGroups)
            {
                AddAlarmGroupLines(alarmGroup, stringBuilder);
            }
            return stringBuilder;
        }


        private StringBuilder GetAccessNameLines(List<AccessName> accessNames)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(":IOAccess;Application;Topic;AdviseActive;DDEProtocol;SecApplication;SecTopic;SecAdviseActive;SecDDEProtocol;FailoverExpression;FailoverDeadband;DFOFlag;FBDFlag;FailbackDeadband");
            stringBuilder.AppendLine(string.Empty);
            foreach(AccessName accessName in accessNames)
            {
                stringBuilder.AppendLine(GetAccessNameLine(accessName));
            }

            return stringBuilder;
        }

        private void AddAlarmGroupLines(AlarmGroup alarmGroup, StringBuilder stringBuilder)
        {
            if(alarmGroup.Name != "$System")
                stringBuilder.AppendLine(GetAlarmGroupLine(alarmGroup));

            foreach(AlarmGroup childGroup in alarmGroup.AlarmGroups)
            {
                AddAlarmGroupLines(childGroup, stringBuilder);
            }
        }

        private string GetAccessNameLine(AccessName accessName)
        {
            return string.Format($"{accessName.Name.AddQuotes()};" +
                                 $"{accessName.ApplicationExportField};" +
                                 $"{accessName.Topic};" +
                                 $"{accessName.AdviseActiveItems.ToYesNoString()};" +
                                 $"{accessName.DDEProtocol};");


            //:IOAccess;Application;Topic;AdviseActive;DDEProtocol;SecApplication;SecTopic;SecAdviseActive;SecDDEProtocol;FailoverExpression;FailoverDeadband;DFOFlag;FBDFlag;FailbackDeadband;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
            //s7;       SIDir;      SS;   Yes;         No;          ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
        }

        private string GetAlarmGroupLine(AlarmGroup alarmGroup)
        {
            return string.Format($"{alarmGroup.Name.AddQuotes()};" +
                                 $"{alarmGroup.Group.AddQuotes()};" +
                                 $"{alarmGroup.Comment.AddQuotes()};" +
                                 $"{alarmGroup.EventLogged.ToYesNoString()};" + 
                                 $"{alarmGroup.EventLoggingPriority};" +
                                 "0;0;0;0;0;0;0;0;\"\";\"\";\"\";\"\";\"\";\"\";\"\";\"\"");

            //:AlarmGroup;   Group;   Comment;     EventLogged; EventLoggingPriority;LoLoAlarmDisable;LoAlarmDisable;HiAlarmDisable;HiHiAlarmDisable;MinDevAlarmDisable;MajDevAlarmDisable;RocAlarmDisable;DSCAlarmDisable;LoLoAlarmInhibitor;LoAlarmInhibitor;HiAlarmInhibitor;HiHiAlarmInhibitor;MinDevAlarmInhibitor;MajDevAlarmInhibitor;RocAlarmInhibitor;DSCAlarmInhibitor
            //"Preparation";"$System";"Подготовка";Yes;         999;                 "0;0;0;0;0;0;0;0;"";"";"";"";"";"";"";""
        }

        private string GetImportModeLine()
        {
            return ":mode=replace";
        }
        

    }
}
