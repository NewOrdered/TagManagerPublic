using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmAddModifyAccessName : Form
    {
        public FrmAddModifyAccessName(bool modifyFlag)
        {
            InitializeComponent();
            modify = modifyFlag;
            if (modify)
                Text = "Modify Access Name";
            else
                Text = "Add Access Name";
        }

        public AccessName AccessName { get; private set; }
        private AccessNameManager accessNameManager;
        private bool modify;

        public void Build(AccessName accessName, AccessNameManager manager)
        {
            AccessName = accessName;
            accessNameManager = manager;

            tBoxAccessName.Text = AccessName.Name;
            tBoxNodeName.Text = AccessName.NodeName;
            tBoxApplicationName.Text = AccessName.Application;
            tBoxTopicName.Text = AccessName.Topic;

            //if(AccessName.DDEProtocol)
            //{
            //    rBtnDDE.Checked = true;
            //    rBtnSuiteLink.Checked = false;
            //}
            //else
            //{
            //    rBtnDDE.Checked = false;
            //    rBtnSuiteLink.Checked = true;
            //}

            switch(AccessName.DDEProtocol)
            {
                case DDEProtocol.Yes:
                    rBtnDDE.Checked = true;
                    break;
                case DDEProtocol.No:
                    rBtnSuiteLink.Checked = true;
                    break;
                case DDEProtocol.MX:
                    rBtnMessageExchange.Checked = true;
                    break;
            }
                

            if(AccessName.AdviseActiveItems)
            {
                rBtnAdviseActiveItems.Checked = true;
                rBtnAdviseAllItems.Checked = false;
            }
            else
            {
                rBtnAdviseActiveItems.Checked = false;
                rBtnAdviseAllItems.Checked = true;
            }

        }

        public bool Apply()
        {
            if (string.IsNullOrWhiteSpace(tBoxAccessName.Text)) //Access Name empty
            {
                MessageBox.Show(UserMessages.FieldCannotBeEmpty("Access Name"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

            //if (accessNameManager.GetAccessNameByName(tBoxAccessName.Text) != null) // Access Name with such name already exists
            //{
            //    MessageBox.Show(UserMessages.ObjectExists("Access Name", tBoxAccessName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            //    return false;
            //}

            if(modify) // in case of modifying existing Access Name
            {
                if(tBoxAccessName.Text != AccessName.Name) // Access Name name changed (user changed tBoxAccessName content)
                {
                    if (accessNameManager.GetAccessNameByName(tBoxAccessName.Text) != null) // Access Name with such name already exists
                    {
                        MessageBox.Show(UserMessages.ObjectExists("Access Name", tBoxAccessName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }


            }
            else // in case of adding new Access Name
            {
                if (accessNameManager.GetAccessNameByName(tBoxAccessName.Text) != null) // Access Name with such name already exists
                {
                    MessageBox.Show(UserMessages.ObjectExists("Access Name", tBoxAccessName.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return false;
                }
                else 
                {
                    accessNameManager.Add(AccessName);
                }

            }

            AccessName.Name = tBoxAccessName.Text;
            AccessName.NodeName = tBoxNodeName.Text;
            AccessName.Application = tBoxApplicationName.Text;
            AccessName.Topic = tBoxTopicName.Text;

            if (rBtnDDE.Checked)
                AccessName.DDEProtocol = DDEProtocol.Yes;

            if (rBtnSuiteLink.Checked)
                AccessName.DDEProtocol = DDEProtocol.No;

            if (rBtnMessageExchange.Checked)
                AccessName.DDEProtocol = DDEProtocol.MX;


            AccessName.AdviseActiveItems = rBtnAdviseActiveItems.Checked;

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


    }
}
