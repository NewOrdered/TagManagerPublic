using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class MemoryDiscreteTagPanel : UserControl, ITagEditorPanel
    {
        public MemoryDiscreteTagPanel()
        {
            InitializeComponent();
        }
        public EventHandler Applied = delegate { };

        public MemoryDiscreteTag MemoryDiscreteTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;

        public void Build(MemoryDiscreteTag tag, AlarmGroupManager manager, List<IListItem> listItems)
        {
            MemoryDiscreteTag = tag;
            alarmGroupManager = manager;

            lblType.Text = MemoryDiscreteTag.ToString();

            commonPanel.Build(MemoryDiscreteTag.Common, alarmGroupManager, listItems);
            discretePanel.Build(MemoryDiscreteTag.Discrete);
        }

        public bool Apply()
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
