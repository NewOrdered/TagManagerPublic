using System.IO;

namespace TagManager.Core.Models
{
    public class TxtFileLogger : ILogger
    {
        public void LogError(string errorText)
        {
            LogMessage(errorText);
        }

        public void LogInfo(string infoText)
        {
            LogMessage(infoText);
        }

        public void LogWarning(string warningText)
        {
            LogMessage(warningText);
        }

        private void LogMessage(string message)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine(message);
            }
        }
    }
}
