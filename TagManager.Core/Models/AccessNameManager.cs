using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.Core.Models
{
    public class AccessNameManager
    {
        public List<AccessName> AccessNames { get; private set; } = new List<AccessName>();


        public AccessName GetAccessNameByName(string accessNameString)
        {
            AccessName result = null;
            foreach(var accessName in AccessNames)
            {
                if (accessName.Name == accessNameString)
                    result = accessName;
            }

            return result;
        }

        public void Add(AccessName accessName)
        {
            AccessNames.Add(accessName);
        }

        public void Remove(AccessName accessName)
        {
            AccessNames.Remove(accessName);
        }
    }
}
