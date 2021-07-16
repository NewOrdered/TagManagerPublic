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
    public partial class MembersPanel : UserControl
    {
        public MembersPanel()
        {
            InitializeComponent();
        }

        public SuperTag SuperTag { get; private set; }
        private BindingSource bsMembers = new BindingSource();

        public void Build(SuperTag superTag)
        {
            SuperTag = superTag;

            label1.Text = SuperTag.Name;

            bsMembers.DataSource = SuperTag.Members;
            dataListViewMembers.DataSource = bsMembers;

            //dataListViewMembers.SelectedIndex = 0;
        }
    }
}
