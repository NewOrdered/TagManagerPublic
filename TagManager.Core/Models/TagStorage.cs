using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TagManager.Core.Models
{
    public class TagStorage
    {
        private TagImporter tagImporter;
        private TagExporter tagExporter;
        private AlarmGroupManager alarmGroupManager;
        private AccessNameManager accessNameManager;
        
        public TagStorage(TagImporter tagImporter, TagExporter tagExporter, AlarmGroupManager alarmGroupManager, AccessNameManager accessNameManager)
        {
            this.tagImporter = tagImporter;
            this.tagExporter = tagExporter;
            this.alarmGroupManager = alarmGroupManager;
            this.accessNameManager = accessNameManager;
        }
        public List<AlarmGroup> AlarmGroups
        {
            get { return alarmGroupManager.Groups; }
        }

        public List<AccessName> AccessNames
        {
            get { return accessNameManager.AccessNames; }
        }

        public AlarmGroupManager AlarmGroupManager
        {
            get { return alarmGroupManager; }
        }

        public AccessNameManager AccessNameManager
        {
            get { return accessNameManager; }
        }
        
        public List<IListItem> AllItems { get; private set; } = new List<IListItem>();

        public int ItemCount
        {
            get { return AllItems.Count; }
        }

        public IListItem Copy(IListItem original)
        {
            IListItem newItem = original.Clone();

            newItem.Name = NewNameForDuplicate(original.Name);

            return newItem;
        }

        private string NewNameForDuplicate(string originalName)
        {
            List<string> numbers = new List<string>();

            foreach(Match m in Regex.Matches(originalName, @"\d+"))
            {
                numbers.Add(m.Value.ToString().TrimStart('0'));
            }


            if (numbers.Count > 0)
            {
                string lastNumber = numbers[numbers.Count - 1];

                int newNumber = int.Parse(numbers[numbers.Count - 1]);

                //int index = originalName.LastIndexOf(lastNumber);

                string newName = string.Copy(originalName).Replace(lastNumber, (newNumber + 1).ToString());

                return newName;

            }
            else return string.Copy(originalName) +"01";
           
        }

        public void Remove(List<IListItem> collection, IListItem item)
        {
            collection.Remove(item);
        }


        public void ExportItems(string filePath)
        {
            tagExporter.Export(AllItems, AlarmGroups, AccessNames, DBLoadMode.ToString(), filePath);
        }
        public ReturnResult ImportItems(string filePath)
        {
            ReturnResult result = tagImporter.Import(filePath);

            if (result.Success)
            {
                foreach (IListItem newItem in tagImporter.GetImportedItems())
                {
                    var oldItem = AllItems.GetItemByName(newItem.Name);
                    if (oldItem == null)
                    {
                        AllItems.Add(newItem);
                    }
                    else
                    {
                        if (oldItem is SuperTag && newItem is SuperTag)
                        {
                            foreach (IListItem member in (newItem as SuperTag).Members)
                            {
                                (oldItem as SuperTag).AddMember(member);
                            }
                        }
                        else
                        {
                            AllItems.Remove(oldItem);
                            AllItems.Add(newItem);
                        }
                    }
                }

                foreach (AlarmGroup newAlarmGroup in tagImporter.GetAlarmGroups())
                {
                    AlarmGroup parentGroup = alarmGroupManager.GetAlarmGroupByName(newAlarmGroup.Group);

                    if (parentGroup.GetChildGroupByName(newAlarmGroup.Name) == null)
                    {
                        alarmGroupManager.AddGroup(parentGroup, newAlarmGroup);
                    }
                }

                foreach(AccessName newAccessName in tagImporter.GetAccessNames())
                {
                    AccessName oldAccessName = accessNameManager.GetAccessNameByName(newAccessName.Name);
                    if (oldAccessName != null)
                    {
                        accessNameManager.Remove(oldAccessName);
                    }
                    accessNameManager.Add(newAccessName);
                    
                }

                DBLoadMode = tagImporter.DBLoadMode;
            }

            return result;
        }

        public DBLoadMode DBLoadMode { get; set; }

        public int GetTotalTagCount()
        {
            return AllItems.GetTotalTagCount();
        }


    }
}
