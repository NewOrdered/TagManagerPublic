using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmImportExportOptions : Form
    {
        public FrmImportExportOptions()
        {
            InitializeComponent();
            okCancelButtonsPanel.BtnOkClicked += OkCancelButtonsPanel_BtnOkClicked;
            okCancelButtonsPanel.BtnCancelClicked += OkCancelButtonsPanel_BtnCancelClicked;
            AcceptButton = okCancelButtonsPanel.BtnOk;
            Build();
        }

        public PortOptions Options { get; private set; } = new PortOptions();

        public void Build()
        {
            chBoxAlarmGroups.Checked = Options.AlarmGroups;
            chBoxAccessNames.Checked = Options.AccessNames;
            chBoxTags.Checked = Options.Tags;
            chBoxIndirectTags.Checked = Options.IndirectTags;
        }

        private void Apply()
        {
            Options.AlarmGroups = chBoxAlarmGroups.Checked;
            Options.AccessNames = chBoxAccessNames.Checked;
            Options.Tags = chBoxTags.Checked;
            Options.IndirectTags = chBoxIndirectTags.Checked;
        }

        private void OkCancelButtonsPanel_BtnCancelClicked(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }

        private void OkCancelButtonsPanel_BtnOkClicked(object sender, EventArgs e)
        {
            Apply();
            DialogResult = DialogResult.OK;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            chBoxAlarmGroups.Checked =true;
            chBoxAccessNames.Checked = true;
            chBoxTags.Checked = true;
            chBoxIndirectTags.Checked = true;
        }
    }
}
