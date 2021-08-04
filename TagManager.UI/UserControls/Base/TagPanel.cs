using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class TagPanel : UserControl
    {
        public TagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };

        public virtual void Build(ITag tag)
        {
            lblType.Text = tag.ToString();
            
        }

        public void SetLabelType(string tagType)
        {
            lblType.Text = tagType;
        }

        

        public virtual bool Apply()
        {
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Apply())
            {
                OnApplied();
            }
        }
        protected void OnApplied()
        {
            Applied(this, EventArgs.Empty);
        }
    }
    
}
