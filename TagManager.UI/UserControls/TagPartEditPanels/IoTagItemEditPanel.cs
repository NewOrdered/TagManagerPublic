using System;
using System.Windows.Forms;
using TagManager.UI.Dialogs;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoTagItemEditPanel : UserControl, ITagPartEditPanel
    {
        public IoTagItemEditPanel(AccessNameManager manager)
        {
            InitializeComponent();
            accessNameManager = manager;

            this.GotFocus += IoTagItemEditPanel_GotFocus;
            this.LostFocus += IoTagItemEditPanel_LostFocus;
            tBoxItemName.LostFocus += TBoxItemName_LostFocus;

            

        }

        public event EventHandler ChangesMade;

        

        private void TBoxItemName_LostFocus(object sender, EventArgs e)
        {
            tBoxItemName.SelectionStart = 0;
            tBoxItemName.SelectionLength = 0;
        }

        private void IoTagItemEditPanel_LostFocus(object sender, EventArgs e)
        {
            
        }

        private void IoTagItemEditPanel_GotFocus(object sender, EventArgs e)
        {
            tBoxItemName.Focus();
        }

        public IIoTag IoTag;
        private AccessNameManager accessNameManager;

        public void Build(ITag tag)
        {
            IoTag = tag as IIoTag;

            lblTagName.Text = IoTag.Common.Name;
            lblTagType.Text = IoTag.Type;
            tBoxItemName.Text = IoTag.Io.ItemName;
            btnAccessName.Text = IoTag.Io.AccessName;



            tBoxItemName.TextChanged += TBoxItemName_TextChanged;
            btnAccessName.TextChanged += BtnAccessName_TextChanged; ;
        }

        private void BtnAccessName_TextChanged(object sender, EventArgs e)
        {
            ChangesMade?.Invoke(this, EventArgs.Empty);
        }

        private void TBoxItemName_TextChanged(object sender, EventArgs e)
        {
            ChangesMade?.Invoke(this, EventArgs.Empty);
        }

        public void Apply()
        {
            IoTag.Io.ItemName = tBoxItemName.Text;
            IoTag.Io.AccessName = btnAccessName.Text;
        }


        public void EventHandlerOnSave(object sender, EventArgs e)
        {
            Apply();
        }

        public bool FindText(string text)
        {
            if(!string.IsNullOrEmpty(text) && tBoxItemName.Text.Contains(text))
            {
                tBoxItemName.SelectionStart = tBoxItemName.Text.IndexOf(text);
                tBoxItemName.SelectionLength = text.Length;
                return true;
            }

            return false;
        }

        public void ReplaceText(string text, string newText)
        {
            tBoxItemName.Text = tBoxItemName.Text.Replace(text, newText);
        }

        private void btnAccessName_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmManageAccessNames(accessNameManager, selectModeFlag: true, selectedAccessName: btnAccessName.Text))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (frm.SelectedAccessName != null)
                    {
                        btnAccessName.Text = frm.SelectedAccessName.Name;
                    }
                }
            }
        }
    }
}
