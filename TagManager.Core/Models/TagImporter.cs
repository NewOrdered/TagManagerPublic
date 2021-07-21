using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace TagManager.Core.Models
{
    public class TagImporter
    {
        public TagImporter(ILogger logger)
        {
            this.logger = logger;
            
        }

        private List<string> otherLines = new List<string>();
        private List<IListItem> importedItems = new List<IListItem>();
        private List<AlarmGroup> importedAlarmGoups = new List<AlarmGroup>();
        private List<AccessName> importedAccessNames = new List<AccessName>();

        private SectionHeader sectionHeader;
        private ILogger logger;
        private int importWarningCount = 0;
        private int importErrorCount = 0;
        private int lineNumber = 0;

        private string[] lines;

        private string[] WriteSafeReadAllLines(string path)
        {
            using (var csv = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(csv, Encoding.GetEncoding("Windows-1251")))
            {
                List<string> file = new List<string>();
                while (!sr.EndOfStream)
                {
                    file.Add(sr.ReadLine());
                }

                return file.ToArray();
            }
        }

        private void LogLineInfo(string infoText)
        {
            logger.LogInfo(string.Format("Line: {0,6}\t{1}", lineNumber, infoText));
        }

        private void LogLineWarning(string warningText)
        {
            logger.LogWarning(string.Format("Line: {0,6}\tWarning\t{1}", lineNumber, warningText));
            importWarningCount ++;
        }

        private void LogLineError(string errorText)
        {
            logger.LogError(string.Format("Line: {0,6}\tError\t{1}", lineNumber, errorText));
            importErrorCount ++;
        }

        private void LogInfo(string infoText)
        {
            logger.LogInfo(infoText);
        }

        public ReturnResult Import(string filePath)
        {
            ReturnResult result = ReadFile(filePath);
            if(!result.Success)
            { 
                return result; 
            }

            result = ParseFile();
            return result;
        }

        private ReturnResult ReadFile(string filePath)
        {
            ReturnResult result = new ReturnResult();
            
            logger.LogInfo(string.Format("{0} Opening file: {1}", DateTime.Now, filePath));

            try
            {
                //Stopwatch stopWatch = new Stopwatch();
                //stopWatch.Start();
                lines = WriteSafeReadAllLines(filePath); //File.ReadAllLines(filePath, Encoding.GetEncoding("Windows-1251")); //
                //stopWatch.Stop();
                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                string message = string.Format("Opening file failed.\nException: {0}", ex.Message);

                logger.LogError(message);
                result.Success = false;
                result.Message = message;
                return result;
                //throw new Exception($"Failed to open file: {filePath}", ex);
            }

        }
        private ReturnResult ParseFile()
        {
            ReturnResult result = new ReturnResult();

            importedItems.Clear();
            importedAlarmGoups.Clear();
            importedAccessNames.Clear();

            importWarningCount = 0;
            importErrorCount = 0;
            
            sectionHeader = SectionHeader.None;

            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                lineNumber = i + 1;

                if (IsSectionHeader(lines[i]))
                {
                    sectionHeader = GetSectionHeader(lines[i]);
                    LogLineInfo("Parsing section: " + sectionHeader.ToString());
                }
                else
                {
                    if (!IsEmpty(lines[i]))
                    {
                        string[] fields = lines[i].Split(';');
                        fields.TrimDoubleQuotes();

                        if(fields.IsArrayOfEmptyStrings())
                        {
                            LogLineInfo("Line has only empty values. Skipping line.");
                            continue;
                        }

                        switch (sectionHeader)
                        {
                            

                            case SectionHeader.IOAccess:
                                ParseAccessNameFields(fields);
                                break;

                            case SectionHeader.AlarmGroup:
                                ParseAlarmGroupFields(fields);
                                break;

                            case SectionHeader.IODisc:
                                ParseIoDiscreteFields(fields);
                                break;

                            case SectionHeader.IOInt:
                                ParseIoIntegerFields(fields);
                                break;

                            case SectionHeader.IOReal:
                                ParseIoRealFields(fields);
                                break;

                            case SectionHeader.IOMsg:
                                ParseIoMsgFields(fields);
                                break;

                            case SectionHeader.MemoryDisc:
                                ParseMemoryDiscreteFields(fields);
                                break;

                            case SectionHeader.MemoryInt:
                                ParseMemoryIntegerFields(fields);
                                break;

                            case SectionHeader.MemoryReal:
                                ParseMemoryRealFields(fields);
                                break;

                            case SectionHeader.MemoryMsg:
                                ParseMemoryMsgFields(fields);
                                break;

                            case SectionHeader.IndirectDisc:
                                ParseIndirectDiscreteFields(fields);
                                break;

                            case SectionHeader.IndirectAnalog:
                                ParseIndirectAnalogFields(fields);
                                break;

                            case SectionHeader.IndirectMsg:
                                ParseIndirectMsgFields(fields);
                                break;

                            case SectionHeader.None:
                                break;

                            case SectionHeader.Other:
                                otherLines.Add(lines[i]);
                                break;

                        }
                    }
                }
            }
            //stopWatch.Stop();
            string importResults = string.Format("Import finished. {0} error(s), {1} warnings", importErrorCount, importWarningCount);
            LogInfo(string.Format("{0}\t{1}", DateTime.Now, importResults));
            result.Success = true;
            result.Message = importResults;
            return result;
        }

        public List<IListItem> GetImportedItems()
        {
            return importedItems;
        }

        public List<AlarmGroup> GetAlarmGroups()
        {
            return importedAlarmGoups;
        }

        public List<AccessName> GetAccessNames()
        {
            return importedAccessNames;
        }

        private void ParseIoIntegerFields(string[] fields)
        {
            if (fields.Length >= 63)
            {
                IoIntegerTag tag = GetIoIntegerTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid I/O Integer tag record. Skipping line.");
                //line is not valid IO Integer tag record, log and skip
            }
        }

        private void ParseIoDiscreteFields(string[] fields)
        {
            if (fields.Length >= 22)
            {
                IoDiscreteTag tag = GetIoDiscreteTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid I/O Discrete tag record. Skipping line.");
                //line is not valid IO Disc tag record, log and skip
            }
        }

        private void ParseIoRealFields(string[] fields)
        {
            if (fields.Length >= 63) //63 total fields in line
            {
                IoRealTag tag = GetIoRealTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid I/O Real tag record. Skipping line.");
                //line is not valid IO Real tag record, log and skip
            }
        }

        private void ParseIoMsgFields(string[] fields)
        {
            if (fields.Length >= 15)
            {
                IoMsgTag tag = GetIoMsgTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid I/O Message tag record. Skipping line.");
                //line is not valid IO Message tag record, log and skip
            }
        }

        private void ParseMemoryDiscreteFields(string[] fields)
        {
            if (fields.Length >= 17)
            {
                MemoryDiscreteTag tag = GetMemoryDiscreteTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Memory Discrete tag record. Skipping line.");
                //line is not valid Memory Discrete tag record, log and skip
            }
        }

        private void ParseMemoryIntegerFields(string[] fields)
        {
            if (fields.Length >= 56)
            {
                MemoryIntegerTag tag = GetMemoryIntegerTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Memory Integer tag record. Skipping line.");
                //line is not valid Memory Integer tag record, log and skip
            }
        }

        private void ParseMemoryRealFields(string[] fields)
        {
            if (fields.Length >= 56)
            {
                MemoryRealTag tag = GetMemoryRealTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Memory Real tag record. Skipping line.");
                //line is not valid Memory Real tag record, log and skip
            }
        }

        private void ParseMemoryMsgFields(string[] fields)
        {
            if (fields.Length >= 11)
            {
                MemoryMsgTag tag = GetMemoryMsgTag(fields);

                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Memory Message tag record. Skipping line.");
                //line is not valid Memory Message tag record, log and skip
            }
        }

        private void ParseIndirectDiscreteFields(string[] fields)
        {
            if(fields.Length >=6)
            {
                //IndirectDiscreteTag tag = GetIndirectDiscreteTag(fields);
                IndirectDiscreteTag tag = new IndirectDiscreteTag();
                GetIndirectTag(fields, tag);
                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Indirect tag record. Skipping line.");
                //line is not valid Indirect tag record, log and skip
            }
        }

        private void ParseIndirectAnalogFields(string[] fields)
        {
            if (fields.Length >= 6)
            {
                //IndirectAnalogTag tag = GetIndirectAnalogTag(fields);
                IndirectAnalogTag tag = new IndirectAnalogTag();
                GetIndirectTag(fields, tag);
                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Indirect tag record. Skipping line.");
                //line is not valid Indirect tag record, log and skip
            }
        }

        private void ParseIndirectMsgFields(string[] fields)
        {
            if (fields.Length >= 6)
            {
                //IndirectMsgTag tag = GetIndirectMsgTag(fields);
                IndirectMsgTag tag = new IndirectMsgTag();
                GetIndirectTag(fields, tag);
                AddItem(tag, fields[0]);
            }
            else
            {
                LogLineError("Line is not a valid Indirect tag record. Skipping line.");
                //line is not valid Indirect tag record, log and skip
            }
        }

        private void AddItem(IListItem item, string itemName)
        {
            string newItemName = itemName;

            //in case of item is to be part a SuperTag (name contains "\")
            //
            //

            if (IsNameSupertag(itemName)) 
            {
                newItemName = GetSuperTagName(itemName);
                var oldItem = importedItems.GetItemByName(newItemName);
                SuperTag superTag;
                
                
                if(oldItem == null)
                {
                    superTag = new SuperTag() { Name = newItemName };
                    importedItems.Add(superTag);
                }
                else 
                {
                    if (oldItem is ITag)
                    {
                        superTag = new SuperTag() { Name = newItemName };
                        importedItems.Remove(oldItem);
                        importedItems.Add(superTag);
                    }
                    else
                    {
                        superTag = oldItem as SuperTag;
                    }
                }
                
                item.Name = GetTagName(itemName); //set Member Tag name with what comes after "\"
                superTag.AddMember(item);
         
            }
            else //in case of item is a normal Tag
            {
                var oldItem = importedItems.GetItemByName(itemName);
                if (oldItem != null)
                {
                    importedItems.Remove(oldItem);
                }

                importedItems.Add(item);
            }
        }

        private void ParseAlarmGroupFields(string[] fields)
        {
            if(fields.Length >= 13)
            {
                AlarmGroup group = GetAlarmGroup(fields);

                if (ParentGroupExists(group.Group))
                {
                    AddAlarmGroup(group);
                }
                else
                {
                    LogLineError($"Parent Alarm Group '{group.Group}' not found. Skipping line.");
                }
            }
            else
            {
                LogLineError("Line is not a valid Alarm Group record. Skipping line.");
                //line is not valid Alarm Group record, log and skip
            }
        }

        private void ParseAccessNameFields(string[] fields)
        {
            if(fields.Length > 4)
            {
                AccessName accessName = GetAccessName(fields);
                AddAccessName(accessName);
            }
            else
            {
                LogLineError("Line is not a valid Access Name record. Skipping line.");
            }
        }

        private bool ParentGroupExists(string parentGroupName)
        {
            if (parentGroupName == "$System")
                return true;

            foreach(AlarmGroup group in importedAlarmGoups)
            {
                if (group.Name == parentGroupName)
                    return true;
            }
            return false;
        }

        private AlarmGroup GetAlarmGroup(string[] fields)
        {
            return new AlarmGroup()
            {
                Name = fields[0],
                Group = fields[1],
                Comment = fields[2],
                EventLogged = GetBoolFromYesNoString(fields[3]),
                EventLoggingPriority = GetInt(fields[4])
            };
        }

        private AccessName GetAccessName(string[] fields)
        {

            string nodeName;
            string application;
            
            try
            {
                Uri nodeApplication = new Uri(fields[1]);
                
                if (nodeApplication.IsUnc && nodeApplication.Segments.Length > 1)
                {
                    nodeName = nodeApplication.Host;
                    application = nodeApplication.Segments[1];
                }
                else
                {
                    nodeName = string.Empty;
                    application = fields[1];
                }
            }
            catch(UriFormatException)
            {
                nodeName = string.Empty;
                application = fields[1];
            }

            
            string protocol = fields[4];
            DDEProtocol parsedDDEProtocol = DDEProtocol.No;
            try
            {
                DDEProtocol ddeProtocol = (DDEProtocol)Enum.Parse(typeof(DDEProtocol), protocol);
                if(Enum.IsDefined(typeof(DDEProtocol), ddeProtocol))
                {
                    parsedDDEProtocol = ddeProtocol;
                }
                else 
                {
                    parsedDDEProtocol = DDEProtocol.No;
                    LogLineWarning(string.Format("'{0}' is not a valid Protocol string. Using default value 'No'", protocol));
                }
            }

            catch(ArgumentException)
            {
                LogLineWarning(string.Format("'{0}' is not a valid Protocol string. Using default value 'No'", protocol));
            }

            return new AccessName()
            {
                Name = fields[0],
                NodeName = nodeName,
                Application = application,
                Topic = fields[2],
                AdviseActiveItems = GetBoolFromYesNoString(fields[3]),
                DDEProtocol = parsedDDEProtocol
            };
        }

        private void AddAlarmGroup(AlarmGroup newAlarmGroup)
        {
            importedAlarmGoups.Add(newAlarmGroup);
        }

        private void AddAccessName(AccessName newAccessName)
        {
            importedAccessNames.Add(newAccessName);
        }

        private IoDiscreteTag GetIoDiscreteTag(string[] fields)
        {
            return new IoDiscreteTag()
            {
                Common = GetCommon(fields, fields[17]), // 17 - Alarm Comment position in I/O Discrete tag line
                Discrete = GetDiscrete(fields),
                Io = GetIo(fields[13], fields[15], fields[16])
            };
        }

        private IoIntegerTag GetIoIntegerTag(string[] fields)
        {
            return new IoIntegerTag()
            {
                Common = GetCommon(fields, fields[46]), // 46 - Alarm Comment position in I/O Integer tag line
                Io = GetIo(fields[42], fields[44], fields[45]),
                Analog = GetAnalog(fields),
                IoAnalog = GetIoAnalog(fields)
            };
        }

        private IoRealTag GetIoRealTag(string[] fields)
        {
            return new IoRealTag()
            {
                Common = GetCommon(fields, fields[46]), // 46 - Alarm Comment position in I/O Real tag line
                Io = GetIo(fields[42], fields[44], fields[45]),
                Analog = GetAnalog(fields),
                IoAnalog = GetIoAnalog(fields)
            };
        }

        

        private IoMsgTag GetIoMsgTag(string[] fields)
        {
            return new IoMsgTag()
            {
                Common = GetCommon(fields, fields[13]), // 13 - Alarm Comment position in I/O Msg tag line
                Io = GetIo(fields[9], fields[11], fields[12]),
                Msg = GetMsg(fields)
            };

        }

        private MemoryDiscreteTag GetMemoryDiscreteTag(string[] fields)
        {
            return new MemoryDiscreteTag()
            {
                Common = GetCommon(fields, fields[12]), // 12 - Alarm Comment position in Memory Discrete tag line
                Discrete = GetDiscrete(fields)
            };
        }

        private MemoryIntegerTag GetMemoryIntegerTag(string[] fields)
        {
            return new MemoryIntegerTag()
            {
                Common = GetCommon(fields, fields[39]), // 39 - Alarm Comment position in Memory Integer tag line
                Analog = GetAnalog(fields)
            };
        }

        private MemoryRealTag GetMemoryRealTag(string[] fields)
        {
            return new MemoryRealTag()
            {
                Common = GetCommon(fields, fields[39]), // 39 - Alarm Comment position in Memory Real tag line
                Analog = GetAnalog(fields)
            };
        }

        private MemoryMsgTag GetMemoryMsgTag(string[] fields)
        {
            return new MemoryMsgTag()
            {
                Common = GetCommon(fields, fields[9]), // 9 - Alarm Comment position in Memory Message tag line
                Msg = GetMsg(fields)
            };
        }

        //private IndirectDiscreteTag GetIndirectDiscreteTag(string[] fields)
        //{
        //    IndirectDiscreteTag indirect = new IndirectDiscreteTag();

        //    indirect.Common.Name = fields[0];
        //    indirect.Common.Group = fields[1];
        //    indirect.Common.Comment = fields[2];
        //    indirect.Common.EventLogged = GetBoolFromYesNoString(fields[3]);
        //    indirect.Common.EventLoggingPriority = GetInt(fields[4]);
        //    indirect.Common.RetentiveValue = GetBoolFromYesNoString(fields[5]);
        //    indirect.SymbolicName = fields[6];


        //    return indirect;
        //}

        //private IndirectAnalogTag GetIndirectAnalogTag(string[] fields)
        //{
        //    IndirectAnalogTag indirect = new IndirectAnalogTag();

        //    indirect.Common.Name = fields[0];
        //    indirect.Common.Group = fields[1];
        //    indirect.Common.Comment = fields[2];
        //    indirect.Common.EventLogged = GetBoolFromYesNoString(fields[3]);
        //    indirect.Common.EventLoggingPriority = GetInt(fields[4]);
        //    indirect.Common.RetentiveValue = GetBoolFromYesNoString(fields[5]);
        //    indirect.SymbolicName = fields[6];


        //    return indirect;
        //}

        //private IndirectMsgTag GetIndirectMsgTag(string[] fields)
        //{
        //    IndirectMsgTag indirect = new IndirectMsgTag();

        //    indirect.Common.Name = fields[0];
        //    indirect.Common.Group = fields[1];
        //    indirect.Common.Comment = fields[2];
        //    indirect.Common.EventLogged = GetBoolFromYesNoString(fields[3]);
        //    indirect.Common.EventLoggingPriority = GetInt(fields[4]);
        //    indirect.Common.RetentiveValue = GetBoolFromYesNoString(fields[5]);
        //    indirect.SymbolicName = fields[6];

        //    return indirect;
        //}

        private void GetIndirectTag(string[] fields, IndirectTag indirect)
        {
            string group = fields[1];
            if (string.IsNullOrWhiteSpace(group))
            {
                group = "$System";
            }

            indirect.Common.Name = fields[0];
            indirect.Common.Group = group; // fields[1];
            indirect.Common.Comment = fields[2];
            indirect.Common.EventLogged = GetBoolFromYesNoString(fields[3]);
            indirect.Common.EventLoggingPriority = GetInt(fields[4]);
            indirect.Common.RetentiveValue = GetBoolFromYesNoString(fields[5]);
            indirect.SymbolicName = fields[6];

            
        }

        private Common GetCommon(string [] fields, string alarmComment)
        {
            string group = fields[1];
            if(string.IsNullOrWhiteSpace(group))
            {
                group = "$System";
            }

            return new Common()
            {
                Name = fields[0],
                Group = group, //fields[1],
                Comment = fields[2],
                Logged = GetBoolFromYesNoString(fields[3]),
                EventLogged = GetBoolFromYesNoString(fields[4]),
                EventLoggingPriority = GetInt(fields[5]),
                RetentiveValue = GetBoolFromYesNoString(fields[6]),
                AlarmComment = alarmComment
            };
        }
        private Discrete GetDiscrete(string [] fields)
        {
            return new Discrete()
            {
                OffMessage = fields[8],
                OnMessage = fields[9],
                AlarmState = GetAlarmStateFromString(fields[10]),
                AlarmPriority = GetInt(fields[11])
            };
        }
        private Io GetIo(string accessName, string itemName, string readOnlystring)
        {
            return new Io()
            {
                AccessName = accessName,
                ItemName = itemName,
                ReadOnly = GetBoolFromYesNoString(readOnlystring)
            };
        }
        private Analog GetAnalog(string[] fields)
        {
            return new Analog()
            {
                EngUnits = fields[10],
                MinEU = GetDecimal(fields[12]),
                MaxEU = GetDecimal(fields[13])
            };
        }
        private IoAnalog GetIoAnalog(string[] fields)
        {
            return new IoAnalog()
            {
                MinRaw = GetDecimal(fields[39]),
                MaxRaw = GetDecimal(fields[40])
            };
        }
        private Msg GetMsg(string[] fields)
        {
            return new Msg()
            {
                InitialMessage = fields[8],
                MaxLength = GetInt(fields[7])
            };
        }

        private bool IsSectionHeader(string line)
        {
            return line.StartsWith(":");
        }

        private bool IsEmpty(string line)
        {
            return string.IsNullOrWhiteSpace(line);
        }

        private SectionHeader GetSectionHeader(string line)
        {
            SectionHeader result;

            string[] headers = line.Split(';');
            switch (headers[0])
            {

                case ":AlarmGroup":
                    result = SectionHeader.AlarmGroup;
                    break;

                case ":IOAccess":
                    result = SectionHeader.IOAccess;
                    break;

                case ":IOInt":
                    result = SectionHeader.IOInt;
                    break;

                case ":IODisc":
                    result = SectionHeader.IODisc;
                    break;

                case ":IOReal":
                    result = SectionHeader.IOReal;
                    break;

                case ":IOMsg":
                    result = SectionHeader.IOMsg;
                    break;

                case ":MemoryDisc":
                    result = SectionHeader.MemoryDisc;
                    break;

                case ":MemoryInt":
                    result = SectionHeader.MemoryInt;
                    break;

                case ":MemoryReal":
                    result = SectionHeader.MemoryReal;
                    break;

                case ":MemoryMsg":
                    result = SectionHeader.MemoryMsg;
                    break;

                case ":IndirectDisc":
                    result = SectionHeader.IndirectDisc;
                    break;

                case ":IndirectAnalog":
                    result = SectionHeader.IndirectAnalog;
                    break;

                case ":IndirectMsg":
                    result = SectionHeader.IndirectMsg;
                    break;

                case ":":
                    result = SectionHeader.Other;
                    break;

                default:
                    result = SectionHeader.None;
                    break;

            }
            return result;
        }

        private bool IsNameSupertag(string name)
        {
            return name.Contains(@"\");
        }

        private bool GetBoolFromYesNoString(string yesNoString)
        {
            if (yesNoString.Equals("yes", StringComparison.OrdinalIgnoreCase)) return true;
            if (yesNoString.Equals("no", StringComparison.OrdinalIgnoreCase)) return false;

            LogLineWarning(string.Format("'{0}' is not a valid Yes/No string. Using default value 'false'\\'No'", yesNoString));
            return false;
        }

        private AlarmState GetAlarmStateFromString(string alarmStateString)
        {
            if(Enum.TryParse(alarmStateString, true, out AlarmState result))
            {
                return result;
            }
            else
            {
                LogLineWarning(string.Format("'{0}' is not a valid Alarm State string. Using default value 'None'", alarmStateString));
                return AlarmState.None;
            }
        }

        private int GetInt(string intString)
        {
            if(Int32.TryParse(intString, out int result))
            {
                return result;
            }
            else
            {
                LogLineWarning(string.Format("'{0}' is not a valid integer number. Using default value '0'", intString));
                return 0;
            }
        }

        private decimal GetDecimal(string decimalString)
        {
            
            if (Double.TryParse(decimalString, NumberStyles.Any, CultureInfo.InvariantCulture,  out double result))
            {
                if (result >= (double)Decimal.MaxValue)
                {
                    LogLineWarning(string.Format("'{0}' is greater than maximum decimal value. Using maximum value '{1}'", decimalString, Decimal.MaxValue));
                    return Decimal.MaxValue;
                }
                if (result <= (double)Decimal.MinValue)
                {
                    LogLineWarning(string.Format("'{0}' is less than minimum decimal value. Using minimum value '{1}'", decimalString, Decimal.MinValue));
                    return Decimal.MinValue;
                }

                return (decimal)result;
            }
            else
            {
                LogLineWarning(string.Format("'{0}' is not a valid floating point number. Using default value '0'", decimalString));
                return Decimal.Zero;
            }
        }

        private string GetSuperTagName(string name)
        {
            return name.Substring(0, name.IndexOf(@"\"));
        }

        private string GetTagName(string name)
        {
            return name.Substring(name.IndexOf(@"\") + 1);
        }

        
    }
}
