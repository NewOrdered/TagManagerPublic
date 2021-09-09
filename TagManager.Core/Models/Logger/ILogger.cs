
namespace TagManager.Core.Models
{
    public interface ILogger
    {
        void LogInfo(string infoText);
        void LogWarning(string warningText);
        void LogError(string errorText);
    }
}
