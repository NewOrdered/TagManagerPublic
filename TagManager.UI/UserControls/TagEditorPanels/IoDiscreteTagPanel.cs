using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoDiscreteTagPanel : TagPanel
    {
        public IoDiscreteTagPanel()
        {
            InitializeComponent();
        }

        public void Build(IoDiscreteTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> listItems)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, listItems);
            ioPanel.Build(tag.Io, accessNameManager);
            discretePanel.Build(tag.Discrete);
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
                discretePanel.Apply();
            }
            else
            {
                MessageBox.Show(ApplyCommon.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            return ApplyCommon.Success;
        }
    }
}
