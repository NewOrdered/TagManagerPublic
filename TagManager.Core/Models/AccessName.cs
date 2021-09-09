

namespace TagManager.Core.Models
{
    public class AccessName
    {
        public string Name { get; set; }
        public string NodeName { get; set; }
        public string Application { get; set; }
        public string ApplicationExportField 
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(NodeName))
                    return Application;
                else
                    return string.Format(@"\\{0}\{1}", NodeName, Application);
            }
             
        }
        public string Topic { get; set; }
        public bool AdviseActiveItems { get; set; }
        //public bool DDEProtocol { get; set; }

        public DDEProtocol DDEProtocol { get; set; } = DDEProtocol.No;


    }
}
