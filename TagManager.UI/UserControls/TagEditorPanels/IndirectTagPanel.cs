using System.Collections.Generic;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IndirectTagPanel : TagPanel, ITagEditorPanel
    {
        public IndirectTagPanel()
        {
            InitializeComponent();
        }

        public void Build(IndirectTag tag, AlarmGroupManager manager, List<IListItem> items)
        {
            SetLabelType(tag.ToString());
            indirectPanel.Build(tag, manager, items);
        }

        public override bool Apply()
        {
            ReturnResult apply = indirectPanel.Apply();
            return apply.Success;
        }

        public void UpdateFromModel()
        {
            indirectPanel.Update(indirectPanel.IndirectTag);
        }

   }
}
