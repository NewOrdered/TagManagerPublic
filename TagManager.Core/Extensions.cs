using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using TagManager.Core.Models;


namespace TagManager.Core
{
    public static class Extensions
    {
        public static T Clone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        public static IListItem GetItemByName(this List<IListItem> list, string name)
        {
            foreach(IListItem item in list)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        public static string AddQuotes(this string text)
        {
            return string.Format("\"{0}\"", text);
        }

        public static string ToYesNoString(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static void TrimDoubleQuotes(this string[] arrayOfStrings)
        {
            for (int i = 0; i < arrayOfStrings.Length - 1; i++)
            {
                string s = arrayOfStrings[i];
                arrayOfStrings[i] = s.TrimStart('"').TrimEnd('"');
            }
        }

        public static bool IsArrayOfEmptyStrings(this string[] arrayOfStrings)
        {
            bool result = true;
            for (int i = 0; i < arrayOfStrings.Length - 1; i++)
            {
                result &= arrayOfStrings[i].Equals(string.Empty);
            }

            return result;
        }

        public static int GetTotalTagCount(this List<IListItem> list)
        {
            int result = 0;

            foreach (IListItem item in list)
            {
                if (item is ITag)
                    result++;
                if (item is SuperTag)
                {
                    result += (item as SuperTag).Members.Count;
                }
            }

            return result;
        }
        
    }
}
