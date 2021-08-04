using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoAnalogTagPanel : TagPanel, ITagEditorPanel
    {
        public IoAnalogTagPanel()
        {
            InitializeComponent();
        }

        public void Build(IoAnalogTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> items)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, items);
            analogPanel.Build(tag.Analog);
            ioAnalogPanel.Build(tag.IoAnalog);
            ioPanel.Build(tag.Io, accessNameManager);
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
                analogPanel.Apply();
                ioAnalogPanel.Apply();
                ioPanel.Apply();
            }
            else
            {
                MessageBox.Show(ApplyCommon.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            return ApplyCommon.Success;
        }

    }
}
