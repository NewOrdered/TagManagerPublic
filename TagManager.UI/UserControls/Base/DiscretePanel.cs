using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class DiscretePanel : UserControl
    {
        public DiscretePanel()
        {
            InitializeComponent();
            rBtnAlarmStateNone.Tag = 0;
            rBtnAlarmStateOn.Tag = 1;
            rBtnAlarmStateOff.Tag = 1;

            rBtnAlarmStateNone.CheckedChanged += rBtnAlarmState_CheckedChanged;
            rBtnAlarmStateOn.CheckedChanged += rBtnAlarmState_CheckedChanged;
            rBtnAlarmStateOff.CheckedChanged += rBtnAlarmState_CheckedChanged;
        }



        public Discrete Discrete;

        private void rBtnAlarmState_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rBtn = sender as RadioButton;

            switch((int)rBtn.Tag)
            {
                case 0:
                    numUpDownAlmPriority.Enabled = false;
                    break;

                case 1:
                    numUpDownAlmPriority.Enabled = true;
                    break;

            }
        }


        public void Build(Discrete discrete)
        {
            Discrete = discrete;

            tBoxOnMessage.Text = Discrete.OnMessage;
            tBoxOffMessage.Text = Discrete.OffMessage;

            numUpDownAlmPriority.Value = Discrete.AlarmPriority;

            BuildAlarmState(Discrete);
        }

        public void Apply()
        {
            Discrete.OnMessage = tBoxOnMessage.Text;
            Discrete.OffMessage = tBoxOffMessage.Text;
            Discrete.AlarmPriority = (int)numUpDownAlmPriority.Value;

            if (rBtnAlarmStateNone.Checked) Discrete.AlarmState = AlarmState.None;
            if (rBtnAlarmStateOn.Checked) Discrete.AlarmState = AlarmState.On;
            if (rBtnAlarmStateOff.Checked) Discrete.AlarmState = AlarmState.Off;
        }

        private void BuildAlarmState(Discrete discrete)
        {
            switch (discrete.AlarmState)
            {
                case AlarmState.None:
                    {
                        rBtnAlarmStateNone.Checked = true;
                        break;
                    }

                case AlarmState.Off:
                    {
                        rBtnAlarmStateOff.Checked = true;
                        break;
                    }

                case AlarmState.On:
                    {
                        rBtnAlarmStateOn.Checked = true;
                        break;
                    }
            }
        }

    }
}
