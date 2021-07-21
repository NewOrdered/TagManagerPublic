using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class AccessNamesListPanel : UserControl
    {
        public AccessNamesListPanel()
        {
            InitializeComponent();
            dataListViewAccessNames.SelectionChanged += ListViewAccessNames_SelectionChanged;
            
            bsAccessNames.BindingComplete += BsAccessNames_BindingComplete;
            bsAccessNames.ListChanged += BsAccessNames_ListChanged;
        }

        private void BsAccessNames_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            //throw new NotImplementedException();
            if(accessNameManager.AccessNames.Count == 0)
            {
                dataListViewAccessNames.SelectedObject = null;
            }
        }

        private void BsAccessNames_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            //OnSelectionChanged();
        }

        private BindingSource bsAccessNames = new BindingSource();
        private AccessNameManager accessNameManager;
        public AccessName SelectedAccessName { get; private set; } = null;
        public EventHandler SelectionChanged = delegate { };

        public void Build(AccessNameManager manager, string selectedAccessNameString)
        {
            accessNameManager = manager;
            bsAccessNames.DataSource = accessNameManager.AccessNames;
            UpdateList(selectedAccessNameString);
        }

        private void ListViewAccessNames_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;
            SelectedAccessName = dlv.SelectedObject as AccessName; // null if no selection
            OnSelectionChanged();
        }
        
        public void UpdateList(string selectedAccessNameString)
        {
            bsAccessNames.ResetBindings(true);
            dataListViewAccessNames.Objects = bsAccessNames;
            
            SetSelectedAccessName(selectedAccessNameString);
        }

        protected void OnSelectionChanged()
        {
            SelectionChanged(this, EventArgs.Empty);
        }

        private void SetSelectedAccessName(string accessNameString)
        {
            AccessName selectedAccessName;
            selectedAccessName = accessNameManager.GetAccessNameByName(accessNameString);

            if (selectedAccessName != null)
            {
                dataListViewAccessNames.DeselectAll();
                dataListViewAccessNames.SelectedObject = selectedAccessName;
                dataListViewAccessNames.EnsureModelVisible(selectedAccessName);
            }
            else
            {
                dataListViewAccessNames.SelectedIndex = -1;
            }
        }
    }
}
