using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace RngMeterThingAmagingAlsoHYDAR
{
	public partial class Calculator : Form
	{
		public Calculator()
		{
			InitializeComponent();
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			OutcomeLabel.Text = $"About: Calculating...";

			decimal MeterNow = (int)MeterNowNumericUpDown.Value;
			decimal MeterMax = (int)MeterMaxNumericUpDown.Value;
			decimal MeterPerRun = (int)MeterPerRunNumericUpDown.Value;
			decimal RunsToBeDone = (int)RunsNumericUpDown.Value;
			decimal BaseDropChance = DropChanceNumericUpDown.Value;
			bool Reroll = RerollCheckBox.Checked;
			decimal DropCountFinal = 0;
			decimal DropCountPartial = 0;

			for (int i = 0; i < RunsToBeDone; i++)
			{
				if (DropCountPartial >= 1)
				{
					DropCountFinal += 1;
					DropCountPartial = 0;
					MeterNow = 0;
					//Debug.WriteLine(1 + "   meter expected (final)");
				}
				if (MeterNow >= MeterMax)
				{
					DropCountFinal += 1;
					DropCountPartial = 0;
					//Debug.WriteLine(1 + "   meter overflow (final)");

					MeterNow = MeterPerRun;
				}
				else
				{
					decimal expectedDropThisRun = (1 / BaseDropChance) * (1 + ((2 * (MeterNow / MeterMax))));
					DropCountPartial += expectedDropThisRun;
					if (Reroll) DropCountPartial += expectedDropThisRun;
					//Debug.WriteLine((1 / BaseDropChance) * (1 + ((2 * (MeterNow / MeterMax)))) + "   normal addition (partial)");

					MeterNow += MeterPerRun;
				}
			}
			DropCountFinal += DropCountPartial;
			OutcomeLabel.Text = $"About: {DropCountFinal}";
		}

		private void CalculateUsingWeightButton_Click(object sender, EventArgs e)
		{
			UsingWeightOutcomeLabel.Text = $"About: Calculating...";

			decimal MeterNow = (int)MeterNowNumericUpDown.Value;
			decimal MeterMax = (int)MeterMaxNumericUpDown.Value;
			decimal MeterPerRun = (int)MeterPerRunNumericUpDown.Value;
			decimal RunsToBeDone = (int)RunsNumericUpDown.Value;
			decimal ItemWeight = ItemWeightNumericUpDown.Value;
			decimal TotalWeight = TotalWeightNumericUpDown.Value;
			bool Reroll = RerollCheckBox.Checked;
			decimal DropCountFinal = 0;
			decimal DropCountPartial = 0;

			for (int i = 0; i < RunsToBeDone; i++)
			{
				if (DropCountPartial >= 1)
				{
					DropCountFinal += 1;
					DropCountPartial = 0;
					MeterNow = 0;
					//Debug.WriteLine(1 + "   meter expected (final)");
				}
				if (MeterNow >= MeterMax)
				{
					DropCountFinal += 1;
					DropCountPartial = 0;
					//Debug.WriteLine(1 + "   meter overflow (final)");

					MeterNow = 0;
				}
				else
				{
					decimal actualItemWeight = ItemWeight * (1 + ((2 * (MeterNow / MeterMax))));
					decimal dropChance = actualItemWeight / (TotalWeight - ItemWeight + actualItemWeight);
					DropCountPartial += dropChance;
					if (Reroll) DropCountPartial += dropChance;
					//Debug.WriteLine((1 / dropChance) * (1 + ((2 * (MeterNow / MeterMax)))) + "   normal addition (partial)");

					MeterNow += MeterPerRun;
				}
			}
			DropCountFinal += DropCountPartial;
			UsingWeightOutcomeLabel.Text = $"About: {DropCountFinal}";
		}

		private void rNGItByWeightButton_Click(object sender, EventArgs e)
		{
			rNGItByWeightLabel.Text = $"About: Calculating...";

			double MeterNow = (int)MeterNowNumericUpDown.Value;
			double MeterMax = (int)MeterMaxNumericUpDown.Value;
			double MeterPerRun = (int)MeterPerRunNumericUpDown.Value;
			decimal RunsToBeDone = (int)RunsNumericUpDown.Value;
			double ItemWeight = (double)ItemWeightNumericUpDown.Value;
			double TotalWeight = (double)TotalWeightNumericUpDown.Value;
			bool Reroll = RerollCheckBox.Checked;
			decimal DropCountFinal = 0;
			int PittiedDrops = 0;

			for (int i = 0; i < RunsToBeDone; i++)
			{
				if (MeterNow >= MeterMax)
				{
					DropCountFinal += 1;
					MeterNow = 0;
					PittiedDrops++;
				}
				else
				{
					double actualItemWeight = (double)(ItemWeight * (1 + ((2 * (MeterNow / MeterMax)))));
					double dropChance = actualItemWeight / (TotalWeight - ItemWeight + actualItemWeight);

					Random random = new Random();
					if (random.NextDouble() <= dropChance) DropCountFinal += 1;
					else if (Reroll && random.NextDouble() <= dropChance) DropCountFinal += 1;

					MeterNow += MeterPerRun;
				}
			}
			Debug.WriteLine(PittiedDrops);
			rNGItByWeightLabel.Text = $"About: {DropCountFinal}";
		}
	}
}