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
    public partial class MsgPanel : UserControl
    {
        public MsgPanel()
        {
            InitializeComponent();
        }

        public Msg Msg;

        public void Build(Msg msg)
        {
            Msg = msg;

            tBoxInitialMessage.Text = Msg.InitialMessage;
            numUpDownMaxLength.Value = Msg.MaxLength;
        }

        public void Apply()
        {
            Msg.InitialMessage = tBoxInitialMessage.Text;
            Msg.MaxLength = (int)numUpDownMaxLength.Value;
        }
    }
}
