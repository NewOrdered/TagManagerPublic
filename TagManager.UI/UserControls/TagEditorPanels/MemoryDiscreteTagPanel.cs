using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryDiscreteTagPanel : TagPanel, ITagEditorPanel
    {
        public MemoryDiscreteTagPanel()
        {
            InitializeComponent();
        }

        public void Build(MemoryDiscreteTag tag, AlarmGroupManager manager, List<IListItem> listItems)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, listItems);
            discretePanel.Build(tag.Discrete);
        }

        public override bool Apply()
        {
            ReturnResult ApplyCommon = commonPanel.Apply();

            if (ApplyCommon.Success)
            {
                discretePanel.Apply();
            }
            else
            {
                MessageBox.Show(ApplyCommon.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            return ApplyCommon.Success;
        }

        public void UpdateFromModel()
        {
            commonPanel.Update(commonPanel.Common);
        }
    }
}
