using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmNewSuperTag : Form
    {
        public FrmNewSuperTag(List<IListItem> listItems, List<SuperTagTemplate> templates)
        {
            InitializeComponent();
            items = listItems;
            tBoxName.Text = "NewSuperTag";
            AcceptButton = btnOk;
            bsTemplates.DataSource = templates;
            

            cBoxTemplates.SelectedIndexChanged += CBoxTemplates_SelectedIndexChanged;
            rBtnUseTemplate.CheckedChanged += RBtnUseTemplate_CheckedChanged;
            rBtnEmpty.CheckedChanged += RBtnEmpty_CheckedChanged;

            rBtnEmpty.Checked = true;

            cBoxTemplates.DataSource = bsTemplates;
            cBoxTemplates.DisplayMember = "DisplayName";
            
        }

        private void RBtnEmpty_CheckedChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            cBoxTemplates.Enabled = false;
        }

        private SuperTagTemplate selectedTemplate;

        private void RBtnUseTemplate_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            cBoxTemplates.Enabled = rb.Checked;
        }

        private void CBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedIndex > -1)
            {
                selectedTemplate = (SuperTagTemplate)cb.SelectedItem;
                btnOk.Enabled = true;
            }
            else
            {
                selectedTemplate = null;
                if (rBtnUseTemplate.Checked)
                {
                    btnOk.Enabled = false;
                }
            }
        }

        private BindingSource bsTemplates = new BindingSource();

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
            if (rBtnEmpty.Checked)
            {
                NewSuperTag = new SuperTag() { Name = name };
            }
            else
            {
                NewSuperTag = selectedTemplate.GenerateSuperTag(name);
            }

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
