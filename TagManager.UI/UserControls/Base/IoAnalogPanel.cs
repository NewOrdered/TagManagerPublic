using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class IoAnalogPanel : UserControl
    {
        public IoAnalogPanel()
        {
            InitializeComponent();

            numUpDownMinRaw.Maximum = Decimal.MaxValue;
            numUpDownMinRaw.Minimum = Decimal.MinValue;

            numUpDownMaxRaw.Maximum = Decimal.MaxValue;
            numUpDownMaxRaw.Minimum = Decimal.MinValue;
        }
        public IoAnalog IoAnalog;

        public void Build(IoAnalog ioAnalog)
        {
            IoAnalog = ioAnalog;

            numUpDownMinRaw.Value = IoAnalog.MinRaw;
            numUpDownMaxRaw.Value = IoAnalog.MaxRaw;
        }

        public void Apply()
        {
            IoAnalog.MinRaw = numUpDownMinRaw.Value;
            IoAnalog.MaxRaw = numUpDownMaxRaw.Value;
        }
    }
}
