using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;
using TagManager.UI.Dialogs;

namespace TagManager.UI.UserControls
{
    public partial class CommonPanel : UserControl
    {
        public CommonPanel()
        {
            InitializeComponent();
            cBoxEventLogged.CheckedChanged += CBoxEventLogged_CheckedChanged;

            label4.Visible = cBoxEventLogged.Checked;
            numUpDownPriority.Visible = cBoxEventLogged.Checked;
        }

        private void CBoxEventLogged_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            label4.Visible = checkbox.Checked;
            numUpDownPriority.Visible = checkbox.Checked;
        }

        public Common Common;
        private AlarmGroupManager alarmGroupManager;
        private List<IListItem> items;

        public void Update(Common common)
        {
            tBoxAlarmComment.Text = common.AlarmComment;
            tBoxComment.Text = common.Comment;
            tBoxGroup.Text = common.Group;
        }

        public void Build(Common common, AlarmGroupManager manager, List<IListItem> listItems)
        {
            Common = common;
            alarmGroupManager = manager;
            items = listItems;

            tBoxTagName.Text = Common.Name;
            tBoxGroup.Text = Common.Group;
            tBoxComment.Text = Common.Comment;

            cBoxLogged.Checked = Common.Logged;
            cBoxEventLogged.Checked = Common.EventLogged;

            numUpDownPriority.Value = Common.EventLoggingPriority;

            tBoxAlarmComment.Text = Common.AlarmComment;
            cBoxRetentive.Checked = Common.RetentiveValue;
        }

        public ReturnResult Apply()
        {
            ReturnResult result = new ReturnResult();
            
            if(string.IsNullOrWhiteSpace(tBoxTagName.Text))
            {
                result.Message = UserMessages.FieldCannotBeEmpty("Name");
                return result;
            }
            if(string.IsNullOrWhiteSpace(tBoxGroup.Text))
            {
                result.Message = UserMessages.FieldCannotBeEmpty("Alarm Group");
                return result;
            }
            if(Common.Name != tBoxTagName.Text && items.GetItemByName(tBoxTagName.Text) != null)
            {
                result.Message = UserMessages.ObjectExists("Item", tBoxTagName.Text);
                return result;
            }
            
            Common.Name = tBoxTagName.Text;
            Common.Group = tBoxGroup.Text;
            Common.Comment = tBoxComment.Text;
            Common.Logged = cBoxLogged.Checked;
            Common.EventLogged = cBoxEventLogged.Checked;
            Common.EventLoggingPriority = (int)numUpDownPriority.Value;
            Common.AlarmComment = tBoxAlarmComment.Text;
            Common.RetentiveValue = cBoxRetentive.Checked;

            result.Success = true;
            return result;
        }

        private void btnShowSelecAlarmGroupDialog_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAlarmGroups(alarmGroupManager, selectModeFlag: true, selectedAlarmGroup: tBoxGroup.Text))
            {
                var result = frm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    if(frm.SelectedAlarmGroup != null)
                    {
                        tBoxGroup.Text = frm.SelectedAlarmGroup.Name;
                    }
                }
            }
        }
    }
}
