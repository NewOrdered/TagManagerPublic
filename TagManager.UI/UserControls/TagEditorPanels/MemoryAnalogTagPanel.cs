using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryAnalogTagPanel : TagPanel, ITagEditorPanel
    {
        public MemoryAnalogTagPanel()
        {
            InitializeComponent();
        }

        public void Build(MemoryAnalogTag tag, AlarmGroupManager manager, List<IListItem> items)
        {
            SetLabelType(tag.ToString());

            commonPanel.Build(tag.Common, manager, items);
            analogPanel.Build(tag.Analog);
        }

        public override bool Apply()
        {
            ReturnResult ApplyCommon = commonPanel.Apply();

            if (ApplyCommon.Success)
            {
                analogPanel.Apply();
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
