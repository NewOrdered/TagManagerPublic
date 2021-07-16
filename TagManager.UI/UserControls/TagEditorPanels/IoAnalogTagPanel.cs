using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoAnalogTagPanel : UserControl, ITagEditorPanel
    {
        public IoAnalogTagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };
        public IoAnalogTag ioAnalogTag { get; private set; }

        private AlarmGroupManager alarmGroupManager;
        //private AccessNameManager accessNameManager;

        public void Build(IoAnalogTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> items)
        {
            ioAnalogTag = tag;
            alarmGroupManager = manager;

            lblType.Text = ioAnalogTag.ToString();

            commonPanel.Build(ioAnalogTag.Common, alarmGroupManager, items);
            analogPanel.Build(ioAnalogTag.Analog);
            ioAnalogPanel.Build(ioAnalogTag.IoAnalog);
            ioPanel.Build(ioAnalogTag.Io, accessNameManager);
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
