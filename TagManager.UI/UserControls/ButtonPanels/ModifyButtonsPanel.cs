using System;
using System.Windows.Forms;

namespace TagManager.UI.UserControls
{
    public partial class ModifyButtonsPanel : UserControl
    {
        public ModifyButtonsPanel()
        {
            InitializeComponent();
        }

        public event EventHandler BtnCloseClicked = delegate { };
        public event EventHandler BtnAddClicked = delegate { };
        public event EventHandler  BtnModifyClicked = delegate { };
        public event EventHandler  BtnDeleteClicked = delegate { };

        public void SetBtnModifyEnabled(bool enabled)
        {
            btnModify.Enabled = enabled;
        }

        public void SetBtnDeleteEnabled(bool enabled)
        {
            btnDelete.Enabled = enabled;
        }
        
        
        
        protected void OnBtnCloseClicked()
        {
            BtnCloseClicked(this, EventArgs.Empty);
        }

        protected void OnBtnAddClicked()
        {
            BtnAddClicked(this, EventArgs.Empty);
        }

        protected void OnBtnModifyClicked()
        {
            BtnModifyClicked(this, EventArgs.Empty);
        }

        protected void OnBtnDeleteClicked()
        {
            BtnDeleteClicked(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnBtnCloseClicked();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnBtnAddClicked();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            OnBtnModifyClicked();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnBtnDeleteClicked();
        }
    }
}
