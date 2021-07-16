using System;
using System.Windows.Forms;
using TagManager.UI.Dialogs;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class TagCommentEditPanel : UserControl, ITagPartEditPanel
    {
        public TagCommentEditPanel(AlarmGroupManager manager)
        {
            InitializeComponent();
            alarmGroupManager = manager;
            this.GotFocus += IoTagCommentEditPanel_GotFocus;
            this.LostFocus += IoTagCommentEditPanel_LostFocus;
            tBoxAlarmComment.LostFocus += TBoxAlarmComment_LostFocus;
        }

        private void TBoxAlarmComment_LostFocus(object sender, EventArgs e)
        {
            tBoxAlarmComment.SelectionStart = 0;
            tBoxAlarmComment.SelectionLength = 0;
        }

        public event EventHandler ChangesMade;

        private void IoTagCommentEditPanel_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void IoTagCommentEditPanel_GotFocus(object sender, EventArgs e)
        {
            tBoxAlarmComment.Focus();
        }

        
        public ITag ITag;
        private AlarmGroupManager alarmGroupManager;


        public void Build(ITag tag)
        {
            ITag = tag;

            lblTagName.Text = ITag.Common.Name;
            lblTagType.Text = ITag.Type;
            tBoxAlarmComment.Text = ITag.Common.AlarmComment;
            btnAlarmGroup.Text = ITag.Common.Group;

            tBoxAlarmComment.TextChanged += TBoxAlarmComment_TextChanged;
            btnAlarmGroup.TextChanged += BtnAlarmGroup_TextChanged;
        }

        private void BtnAlarmGroup_TextChanged(object sender, EventArgs e)
        {
            ChangesMade?.Invoke(this, EventArgs.Empty);
        }

        private void TBoxAlarmComment_TextChanged(object sender, EventArgs e)
        {
            ChangesMade?.Invoke(this, EventArgs.Empty);
        }

        public void Apply()
        {
            ITag.Common.AlarmComment = tBoxAlarmComment.Text;
            ITag.Common.Group = btnAlarmGroup.Text;
        }


        public void EventHandlerOnSave(object sender, EventArgs e)
        {
            Apply();
        }

        public bool FindText(string text)
        {
            if (!string.IsNullOrEmpty(text) && tBoxAlarmComment.Text.Contains(text))
            {
                tBoxAlarmComment.SelectionStart = tBoxAlarmComment.Text.IndexOf(text);
                tBoxAlarmComment.SelectionLength = text.Length;
                return true;
            }

            return false;
        }

        public void ReplaceText(string text, string newText)
        {
            tBoxAlarmComment.Text = tBoxAlarmComment.Text.Replace(text, newText);
        }

        private void btnAlarmGroup_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAlarmGroups(alarmGroupManager, selectModeFlag: true, selectedAlarmGroup: btnAlarmGroup.Text))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (frm.SelectedAlarmGroup != null)
                    {
                        btnAlarmGroup.Text = frm.SelectedAlarmGroup.Name;
                    }
                }
            }
        }
    }
}
