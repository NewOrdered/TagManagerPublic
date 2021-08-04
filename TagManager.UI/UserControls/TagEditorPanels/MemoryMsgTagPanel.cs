using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryMsgTagPanel : TagPanel, ITagEditorPanel
    {
        public MemoryMsgTagPanel()
        {
            InitializeComponent();
        }

        public void Build(MemoryMsgTag tag, AlarmGroupManager manager, List<IListItem> listItems)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, listItems);
            msgPanel.Build(tag.Msg);
        }

        public override bool Apply()
        {
            ReturnResult ApplyCommon = commonPanel.Apply();

            if (ApplyCommon.Success)
            {
                msgPanel.Apply();
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
