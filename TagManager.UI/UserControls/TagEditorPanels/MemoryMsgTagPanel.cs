using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryMsgTagPanel : UserControl, ITagEditorPanel
    {
        public MemoryMsgTagPanel()
        {
            InitializeComponent();
        }
        public EventHandler Applied = delegate { };

        public MemoryMsgTag MemoryMsgTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;

        public void Build(MemoryMsgTag tag, AlarmGroupManager manager, List<IListItem> listItems)
        {
            MemoryMsgTag = tag;
            alarmGroupManager = manager;

            lblType.Text = MemoryMsgTag.ToString();

            commonPanel.Build(MemoryMsgTag.Common, alarmGroupManager, listItems);
            msgPanel.Build(MemoryMsgTag.Msg);
        }

        public bool Apply()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Apply())
            {
                OnApplied();
            }
        }

        protected void OnApplied()
        {
            Applied(this, EventArgs.Empty);
        }

        public void UpdateFromModel()
        {
            commonPanel.Update(commonPanel.Common);
        }
    }
}
