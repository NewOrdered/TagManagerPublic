using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmManageAlarmGroups : Form
    {
        public FrmManageAlarmGroups(AlarmGroupManager manager, bool selectModeFlag, string selectedAlarmGroup)
        {
            InitializeComponent();
            alarmGroupManager = manager;
            selectMode = selectModeFlag;
            InitializeButtonPanelEvents();

            alarmGroupTreeViewPanel.Build(alarmGroupManager, selectedAlarmGroup);
            alarmGroupTreeViewPanel.SelectionChanged = AlarmGroupTreeViewSelectionChanged;

            if (selectMode)
            {
                modifyButtonsPanel.Visible = false;
                Text = "Select Alarm Group";
            }
            else
            {
                okCancelButtonsPanel.Visible = false;
                Text = "Alarm Groups";
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
            using (var frm = new FrmAddModifyAlarmGroup(true))
            {
                frm.Build(SelectedAlarmGroup, alarmGroupManager);

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    alarmGroupTreeViewPanel.UpdateTree(SelectedAlarmGroup.Name);
                }
            }
        }

        private void ModifyButtonsPanel_BtnDeleteClicked(object sender, EventArgs e)
        {
            if (SelectedAlarmGroup != null)
            {
                AlarmGroup parentGroup = alarmGroupManager.GetAlarmGroupByName(SelectedAlarmGroup.Group);

                if (parentGroup != null)
                {
                    DialogResult dialogResult = MessageBox.Show(UserMessages.DeleteObjectConfirm(SelectedAlarmGroup.Name), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (dialogResult == DialogResult.Yes)
                    {
                        parentGroup.AlarmGroups.Remove(SelectedAlarmGroup);
                        alarmGroupTreeViewPanel.UpdateTree(string.Empty);
                    }
                }
            }
        }

        private void ModifyButtonsPanel_BtnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyButtonsPanel_BtnAddClicked(object sender, EventArgs e)
        {
            using (var frm = new FrmAddModifyAlarmGroup(false))
            {
                AlarmGroup newAlarmGroup = new AlarmGroup() { Name = "NewAlarmGroup" };

                frm.Build(newAlarmGroup, alarmGroupManager);
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    alarmGroupTreeViewPanel.UpdateTree(newAlarmGroup.Name);
                }
            }
        }

        private bool selectMode;
        private AlarmGroupManager alarmGroupManager;
        public AlarmGroup SelectedAlarmGroup { get; private set; }

        private void AlarmGroupTreeViewSelectionChanged(object sender, EventArgs e)
        {
            if (alarmGroupTreeViewPanel.SelectedAlarmGroup != null)
            {
                if (alarmGroupTreeViewPanel.SelectedAlarmGroup.Name != "$System")
                {
                    modifyButtonsPanel.SetBtnModifyEnabled(true);
                    modifyButtonsPanel.SetBtnDeleteEnabled(true);
                }
                okCancelButtonsPanel.SetBtnOkEnabled(true);
            }
            else 
            {
                modifyButtonsPanel.SetBtnModifyEnabled(false);
                modifyButtonsPanel.SetBtnDeleteEnabled(false);
                okCancelButtonsPanel.SetBtnOkEnabled(false);
            }

            SelectedAlarmGroup = alarmGroupTreeViewPanel.SelectedAlarmGroup;
        }

        
        private void FrmManageAlarmGroups_Load(object sender, EventArgs e)
        {
            modifyButtonsPanel.SetBtnModifyEnabled(false);
            modifyButtonsPanel.SetBtnDeleteEnabled(false);
            okCancelButtonsPanel.SetBtnOkEnabled(false);
        }
    }
}
