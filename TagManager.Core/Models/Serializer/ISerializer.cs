
namespace TagManager.Core.Models
{
    public interface ISerializer<T>
    {
        void Serialize(T _serializableObject, string _fileName);

        T Deserialize(string _fileName);
    }
}
