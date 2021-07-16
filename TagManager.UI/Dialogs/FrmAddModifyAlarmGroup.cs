using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmAddModifyAlarmGroup : Form
    {
        public FrmAddModifyAlarmGroup(bool modifyFlag)
        {
            InitializeComponent();
            modify = modifyFlag;

            if (modify)
                Text = "Modify Alarm Group";
            else
                Text = "Add Alarm Group";
        }

        public AlarmGroup AlarmGroup { get; private set; }
        private AlarmGroupManager alarmGroupManager;
        private bool modify;

        public void Build(AlarmGroup alarmGroup, AlarmGroupManager manager)
        {
            AlarmGroup = alarmGroup;
            alarmGroupManager = manager;

            tBoxGroupName.Text = AlarmGroup.Name;
            lblParentGroup.Text = AlarmGroup.Group;
            tBoxComment.Text = AlarmGroup.Comment;
        }

        public bool Apply()
        {
            if(string.IsNullOrWhiteSpace(tBoxGroupName.Text))
            {
                MessageBox.Show(UserMessages.FieldCannotBeEmpty("Group Name"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

            if(modify) // in case of modifying existing Alarm Group
            {
                if (tBoxGroupName.Text != AlarmGroup.Name) // Alarm Group name changed
                {
                    if (alarmGroupManager.GetAlarmGroupByName(tBoxGroupName.Text) != null) // Alarm Group with such name already exists
                    {
                        MessageBox.Show(UserMessages.ObjectExists("Alarm Group", tBoxGroupName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }

                if (AlarmGroup.Group != lblParentGroup.Text) //parent Alarm Group changed
                {
                    AlarmGroup oldParentGroup = alarmGroupManager.GetAlarmGroupByName(AlarmGroup.Group);
                    AlarmGroup newParentGroup = alarmGroupManager.GetAlarmGroupByName(lblParentGroup.Text);

                    if (oldParentGroup != null && newParentGroup != null)
                    {
                        alarmGroupManager.RemoveGroup(oldParentGroup, AlarmGroup);
                        alarmGroupManager.AddGroup(newParentGroup, AlarmGroup);
                    }
                    else
                    {
                        MessageBox.Show(UserMessages.CannotAssignParentGroup(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }
            }
            else // in case of adding new Alarm Group
            {
                AlarmGroup existingGroup = alarmGroupManager.GetAlarmGroupByName(tBoxGroupName.Text);
                AlarmGroup parentGroup = alarmGroupManager.GetAlarmGroupByName(lblParentGroup.Text);

                if(existingGroup != null) // Alarm Group with such name already exists
                {
                    MessageBox.Show(UserMessages.ObjectExists("Alarm Group", tBoxGroupName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }

                if(parentGroup != null)
                {
                    alarmGroupManager.AddGroup(parentGroup, AlarmGroup);
                }
                else
                {
                    MessageBox.Show(UserMessages.CannotAssignParentGroup(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }

            AlarmGroup.Name = tBoxGroupName.Text;
            AlarmGroup.Group = lblParentGroup.Text;
            AlarmGroup.Comment = tBoxComment.Text;

            return true;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Apply())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelectParentGroup_Click(object sender, EventArgs e)
        {

            //using (var frm = new FrmSelectAlarmGroup(alarmGroupManager, lblParentGroup.Text))
            //{
            //    var result = frm.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        if (frm.SelectedAlarmGroup != null)
            //        {
            //            if (AlarmGroup != frm.SelectedAlarmGroup)
            //            {
            //                lblParentGroup.Text = frm.SelectedAlarmGroup.Name;
            //            }
            //        }
            //    }
            //}
            using (var frm = new FrmManageAlarmGroups(alarmGroupManager, selectModeFlag: true, selectedAlarmGroup: lblParentGroup.Text))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (frm.SelectedAlarmGroup != null)
                    {
                        if (AlarmGroup != frm.SelectedAlarmGroup)
                        {
                            lblParentGroup.Text = frm.SelectedAlarmGroup.Name;
                        }
                    }
                }
            }
        }
    }
}
