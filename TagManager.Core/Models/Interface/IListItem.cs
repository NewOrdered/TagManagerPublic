
namespace TagManager.Core.Models
{
    public interface IListItem
    {
        string Name { get; set; }
        string Type { get; }
        string Comment { get; }
    }
}
