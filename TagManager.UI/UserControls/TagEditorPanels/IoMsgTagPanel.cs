using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoMsgTagPanel : UserControl, ITagEditorPanel
    {
        public IoMsgTagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };

        public IoMsgTag IoMsgTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;

        public void Build(IoMsgTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> listItems)
        {
            IoMsgTag = tag;
            alarmGroupManager = manager;

            lblType.Text = IoMsgTag.ToString();

            commonPanel.Build(IoMsgTag.Common, alarmGroupManager, listItems);
            ioPanel.Build(IoMsgTag.Io, accessNameManager);
            msgPanel.Build(IoMsgTag.Msg);
        }

        public void UpdateFromModel()
        {
            ioPanel.Update(ioPanel.Io);
            commonPanel.Update(commonPanel.Common);
        }

        public bool Apply()
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
    }
}
