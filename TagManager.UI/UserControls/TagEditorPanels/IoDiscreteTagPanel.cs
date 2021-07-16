using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoDiscreteTagPanel : UserControl, ITagEditorPanel
    {
        public IoDiscreteTagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };

        public IoDiscreteTag IoDiscreteTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;
        
        public void Build(IoDiscreteTag tag, AlarmGroupManager manager, AccessNameManager accessNameManager, List<IListItem> listItems)
        {
            IoDiscreteTag = tag;
            alarmGroupManager = manager;
            
            lblType.Text = IoDiscreteTag.ToString();

            commonPanel.Build(IoDiscreteTag.Common, alarmGroupManager, listItems);
            ioPanel.Build(IoDiscreteTag.Io, accessNameManager);
            discretePanel.Build(IoDiscreteTag.Discrete);
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
    }
}
