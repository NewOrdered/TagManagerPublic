using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmNewTag : Form
    {
        public FrmNewTag(List<IListItem> listItems)
        {
            InitializeComponent();

            items = listItems;
            tBoxName.Text = "NewTag";
            rBtnIoDiscrete.Checked = true;
            AcceptButton = btnOk;
        }

        private List<IListItem> items;

        public ITag NewTag = new IoIntegerTag();

        public void Apply()
        {
            if (!string.IsNullOrWhiteSpace(tBoxName.Text) && items.GetItemByName(tBoxName.Text) == null)
            {
                CreateNewTag(tBoxName.Text);
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

        private void CreateNewTag(string name)
        {
            if (rBtnIoDiscrete.Checked)
                NewTag = new IoDiscreteTag();
            if (rBtnIoInteger.Checked)
                NewTag = new IoIntegerTag();
            if (rBtnIoReal.Checked)
                NewTag = new IoRealTag();
            if (rBtnIoMsg.Checked)
                NewTag = new IoMsgTag();

            if (rBtnMemoryDiscrete.Checked)
                NewTag = new MemoryDiscreteTag();
            if (rBtnMemoryInteger.Checked)
                NewTag = new MemoryIntegerTag();
            if (rBtnMemoryReal.Checked)
                NewTag = new MemoryRealTag();
            if (rBtnMemoryMsg.Checked)
                NewTag = new MemoryMsgTag();

            NewTag.Common.Name = name;
            items.Add(NewTag as IListItem);
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
