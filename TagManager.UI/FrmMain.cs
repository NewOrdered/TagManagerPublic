using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;
using TagManager.UI.UserControls;
using TagManager.UI.Dialogs;

namespace TagManager.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain(TagStorage storage)
        {
            InitializeComponent();

            DoubleBuffered = true;

            tagStorage = storage;
            
            dataListViewAllTags.SelectionChanged += DataListViewAllTags_SelectionChanged;
            dataListViewMembers.SelectionChanged += DataListViewMembers_SelectionChanged;
            dataListViewAllTags.CellRightClick += DataListViewAllTags_CellRightClick;
            dataListViewMembers.CellRightClick += DataListViewMembers_CellRightClick;
            dataListViewAllTags.ItemsChanged += DataListViewAllTags_ItemsChanged;
            dataListViewMembers.ItemsChanged += DataListViewMembers_ItemsChanged;

            bsMembers.ListChanged += BsMembers_ListChanged;
            bsAllItems.ListChanged += BsAllItems_ListChanged;

            bsAllItems.DataSource = tagStorage.AllItems;
            dataListViewAllTags.DataSource = bsAllItems;

            bsAlarmGroups.DataSource = tagStorage.AlarmGroups;

            btnDeleteMember.Enabled = false;
            btnDuplicateMember.Enabled = false;

            btnDeleteItem.Enabled = false;
            btnDuplicateItem.Enabled = false;


            HideMembers();
            
        }

        private void BsAllItems_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if(tagStorage.AllItems.Count == 0)
            {
                btnDeleteItem.Enabled = false;
                btnDuplicateItem.Enabled = false;
            }
        }

        private void BsMembers_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            if(selectedSuperTag != null && selectedSuperTag.Members.Count == 0)
            {
                btnDeleteMember.Enabled = false;
                btnDuplicateMember.Enabled = false;
            }
        }

        private void DataListViewMembers_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            SetLabelTextMembersCount();
        }

        private void DataListViewAllTags_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e)
        {
            SetLabelTextItemsCount(); 
        }

        private BindingSource bsMembers = new BindingSource();

        private BindingSource bsAllItems = new BindingSource();

        private BindingSource bsAlarmGroups = new BindingSource();

        private TagStorage tagStorage;

        private IListItem rightClickedObject;

        private List<IListItem> rightClickedObjectCollection;

        private ArrayList rightClickedObjects;

        private SuperTag selectedSuperTag;

        private void DataListViewMembers_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;
            rightClickedObjectCollection = bsMembers.DataSource as List<IListItem>;

            if (dlv.SelectedObjects.Count > 1)
            {
                //TODO: Add  Context menu strip for handling multiple selected items

                rightClickedObjects = (ArrayList)dlv.SelectedObjects;
                e.MenuStrip = ShowContextMenuMultipleSelectedObjects();
            }
            else
            {
                e.MenuStrip = ShowContextMenuSelectedObject(e.Model as IListItem);
            }
        }

        private void DataListViewAllTags_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;
            rightClickedObjectCollection = bsAllItems.DataSource as List<IListItem>;

            if (dlv.SelectedObjects.Count > 1)
            {
                //TODO: Add  Context menu strip for handling multiple selected items

                rightClickedObjects = (ArrayList)dlv.SelectedObjects;
                e.MenuStrip = ShowContextMenuMultipleSelectedObjects();
            }
            else
            {
                e.MenuStrip = ShowContextMenuSelectedObject(e.Model as IListItem);
            }
        }

        private ContextMenuStrip ShowContextMenuSelectedObject(IListItem selectedObject)
        {
            if (selectedObject != null)
            {
                rightClickedObject = selectedObject;
                if (selectedObject is ITag)
                    return cMenuStripSelectedObject;
                else
                    return cMenuStripSelectedSuperTag;
            }
            else return null;
        }

        private ContextMenuStrip ShowContextMenuMultipleSelectedObjects()
        {
           
                return cMenuStripMultipleObjects;
           
        }

        private void DataListViewMembers_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;

            if (dlv.SelectedObject != null)
            {
                ShowEditorPanel(dlv.SelectedObject as ITag, selectedSuperTag.Members);
                btnDuplicateMember.Enabled = true;
                btnDeleteMember.Enabled = true;
            }
            else
            {
                HideEditorPanel();
                btnDuplicateMember.Enabled = false;
                btnDeleteMember.Enabled = false;

                rightClickedObject = null;
                rightClickedObjectCollection = null;
            }
        }

        private void DataListViewAllTags_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;

            if (dlv.SelectedObject != null)
            {
                btnDeleteItem.Enabled = true;
                btnDuplicateItem.Enabled = true;
                
                
                if (dlv.SelectedObject is ITag)
                {
                    HideMembers();
                    
                    ShowEditorPanel(dlv.SelectedObject as ITag, tagStorage.AllItems);

                    selectedSuperTag = null;
                }
                else 
                {
                    ShowMembers();
                    selectedSuperTag = (SuperTag)dlv.SelectedObject;
                    lblSelectedSuperTagName.Text = selectedSuperTag.Name;
                    
                    bsMembers.DataSource = selectedSuperTag.Members;
                    
                    dataListViewMembers.DataSource = bsMembers;
                }
            }
            else
            {
                btnDeleteItem.Enabled = false;
                btnDuplicateItem.Enabled = false;

                HideEditorPanel();
                HideMembers();
                selectedSuperTag = null;
            }
        }

        private void OnEditorPanelApplied(object sender, EventArgs e)
        {
            bsAllItems.ResetBindings(true);
            bsMembers.ResetBindings(true);
        }

        private void ShowEditorPanel(ITag tag, List<IListItem> items)
        {
            HideEditorPanel();

            if (tag != null)
            {
                if (tag is IoDiscreteTag) new IoDiscreteTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as IoDiscreteTag, tagStorage.AlarmGroupManager, tagStorage.AccessNameManager, items);
                if (tag is IoAnalogTag) new IoAnalogTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as IoAnalogTag, tagStorage.AlarmGroupManager, tagStorage.AccessNameManager, items);
                if (tag is IoMsgTag) new IoMsgTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as IoMsgTag, tagStorage.AlarmGroupManager, tagStorage.AccessNameManager, items);
                if (tag is MemoryDiscreteTag) new MemoryDiscreteTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as MemoryDiscreteTag, tagStorage.AlarmGroupManager, items);
                if (tag is MemoryAnalogTag) new MemoryAnalogTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as MemoryAnalogTag, tagStorage.AlarmGroupManager, items);
                if (tag is MemoryMsgTag) new MemoryMsgTagPanel { Parent = pnEditor, Dock = DockStyle.Fill, Applied = OnEditorPanelApplied }.Build(tag as MemoryMsgTag, tagStorage.AlarmGroupManager, items);
            }
        }

        private void ShowMembers()
        {
            gBoxMembers.Visible = true;
        }

        private void HideEditorPanel()
        {
            pnEditor.Controls.Clear();
        }

        private void HideMembers()
        {
            gBoxMembers.Visible = false;
            bsMembers.DataSource = null;
        }

        private void tStripMenuItemDuplicate_Click(object sender, EventArgs e)
        {
            ProcessDuplicateItem(rightClickedObjectCollection, rightClickedObject);
        }

        private void tStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            ProcessDeleteItem(rightClickedObjectCollection, rightClickedObject);
        }

        private void ProcessDeleteItem(List<IListItem> list, IListItem item)
        {
            if (item is ITag)
            {
                HideEditorPanel();
            }
            else
            {
                HideMembers();
                HideEditorPanel();
            }

            RemoveItem(list, item);

            bsAllItems.ResetBindings(true);
            bsMembers.ResetBindings(true);
        }

        private void ProcessDuplicateItem(List<IListItem> list, IListItem originalItem)
        {
            using (var frm = new FrmRenameDuplicateItem())
            {
                var newItem = tagStorage.Copy(originalItem);

                frm.Text = "Duplicate";
                frm.Build(newItem.Name, list);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newItem.Name = frm.ItemName;
                    list.Add(newItem);
                    bsAllItems.ResetBindings(true);
                    bsMembers.ResetBindings(true);
                }
            }
        }

        private void ProcessDeleteMultipleItems(List<IListItem> items, ArrayList itemsToDelete)
        {
            DialogResult dialogResult = MessageBox.Show(UserMessages.DeleteMultipleItemsConfirm(itemsToDelete.Count), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                foreach (IListItem item in itemsToDelete)
                {
                    items.Remove(item);
                }
                bsAllItems.ResetBindings(true);
                bsMembers.ResetBindings(true);
            }
        }

        private void SetLabelTextItemsCount()
        {
            
            lblTotalItemsCount.Text = string.Format("{0} item(s). Total: {1} tag(s)", dataListViewAllTags.Items.Count, GetTotalTagsCount());

        }

        private int GetTotalTagsCount()
        {
            return tagStorage.GetTotlaTagsCount();
        }

        private void SetLabelTextMembersCount()
        {
            lblMembersCount.Text = string.Format("{0} member(s)", dataListViewMembers.Items.Count);
        }

        private void btnDuplicateMember_Click(object sender, EventArgs e)
        {
            if(dataListViewMembers.SelectedObject != null)
            {
                ProcessDuplicateItem(selectedSuperTag.Members, dataListViewMembers.SelectedObject as IListItem);
            }
        }

        private void btnDuplicateItem_Click(object sender, EventArgs e)
        {
           if(dataListViewAllTags.SelectedObject != null)
           {
                ProcessDuplicateItem(tagStorage.AllItems, dataListViewAllTags.SelectedObject as IListItem);
           }
        }

        
        private void RemoveItem(List<IListItem> list, IListItem item)
        {
            tagStorage.Remove(list, item);
        }

        private void tStripMenuSuperTagDuplicate_Click(object sender, EventArgs e)
        {
            ProcessDuplicateItem(rightClickedObjectCollection, rightClickedObject);
        }

        private void tStripMenuSuperTagDelete_Click(object sender, EventArgs e)
        {
            ProcessDeleteItem(rightClickedObjectCollection, rightClickedObject);
        }

        private void tStripMenuSuperTagRename_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmRenameDuplicateItem())
            {
                frm.Text = "Rename";
                frm.Build(rightClickedObject.Name, rightClickedObjectCollection);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rightClickedObject.Name = frm.ItemName;
                    bsAllItems.ResetBindings(true);
                }
            }
        }

        private void tStripMenuDelete_Click(object sender, EventArgs e)
        {
            ProcessDeleteMultipleItems(rightClickedObjectCollection, rightClickedObjects);
        }

        private void toolStripMenuAlarmGroups_Click(object sender, EventArgs e)
        {
            using(var frm = new FrmManageAlarmGroups(tagStorage.AlarmGroupManager, selectModeFlag: false, selectedAlarmGroup: string.Empty))
            {
                frm.ShowDialog();
            }
        }

        private void tStripMenuImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FrmImportProgress importProgress = new FrmImportProgress(tagStorage, openFileDialog.FileName);
                    importProgress.ShowDialog();
                    if(importProgress.Result.Success)
                    {
                        bsAllItems.ResetBindings(true);
                        MessageBox.Show(importProgress.Result.Message, "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(importProgress.Result.Message, "Import", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (Exception ex)
                {
                    var innerExcpeption = ex.InnerException;
                    string lowestInnerExceptionMessage = "";
                    while (innerExcpeption != null)
                    {
                        lowestInnerExceptionMessage = innerExcpeption.Message;
                        innerExcpeption = innerExcpeption.InnerException;
                    }

                    MessageBox.Show(ex.Message + "\n" + lowestInnerExceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dataListViewMembers.SelectedObject != null)
            {
                ProcessDeleteItem(selectedSuperTag.Members, dataListViewMembers.SelectedObject as IListItem);
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataListViewAllTags.SelectedObject != null)
            {
                ProcessDeleteItem(tagStorage.AllItems, dataListViewAllTags.SelectedObject as IListItem);
            }
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNewTag(tagStorage.AllItems))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bsAllItems.ResetBindings(true);
                    dataListViewAllTags.DeselectAll();
                    dataListViewAllTags.SelectedObject = frm.NewTag;
                    dataListViewAllTags.EnsureModelVisible(frm.NewTag);
                }
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNewTag(selectedSuperTag.Members))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bsMembers.ResetBindings(true);
                    bsAllItems.ResetBindings(true);
                    dataListViewMembers.DeselectAll();
                    dataListViewMembers.SelectedObject = frm.NewTag;
                    dataListViewMembers.EnsureModelVisible(frm.NewTag);
                }
            }
        }

        private void btnNewSuperTag_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNewSuperTag(tagStorage.AllItems))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bsAllItems.ResetBindings(true);
                    dataListViewAllTags.DeselectAll();
                    dataListViewAllTags.SelectedObject = frm.NewSuperTag;
                    dataListViewAllTags.EnsureModelVisible(frm.NewSuperTag);
                }
            }
        }

        
        private string findText = string.Empty;
        private string replaceText = string.Empty;

        private void btnEditIoItems_Click(object sender, EventArgs e)
        {
            if(selectedSuperTag != null)
            {
                //List<IIoTag> ioTags = new List<IIoTag>();
                //foreach(ITag tag in selectedSuperTag.Members)
                //{
                //    if(tag is IIoTag)
                //    {
                //        ioTags.Add(tag as IIoTag);
                //    }
                //}

                List<ITagPartEditPanel> tagPartEditPanels = new List<ITagPartEditPanel>();
                foreach(ITag tag in selectedSuperTag.Members)
                {
                    if(tag is IIoTag)
                    {
                        IoTagItemEditPanel editPanel = new IoTagItemEditPanel(tagStorage.AccessNameManager);

                        editPanel.Build(tag as IIoTag);
                        tagPartEditPanels.Add(editPanel);
                    }
                }

                FrmTagPartEdit frm = new FrmTagPartEdit(tagPartEditPanels, findText, replaceText);
                frm.ShowDialog();

                findText = frm.FindTextSave;
                replaceText = frm.ReplaceTextSave;

                UpdateEditorFromModel();
                
            }
        }



        private void UpdateEditorFromModel()
        {
            foreach (Control control in pnEditor.Controls)
            {
                if (control is ITagEditorPanel)
                {
                    (control as ITagEditorPanel).UpdateFromModel();
                }
            }
        }

        private void toolStripMenuIExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tagStorage.ExportItems(saveFileDialog.FileName);
                        
                }
                catch (Exception ex)
                {
                    var innerExcpeption = ex.InnerException;
                    string lowestInnerExceptionMessage = "";
                    while (innerExcpeption != null)
                    {
                        lowestInnerExceptionMessage = innerExcpeption.Message;
                        innerExcpeption = innerExcpeption.InnerException;
                    }

                    MessageBox.Show(ex.Message + "\n" + lowestInnerExceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditComments_Click(object sender, EventArgs e)
        {
            if (selectedSuperTag != null)
            {
                

                List<ITagPartEditPanel> tagPartEditPanels = new List<ITagPartEditPanel>();
                foreach (ITag tag in selectedSuperTag.Members)
                {
                    //if (tag is IIoTag)
                    //{
                        TagCommentEditPanel editPanel = new TagCommentEditPanel(tagStorage.AlarmGroupManager);

                        editPanel.Build(tag);
                        tagPartEditPanels.Add(editPanel);
                    //}
                }

                FrmTagPartEdit frm = new FrmTagPartEdit(tagPartEditPanels, findText, replaceText);
                frm.ShowDialog();

                findText = frm.FindTextSave;
                replaceText = frm.ReplaceTextSave;

                UpdateEditorFromModel();

            }

        }

        private void btnCopyComments_Click(object sender, EventArgs e)
        {

            if (selectedSuperTag != null)
            {
                foreach(ITag tag in selectedSuperTag.Members)
                {
                    tag.Common.Comment = tag.Common.AlarmComment;
                }

                UpdateEditorFromModel();
                bsMembers.ResetBindings(true);
            }

        }

        private void toolStripMenuAccessNames_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAccessNames(tagStorage.AccessNameManager, selectModeFlag: false, selectedAccessName: string.Empty))
            {
                frm.ShowDialog();
            }
        }
    }
}
