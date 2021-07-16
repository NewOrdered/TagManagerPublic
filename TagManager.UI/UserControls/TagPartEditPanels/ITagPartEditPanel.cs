using System;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public interface ITagPartEditPanel
    {
        void Build(ITag tag);
        //void Apply();

        void EventHandlerOnSave(object sender, EventArgs e);

        bool FindText(string text);

        void ReplaceText(string text, string newText);

        event EventHandler ChangesMade;
    }
}
