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

namespace TagManager.UI.UserControls
{
    public partial class TagPanel : UserControl
    {
        public TagPanel()
        {
            InitializeComponent();
        }

        public EventHandler Applied = delegate { };

        //private AlarmGroupManager alarmGroupManager;

        public void Build()
        {

        }

        public bool Apply()
        {
            ReturnResult ApplyCommon = commonPanel.Apply();

            return ApplyCommon.Success;
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
