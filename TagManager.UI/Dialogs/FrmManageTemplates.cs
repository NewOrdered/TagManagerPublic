using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.Dialogs
{
    public partial class FrmManageTemplates : Form
    {
        public FrmManageTemplates(TemplateManager templateManager)
        {
            InitializeComponent();

            this.templateManager = templateManager;
            dataListViewSuperTagTemplates.SelectionChanged += DataListViewSuperTagTemplates_SelectionChanged;

            //modifyButtonsPanel.BtnAddClicked += ModifyButtonsPanel_BtnAddClicked;
            modifyButtonsPanel.BtnCloseClicked += ModifyButtonsPanel_BtnCloseClicked;
            modifyButtonsPanel.BtnDeleteClicked += ModifyButtonsPanel_BtnDeleteClicked;
            modifyButtonsPanel.BtnModifyClicked += ModifyButtonsPanel_BtnModifyClicked;


            modifyButtonsPanel.SetBtnModifyEnabled(false);
            modifyButtonsPanel.SetBtnDeleteEnabled(false);
            modifyButtonsPanel.SetAddButtonVisible(false);

            FormClosing += FrmManageTemplates_FormClosing;

            bsSuperTagTemplates.DataSource = this.templateManager.SuperTagTemplates;

            bsSuperTagTemplates.ListChanged += BsSuperTagTemplates_ListChanged;
            UpdateSuperTagTemplatesList();
        }

        private void FrmManageTemplates_FormClosing(object sender, FormClosingEventArgs e)
        {
            templateManager.SaveSuperTagTemplates();
        }

        private void BsSuperTagTemplates_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (templateManager.SuperTagTemplates.Count == 0)
            {
                dataListViewSuperTagTemplates.SelectedObject = null;
            }
        }

        private void ModifyButtonsPanel_BtnModifyClicked(object sender, EventArgs e)
        {
            if(selectedSuperTagTemplate != null)
            {
                using(var frm = new FrmAddModifySuperTagTemplate(modifyFlag: true))
                {
                    frm.Build(selectedSuperTagTemplate, templateManager);
                    DialogResult result = frm.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        UpdateSuperTagTemplatesList();
                    }
                }
            }
        }

        private void ModifyButtonsPanel_BtnDeleteClicked(object sender, EventArgs e)
        {
            if (selectedSuperTagTemplate != null)
            {
                DialogResult dialogResult = MessageBox.Show(UserMessages.DeleteObjectConfirm(selectedSuperTagTemplate.Name), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dialogResult == DialogResult.Yes)
                {
                    templateManager.RemoveSuperTagTemplate(selectedSuperTagTemplate);
                    UpdateSuperTagTemplatesList();
                }
            }
        }

        private void ModifyButtonsPanel_BtnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }


        private void DataListViewSuperTagTemplates_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.DataListView dlv = sender as BrightIdeasSoftware.DataListView;
            selectedSuperTagTemplate = dlv.SelectedObject as SuperTagTemplate; // null if no selection

            if(selectedSuperTagTemplate != null)
            {
                modifyButtonsPanel.SetBtnModifyEnabled(true);
                modifyButtonsPanel.SetBtnDeleteEnabled(true);
            }
            else
            {
                modifyButtonsPanel.SetBtnModifyEnabled(false);
                modifyButtonsPanel.SetBtnDeleteEnabled(false);
            }
        }

        private TemplateManager templateManager;
        private BindingSource bsSuperTagTemplates = new BindingSource();
        private SuperTagTemplate selectedSuperTagTemplate;


        private void UpdateSuperTagTemplatesList()
        {
            bsSuperTagTemplates.ResetBindings(true);
            dataListViewSuperTagTemplates.Objects = bsSuperTagTemplates;
        }

    }
}
