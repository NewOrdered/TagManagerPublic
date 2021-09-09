using System;

namespace TagManager.Core.Models
{
    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string infoText)
        {
            LogMessage(infoText);
        }
        public void LogWarning(string warningText)
        {
            LogMessage(warningText);
        }

        public void LogError(string errorText)
        {
            LogMessage(errorText);
        }

        private void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
