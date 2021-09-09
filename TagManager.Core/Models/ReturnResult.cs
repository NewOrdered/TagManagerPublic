
namespace TagManager.Core.Models
{
    public class ReturnResult
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public object ReturnObject { get; set; } = null;
    }
}
