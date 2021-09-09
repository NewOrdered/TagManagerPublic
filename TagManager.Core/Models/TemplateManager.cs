using System.Collections.Generic;

namespace TagManager.Core.Models
{
    public class TemplateManager
    {
        public List<SuperTagTemplate> SuperTagTemplates { get; private set; } = new List<SuperTagTemplate>();

        private ISerializer<List<SuperTagTemplate>> serializer;

        public TemplateManager(ISerializer<List<SuperTagTemplate>> serializer)
        {
            this.serializer = serializer;
        }

        public void SaveSuperTagTemplates()
        {
            serializer.Serialize(SuperTagTemplates, "SuperTagTemplates.xml");
        }

        public void LoadSuperTagTemplates()
        {
            SuperTagTemplates = serializer.Deserialize("SuperTagTemplates.xml");
        }

        public void AddSuperTagTemplate(SuperTagTemplate s)
        {
            SuperTagTemplates.Add(s);
        }

        public void RemoveSuperTagTemplate(SuperTagTemplate s)
        {
            SuperTagTemplates.Remove(s);
        }

    }
}
