using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoMsgTagPanel : TagPanel, ITagEditorPanel
    {
        public IoMsgTagPanel()
        {
            InitializeComponent();
        }

        public void Build(IoMsgTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> listItems)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, listItems);
            ioPanel.Build(tag.Io, accessNameManager);
            msgPanel.Build(tag.Msg);
        }

        public void UpdateFromModel()
        {
            ioPanel.Update(ioPanel.Io);
            commonPanel.Update(commonPanel.Common);
        }

        public override bool Apply()
        {
            ReturnResult ApplyCommon = commonPanel.Apply();

            if (ApplyCommon.Success)
            {
                ioPanel.Apply();
                msgPanel.Apply();
            }
            else
            {
                MessageBox.Show(ApplyCommon.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            return ApplyCommon.Success;
        }
    }
}
