using System;
using System.Windows.Forms;
using TagManager.Core.Models;

namespace TagManager.UI.UserControls
{
    public partial class AnalogPanel : UserControl
    {
        public AnalogPanel()
        {
            InitializeComponent();
            numUpDownMinEU.Maximum = Decimal.MaxValue;
            numUpDownMinEU.Minimum = Decimal.MinValue;

            numUpDownMaxEU.Maximum = Decimal.MaxValue;
            numUpDownMaxEU.Minimum = Decimal.MinValue;
        }

        public Analog Analog;

        public void Build(Analog analog)
        {
            Analog = analog;

            tBoxEngUnits.Text = Analog.EngUnits;

            numUpDownMinEU.Value = Analog.MinEU;
            numUpDownMaxEU.Value = Analog.MaxEU;
        }

        public void Apply()
        {
            Analog.EngUnits = tBoxEngUnits.Text;

            Analog.MinEU = numUpDownMinEU.Value;
            Analog.MaxEU = numUpDownMaxEU.Value;
        }
    }
}
