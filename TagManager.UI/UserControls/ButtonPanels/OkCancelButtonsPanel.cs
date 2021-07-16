using System;
using System.Windows.Forms;

namespace TagManager.UI.UserControls
{
    public partial class OkCancelButtonsPanel : UserControl
    {
        public OkCancelButtonsPanel()
        {
            InitializeComponent();
        }

        public event EventHandler  BtnOkClicked = delegate { };
        public event EventHandler  BtnCancelClicked = delegate { };


        public void SetBtnOkEnabled(bool enabled)
        {
            btnOk.Enabled = enabled;
        }

        protected void OnBtnOkClicked()
        {
            BtnOkClicked(this, EventArgs.Empty);
        }

        protected void OnBtnCancelClicked()
        {
            BtnCancelClicked(this, EventArgs.Empty);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnBtnOkClicked();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnBtnCancelClicked();
        }
    }
}
