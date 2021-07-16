using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryAnalogTagPanel : UserControl, ITagEditorPanel
    {
        public MemoryAnalogTagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };
        public MemoryAnalogTag MemoryAnalogTag { get; private set; }

        private AlarmGroupManager alarmGroupManager;
        public void Build(MemoryAnalogTag tag, AlarmGroupManager manager, List<IListItem> items)
        {
            MemoryAnalogTag = tag;
            alarmGroupManager = manager;

            lblType.Text = MemoryAnalogTag.ToString();

            commonPanel.Build(MemoryAnalogTag.Common, alarmGroupManager, items);
            analogPanel.Build(MemoryAnalogTag.Analog);
        }
        public bool Apply()
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
