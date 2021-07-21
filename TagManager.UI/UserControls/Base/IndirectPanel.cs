using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;
using TagManager.UI.Dialogs;


namespace TagManager.UI.UserControls
{
    public partial class IndirectPanel : UserControl
    {
        public IndirectPanel()
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

        public IndirectTag IndirectTag { get; private set; }
        private AlarmGroupManager alarmGroupManager;
        private List<IListItem> items;

        public void Update(IndirectTag indirectTag)
        {
            //tBoxSymbolicName.Text = indirectTag.SymbolicName;
            tBoxComment.Text = indirectTag.Common.Comment;
            tBoxGroup.Text = indirectTag.Common.Group;
        }

        public void Build(IndirectTag indirectTag, AlarmGroupManager manager, List<IListItem> listItems)
        {
            IndirectTag = indirectTag;
            alarmGroupManager = manager;
            items = listItems;

            tBoxTagName.Text = IndirectTag.Name;
            tBoxGroup.Text = IndirectTag.Common.Group;
            tBoxComment.Text = IndirectTag.Comment;

            cBoxEventLogged.Checked = IndirectTag.Common.EventLogged;

            numUpDownPriority.Value = IndirectTag.Common.EventLoggingPriority;

            tBoxSymbolicName.Text = IndirectTag.SymbolicName;
            cBoxRetentive.Checked = IndirectTag.Common.RetentiveValue;
        }

        public ReturnResult Apply()
        {
            ReturnResult result = new ReturnResult();

            if (string.IsNullOrWhiteSpace(tBoxTagName.Text))
            {
                result.Message = UserMessages.FieldCannotBeEmpty("Name");
                return result;
            }
            if (string.IsNullOrWhiteSpace(tBoxGroup.Text))
            {
                result.Message = UserMessages.FieldCannotBeEmpty("Alarm Group");
                return result;
            }
            if (IndirectTag.Name != tBoxTagName.Text && items.GetItemByName(tBoxTagName.Text) != null)
            {
                result.Message = UserMessages.ObjectExists("Item", tBoxTagName.Text);
                return result;
            }

            IndirectTag.Name = tBoxTagName.Text;
            IndirectTag.Common.Group = tBoxGroup.Text;
            IndirectTag.Common.Comment = tBoxComment.Text;

            IndirectTag.Common.EventLogged = cBoxEventLogged.Checked;
            IndirectTag.Common.EventLoggingPriority = (int)numUpDownPriority.Value;
            IndirectTag.SymbolicName = tBoxSymbolicName.Text;
            IndirectTag.Common.RetentiveValue = cBoxRetentive.Checked;

            result.Success = true;
            return result;
        }

        private void btnShowSelecAlarmGroupDialog_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAlarmGroups(alarmGroupManager, selectModeFlag: true, selectedAlarmGroup: tBoxGroup.Text))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (frm.SelectedAlarmGroup != null)
                    {
                        tBoxGroup.Text = frm.SelectedAlarmGroup.Name;
                    }
                }
            }
        }
    }
}
