using System.Diagnostics;

namespace RngMeterThingAmagingAlsoHYDAR
{
	public partial class Calculator : Form
	{
		private decimal MeterNow = 0;
		private decimal MeterMax = 0;
		private int MeterPerRun = 0;
		private int Runs = 0;
		private decimal BaseDropChance = 0;
		private decimal DropCount = 0;

		public Calculator()
		{
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			MeterNow = MeterNowNumericUpDown.Value;
			MeterMax = MeterMaxNumericUpDown.Value;
			MeterPerRun = (int)MeterPerRunNumericUpDown.Value;
			Runs = (int)RunsNumericUpDown.Value;
			BaseDropChance = DropChanceNumericUpDown.Value;
			DropCount = 0;
			int DropCountPreviousCycleRoundedDown = 0;

			for (int i = 0; i < Runs; i++)
			{
				if (DropCount >= DropCountPreviousCycleRoundedDown + 1)
				{
					MeterNow = 0;
				}
				MeterNow += MeterPerRun;
				decimal DropCountAddition = (1 / BaseDropChance) * (1 + ((2 * (MeterNow / MeterMax))));
				DropCount += DropCountAddition;
				Debug.WriteLine(DropCountAddition);
				DropCountPreviousCycleRoundedDown = (int)DropCount;
			}
			OutcomeLabel.Text = $"About: {DropCount}";
		}
	}
}