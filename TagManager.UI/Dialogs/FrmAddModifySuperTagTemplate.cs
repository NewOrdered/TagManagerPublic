using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmAddModifySuperTagTemplate : Form
    {
        public FrmAddModifySuperTagTemplate(bool modifyFlag)
        {
            InitializeComponent();
            modify = modifyFlag;
            if (modify)
                Text = "Modify SuperTag template";
            else
                Text = "Add SuperTag template";
        }

        private bool modify;
        public SuperTagTemplate SuperTagTemplate { get; private set; }
        private TemplateManager templateManager;


        public void Build(SuperTagTemplate superTagTemplate, TemplateManager manager)
        {
            SuperTagTemplate = superTagTemplate;
            templateManager = manager;

            tBoxName.Text = SuperTagTemplate.Name;
            tBoxComment.Text = SuperTagTemplate.Comment;
        }

        private bool Apply()
        {
            if (string.IsNullOrWhiteSpace(tBoxName.Text)) //Name empty
            {
                MessageBox.Show(UserMessages.FieldCannotBeEmpty("Name"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }

            if(!modify)
            {
                templateManager.AddSuperTagTemplate(SuperTagTemplate);
            }

            SuperTagTemplate.Name = tBoxName.Text;
            SuperTagTemplate.Comment = tBoxComment.Text;



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
