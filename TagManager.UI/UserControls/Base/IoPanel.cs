using System;
using System.Windows.Forms;
using TagManager.UI.Dialogs;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoPanel : UserControl
    {
        public IoPanel()
        {
            InitializeComponent();
        }

        public Io Io;

        public void Build(Io io, AccessNameManager manager)
        {
            Io = io;

            accessNameManager = manager;

            Update(Io);
        }

        private AccessNameManager accessNameManager;

        public void Update(Io io)
        {
            tBoxAccessName.Text = io.AccessName;
            tBoxItemName.Text = io.ItemName;
            cBoxReadOnly.Checked = io.ReadOnly;
        }

        public void Apply()
        {
            Io.AccessName = tBoxAccessName.Text;
            Io.ItemName = tBoxItemName.Text;
            Io.ReadOnly = cBoxReadOnly.Checked;
        }

        private void btnShowSelectAccessNameDialog_Click(object sender, EventArgs e)
        {
            //using (var frm = new FrmSelectAccessName(accessNameManager, tBoxAccessName.Text))
            //{
            //    var result = frm.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        if (frm.SelectedAccessName != null)
            //        {
            //            tBoxAccessName.Text = frm.SelectedAccessName.Name;
            //        }
            //    }
            //}


            using (var frm = new FrmManageAccessNames(accessNameManager, selectModeFlag: true, selectedAccessName: tBoxAccessName.Text))
            {
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (frm.SelectedAccessName != null)
                    {
                        tBoxAccessName.Text = frm.SelectedAccessName.Name;
                    }
                }
            }

        }
    }
}
