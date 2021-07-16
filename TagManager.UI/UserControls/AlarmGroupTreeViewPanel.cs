using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class AlarmGroupTreeViewPanel : UserControl
    {
        public AlarmGroupTreeViewPanel()
        {
            InitializeComponent();

            treeListViewAlarmGroups.CanExpandGetter = delegate (object x) { return ((AlarmGroup)x).AlarmGroups.Count > 0; };
            treeListViewAlarmGroups.ChildrenGetter = delegate (object x) { return ((AlarmGroup)x).AlarmGroups; };
            treeListViewAlarmGroups.SelectionChanged += TreeListViewAlarmGroups_SelectionChanged;
        }

        private BindingSource bsAlarmGroups = new BindingSource();

        private void TreeListViewAlarmGroups_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.TreeListView tlv = sender as BrightIdeasSoftware.TreeListView;
            SelectedAlarmGroup = tlv.SelectedObject as AlarmGroup; // null if no selection
            OnSelectionChanged();
        }

        public EventHandler SelectionChanged = delegate { };

        protected void OnSelectionChanged()
        {
            SelectionChanged(this, EventArgs.Empty);
        }

        private AlarmGroupManager alarmGroupManager;

        public void Build(AlarmGroupManager manager, string selectedAlarmGroupName)
        {
            alarmGroupManager = manager;
            bsAlarmGroups.DataSource = alarmGroupManager.Groups;

            UpdateTree(selectedAlarmGroupName);
            //treeListViewAlarmGroups.Objects = bsAlarmGroups;
            //treeListViewAlarmGroups.ExpandAll();
            //SetSelectedGroup(selectedAlarmGroupName);
        }

        public void UpdateTree(string selectedAlarmGroupName)
        {
            bsAlarmGroups.ResetBindings(true);
            treeListViewAlarmGroups.Objects = bsAlarmGroups;
            treeListViewAlarmGroups.ExpandAll();
            SetSelectedGroup(selectedAlarmGroupName);
            
        }

        public AlarmGroup SelectedAlarmGroup { get; private set; } = null;

        private void SetSelectedGroup(string alarmGroupName)
        {
            AlarmGroup selectedAlarmGroup = null;
            foreach(AlarmGroup group in alarmGroupManager.Groups)
            {
                selectedAlarmGroup = AlarmGroup.GetAlarmGroup(group, alarmGroupName);
            }
            
            if (selectedAlarmGroup != null)
            {
                treeListViewAlarmGroups.DeselectAll();
                treeListViewAlarmGroups.SelectedObject = selectedAlarmGroup;
                treeListViewAlarmGroups.EnsureModelVisible(selectedAlarmGroup);
            }
        }


    }
}
