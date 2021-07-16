using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmNewSuperTag : Form
    {
        public FrmNewSuperTag(List<IListItem> listItems)
        {
            InitializeComponent();
            items = listItems;
            tBoxName.Text = "NewSuperTag";
            AcceptButton = btnOk;
        }

        private List<IListItem> items;

        public SuperTag NewSuperTag { get; private set; }
        
        public void Apply()
        {
            if (!string.IsNullOrWhiteSpace(tBoxName.Text) && items.GetItemByName(tBoxName.Text) == null)
            {
                CreateNewSuperTag(tBoxName.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tBoxName.Text))
                {
                    MessageBox.Show(UserMessages.FieldCannotBeEmpty("Name"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }

                if (items.GetItemByName(tBoxName.Text) != null)
                {
                    MessageBox.Show(UserMessages.ObjectExists("Item", tBoxName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void CreateNewSuperTag(string name)
        {
            NewSuperTag = new SuperTag() { Name = name };
            items.Add(NewSuperTag as IListItem);
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
