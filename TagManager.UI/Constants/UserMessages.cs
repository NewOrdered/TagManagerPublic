using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagManager.UI
{
    public static class UserMessages
    {
        public static string FieldCannotBeEmpty(string fieldName)
        {
            return string.Format("{0} cannot be empty!", fieldName);
        }

        public static string ObjectExists(string objectType, string objectName)
        {
            return string.Format("{0} with name '{1}' already exists!", objectType, objectName);
        }

        public static string DeleteMultipleItemsConfirm(int numberOfItems)
        {
            return string.Format("Delete {0} items?", numberOfItems);        
        }

        public static string CannotAssignParentGroup()
        {
            return "Cannot assign parent Alarm Group!";
        }

        public static string DeleteObjectConfirm(string objectName)
        {
            return string.Format("Are you sure you wish to delete {0}?", objectName);
        }
    }
}
