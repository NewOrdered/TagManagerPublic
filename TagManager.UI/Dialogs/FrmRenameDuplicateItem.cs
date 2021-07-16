using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmRenameDuplicateItem : Form
    {
        public FrmRenameDuplicateItem()
        {
            InitializeComponent();
            AcceptButton = btnOk;
        }

        public string ItemName;
        private List<IListItem> items;

        public void Build(string itemName, List<IListItem> items)
        {
            ItemName = itemName;
            this.items = items;
            tBoxName.Text = ItemName;
        }

        public void Apply()
        {
                if (string.IsNullOrWhiteSpace(tBoxName.Text))
                {
                    MessageBox.Show(UserMessages.FieldCannotBeEmpty("Name"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (items.GetItemByName(tBoxName.Text) != null)
                {
                    MessageBox.Show(UserMessages.ObjectExists("Item", tBoxName.Text),"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }

                ItemName = tBoxName.Text;
                DialogResult = DialogResult.OK;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Apply();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
