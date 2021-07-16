using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmManageAccessNames : Form
    {
        public FrmManageAccessNames(AccessNameManager manager, bool selectModeFlag, string selectedAccessName)
        {
            InitializeComponent();

            selectMode = selectModeFlag;
            accessNameManager = manager;
            InitializeButtonPanelEvents();

            accessNamesListPanel.Build(accessNameManager, selectedAccessName);
            accessNamesListPanel.SelectionChanged = AccessNameListViewSelectionChanged;

            
            if(selectMode)
            {
                modifyButtonsPanel.Visible = false;
                Text = "Select Access Name";
            }
            else 
            {
                okCancelButtonsPanel.Visible = false;
                Text = "Access Names";
            }
        }

        private void InitializeButtonPanelEvents()
        {
            modifyButtonsPanel.BtnAddClicked += ModifyButtonsPanel_BtnAddClicked;
            modifyButtonsPanel.BtnCloseClicked += ModifyButtonsPanel_BtnCloseClicked;
            modifyButtonsPanel.BtnDeleteClicked += ModifyButtonsPanel_BtnDeleteClicked;
            modifyButtonsPanel.BtnModifyClicked += ModifyButtonsPanel_BtnModifyClicked;

            okCancelButtonsPanel.BtnCancelClicked += OkCancelButtonsPanel_BtnCancelClicked;
            okCancelButtonsPanel.BtnOkClicked += OkCancelButtonsPanel_BtnOkClicked;
        }

        private void OkCancelButtonsPanel_BtnOkClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void OkCancelButtonsPanel_BtnCancelClicked(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ModifyButtonsPanel_BtnModifyClicked(object sender, EventArgs e)
        {
            if (SelectedAccessName == null)
                return;

            using (var frm = new FrmAddModifyAccessName(true))
            {
                frm.Build(SelectedAccessName, accessNameManager);
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    accessNamesListPanel.UpdateList(SelectedAccessName.Name);
                }
            }
        }

        private void ModifyButtonsPanel_BtnDeleteClicked(object sender, EventArgs e)
        {
            if (SelectedAccessName != null)
            {
                DialogResult dialogResult = MessageBox.Show(UserMessages.DeleteObjectConfirm(SelectedAccessName.Name), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    accessNameManager.Remove(SelectedAccessName);
                    accessNamesListPanel.UpdateList(string.Empty);
                }
            }
        }

        private void ModifyButtonsPanel_BtnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyButtonsPanel_BtnAddClicked(object sender, EventArgs e)
        {
            using (var frm = new FrmAddModifyAccessName(false))
            {
                AccessName newAccessName = new AccessName() { Name = "NewAccessName" };

                frm.Build(newAccessName, accessNameManager);
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    accessNamesListPanel.UpdateList(newAccessName.Name);
                }
            }
        }

        private AccessNameManager accessNameManager;
        public AccessName SelectedAccessName { get; private set; }
        private bool selectMode;

        private void AccessNameListViewSelectionChanged(object sender, EventArgs e)
        {
            if (accessNamesListPanel.SelectedAccessName != null)
            {
                modifyButtonsPanel.SetBtnModifyEnabled(true);
                modifyButtonsPanel.SetBtnDeleteEnabled(true);
                okCancelButtonsPanel.SetBtnOkEnabled(true);
            }
            else
            {
                modifyButtonsPanel.SetBtnModifyEnabled(false);
                modifyButtonsPanel.SetBtnDeleteEnabled(false);
                okCancelButtonsPanel.SetBtnOkEnabled(false);
            }

            SelectedAccessName = accessNamesListPanel.SelectedAccessName;
        }


        private void FrmManageAccessNames_Load(object sender, EventArgs e)
        {
            modifyButtonsPanel.SetBtnModifyEnabled(false);
            modifyButtonsPanel.SetBtnDeleteEnabled(false);
            okCancelButtonsPanel.SetBtnOkEnabled(false);
        }
    }
}
