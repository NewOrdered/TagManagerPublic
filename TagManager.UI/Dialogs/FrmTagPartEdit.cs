using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagManager.Core.Models;
using TagManager.UI.UserControls;

namespace TagManager.UI.Dialogs
{
    public partial class FrmTagPartEdit : Form
    {
        public FrmTagPartEdit(List<ITagPartEditPanel> tagPartEditPanels, string findText, string replaceText)
        {
            InitializeComponent();
            
            tBoxFind.Text = findText;
            tBoxReplace.Text = replaceText;
            tBoxFind.TextChanged += TBoxFind_TextChanged;

            FormClosing += FrmEditIoItems_FormClosing;

            

            foreach(ITagPartEditPanel editPanel in tagPartEditPanels)
            {
                OnSaveClick += editPanel.EventHandlerOnSave;        // each usercontrol (edit panel) is subscribed to Save button click event
                editPanel.ChangesMade += EditPanel_ChangesMade;     // subscribe to each usercontrol's ChangesMade event into single event handler
                pnEditItems.Controls.Add(editPanel as UserControl);
            }
        }

        private void EditPanel_ChangesMade(object sender, EventArgs e)
        {
            changesPending = true;
        }

        private bool changesPending;

        private void TBoxFind_TextChanged(object sender, EventArgs e)
        {
            startControlIndex = 0;
        }

        private void FrmEditIoItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            FindTextSave = tBoxFind.Text;
            ReplaceTextSave = tBoxReplace.Text;

            if(changesPending)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    OnSaveClick?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler OnSaveClick;

        private int startControlIndex = 0;
        private int replaceCount = 0;
        

        public string FindTextSave { get; private set; } = string.Empty;
        public string ReplaceTextSave { get; private set; } = string.Empty;


        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSaveClick?.Invoke(this, EventArgs.Empty);
            changesPending = false;
        }

        private ITagPartEditPanel editPanel;

        private void FindText(string text, int startControlIndex)
        {

            if (this.startControlIndex >= pnEditItems.Controls.Count)
            {
                this.startControlIndex = 0;
                MessageBox.Show("Search finished.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = startControlIndex; i < pnEditItems.Controls.Count; i++)
            {


                if (pnEditItems.Controls[i] is ITagPartEditPanel)
                {
                    editPanel = pnEditItems.Controls[i] as ITagPartEditPanel;

                    this.startControlIndex = i + 1;

                    

                    if (editPanel.FindText(text))
                    {
                        (editPanel as UserControl).Focus();

                        break;
                    }

                    
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxFind.Text))
            {
                FindText(tBoxFind.Text, startControlIndex);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if(editPanel != null)
            {
                editPanel.ReplaceText(tBoxFind.Text, tBoxReplace.Text);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            replaceCount = 0;

            foreach(Control control in pnEditItems.Controls)
            {
                if(control is ITagPartEditPanel)
                {
                   if((control as ITagPartEditPanel).FindText(tBoxFind.Text))
                   {
                        (control as ITagPartEditPanel).ReplaceText(tBoxFind.Text, tBoxReplace.Text);
                        replaceCount++;
                   }
                }
            }

            MessageBox.Show(string.Format($"Search finished.\n{replaceCount} replacement(s) were made."), "Replace all", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
