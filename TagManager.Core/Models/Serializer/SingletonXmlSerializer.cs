using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TagManager.Core.Models
{
    public class SingletonXmlSerializer<T> : ISerializer<T> where T : IEnumerable<SuperTagTemplate>, new()
	{
		private static readonly Lazy<SingletonXmlSerializer<T>> instance = new Lazy<SingletonXmlSerializer<T>>(() => new SingletonXmlSerializer<T>());

		public static SingletonXmlSerializer<T> Instance => instance.Value;

		private SingletonXmlSerializer()
		{
		}

		public void Serialize(T _serializableObject, string _fileName)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(_serializableObject.GetType());
			using (FileStream stream = new FileStream(_fileName, FileMode.Create))
				xmlSerializer.Serialize(stream, _serializableObject);
		}

		public T Deserialize(string _fileName)
		{
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
				using (FileStream stream = new FileStream(_fileName, FileMode.Open))
					return (T)xmlSerializer.Deserialize(stream);
			}
			catch (FileNotFoundException)
			{
				return new T();
			}
		}
	}
}
