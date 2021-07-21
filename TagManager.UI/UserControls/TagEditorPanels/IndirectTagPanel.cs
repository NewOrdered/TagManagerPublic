using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IndirectTagPanel : UserControl, ITagEditorPanel
    {
        public IndirectTagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };
        public IndirectTag IndirectTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;

        public void Build(IndirectTag tag, AlarmGroupManager manager, List<IListItem> items)
        {
            IndirectTag = tag;
            alarmGroupManager = manager;

            lblType.Text = IndirectTag.ToString();

            indirectPanel.Build(IndirectTag, alarmGroupManager, items);
            
        }

        public bool Apply()
        {
            ReturnResult apply = indirectPanel.Apply();

            return apply.Success;
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
            indirectPanel.Update(IndirectTag);
        }
    }
}
