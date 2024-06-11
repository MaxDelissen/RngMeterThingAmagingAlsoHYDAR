namespace RngMeterThingAmagingAlsoHYDAR
{
	partial class Calculator
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			MeterNowNumericUpDown = new NumericUpDown();
			MeterMaxNumericUpDown = new NumericUpDown();
			MeterPerRunNumericUpDown = new NumericUpDown();
			RunsNumericUpDown = new NumericUpDown();
			DropChanceNumericUpDown = new NumericUpDown();
			CalculateButton = new Button();
			OutcomeLabel = new Label();
			RerollCheckBox = new CheckBox();
			label6 = new Label();
			UsingWeightOutcomeLabel = new Label();
			CalculateUsingWeightButton = new Button();
			TotalWeightNumericUpDown = new NumericUpDown();
			ItemWeightNumericUpDown = new NumericUpDown();
			label8 = new Label();
			ItemWeightLabel = new Label();
			rNGItByWeightLabel = new Label();
			rNGItByWeightButton = new Button();
			rNGItLabel = new Label();
			rNGItButton = new Button();
			((System.ComponentModel.ISupportInitialize)MeterNowNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)MeterMaxNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)MeterPerRunNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)RunsNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)DropChanceNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)TotalWeightNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemWeightNumericUpDown).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 14);
			label1.Name = "label1";
			label1.Size = new Size(66, 15);
			label1.TabIndex = 0;
			label1.Text = "Meter Now";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 43);
			label2.Name = "label2";
			label2.Size = new Size(64, 15);
			label2.TabIndex = 1;
			label2.Text = "Meter Max";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 72);
			label3.Name = "label3";
			label3.Size = new Size(82, 15);
			label3.TabIndex = 2;
			label3.Text = "Meter Per Run";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 101);
			label4.Name = "label4";
			label4.Size = new Size(33, 15);
			label4.TabIndex = 3;
			label4.Text = "Runs";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 130);
			label5.Name = "label5";
			label5.Size = new Size(105, 15);
			label5.TabIndex = 4;
			label5.Text = "Drop Chance (1/X)";
			// 
			// MeterNowNumericUpDown
			// 
			MeterNowNumericUpDown.Location = new Point(123, 12);
			MeterNowNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			MeterNowNumericUpDown.Name = "MeterNowNumericUpDown";
			MeterNowNumericUpDown.Size = new Size(120, 23);
			MeterNowNumericUpDown.TabIndex = 5;
			// 
			// MeterMaxNumericUpDown
			// 
			MeterMaxNumericUpDown.Location = new Point(123, 41);
			MeterMaxNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			MeterMaxNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MeterMaxNumericUpDown.Name = "MeterMaxNumericUpDown";
			MeterMaxNumericUpDown.Size = new Size(120, 23);
			MeterMaxNumericUpDown.TabIndex = 6;
			MeterMaxNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// MeterPerRunNumericUpDown
			// 
			MeterPerRunNumericUpDown.Location = new Point(123, 70);
			MeterPerRunNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			MeterPerRunNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			MeterPerRunNumericUpDown.Name = "MeterPerRunNumericUpDown";
			MeterPerRunNumericUpDown.Size = new Size(120, 23);
			MeterPerRunNumericUpDown.TabIndex = 7;
			MeterPerRunNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// RunsNumericUpDown
			// 
			RunsNumericUpDown.Location = new Point(123, 99);
			RunsNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
			RunsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			RunsNumericUpDown.Name = "RunsNumericUpDown";
			RunsNumericUpDown.Size = new Size(120, 23);
			RunsNumericUpDown.TabIndex = 8;
			RunsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// DropChanceNumericUpDown
			// 
			DropChanceNumericUpDown.Location = new Point(123, 128);
			DropChanceNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			DropChanceNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			DropChanceNumericUpDown.Name = "DropChanceNumericUpDown";
			DropChanceNumericUpDown.Size = new Size(120, 23);
			DropChanceNumericUpDown.TabIndex = 9;
			DropChanceNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// CalculateButton
			// 
			CalculateButton.Location = new Point(12, 175);
			CalculateButton.Name = "CalculateButton";
			CalculateButton.Size = new Size(82, 23);
			CalculateButton.TabIndex = 10;
			CalculateButton.Text = "Calculate!";
			CalculateButton.UseVisualStyleBackColor = true;
			CalculateButton.Click += CalculateButton_Click;
			// 
			// OutcomeLabel
			// 
			OutcomeLabel.AutoSize = true;
			OutcomeLabel.Location = new Point(100, 179);
			OutcomeLabel.Name = "OutcomeLabel";
			OutcomeLabel.Size = new Size(0, 15);
			OutcomeLabel.TabIndex = 11;
			// 
			// RerollCheckBox
			// 
			RerollCheckBox.AutoSize = true;
			RerollCheckBox.Location = new Point(123, 157);
			RerollCheckBox.Name = "RerollCheckBox";
			RerollCheckBox.Size = new Size(15, 14);
			RerollCheckBox.TabIndex = 12;
			RerollCheckBox.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(12, 157);
			label6.Name = "label6";
			label6.Size = new Size(42, 15);
			label6.TabIndex = 13;
			label6.Text = "Reroll?";
			// 
			// UsingWeightOutcomeLabel
			// 
			UsingWeightOutcomeLabel.AutoSize = true;
			UsingWeightOutcomeLabel.Location = new Point(387, 179);
			UsingWeightOutcomeLabel.Name = "UsingWeightOutcomeLabel";
			UsingWeightOutcomeLabel.Size = new Size(0, 15);
			UsingWeightOutcomeLabel.TabIndex = 15;
			// 
			// CalculateUsingWeightButton
			// 
			CalculateUsingWeightButton.Location = new Point(255, 175);
			CalculateUsingWeightButton.Name = "CalculateUsingWeightButton";
			CalculateUsingWeightButton.Size = new Size(126, 23);
			CalculateUsingWeightButton.TabIndex = 14;
			CalculateUsingWeightButton.Text = "Calculate by weight!";
			CalculateUsingWeightButton.UseVisualStyleBackColor = true;
			CalculateUsingWeightButton.Click += CalculateUsingWeightButton_Click;
			// 
			// TotalWeightNumericUpDown
			// 
			TotalWeightNumericUpDown.Location = new Point(366, 128);
			TotalWeightNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			TotalWeightNumericUpDown.Name = "TotalWeightNumericUpDown";
			TotalWeightNumericUpDown.Size = new Size(120, 23);
			TotalWeightNumericUpDown.TabIndex = 19;
			TotalWeightNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// ItemWeightNumericUpDown
			// 
			ItemWeightNumericUpDown.Location = new Point(366, 99);
			ItemWeightNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			ItemWeightNumericUpDown.Name = "ItemWeightNumericUpDown";
			ItemWeightNumericUpDown.Size = new Size(120, 23);
			ItemWeightNumericUpDown.TabIndex = 18;
			ItemWeightNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(255, 130);
			label8.Name = "label8";
			label8.Size = new Size(73, 15);
			label8.TabIndex = 17;
			label8.Text = "Total Weight";
			// 
			// ItemWeightLabel
			// 
			ItemWeightLabel.AutoSize = true;
			ItemWeightLabel.Location = new Point(255, 101);
			ItemWeightLabel.Name = "ItemWeightLabel";
			ItemWeightLabel.Size = new Size(72, 15);
			ItemWeightLabel.TabIndex = 16;
			ItemWeightLabel.Text = "Item Weight";
			// 
			// rNGItByWeightLabel
			// 
			rNGItByWeightLabel.AutoSize = true;
			rNGItByWeightLabel.Location = new Point(387, 208);
			rNGItByWeightLabel.Name = "rNGItByWeightLabel";
			rNGItByWeightLabel.Size = new Size(0, 15);
			rNGItByWeightLabel.TabIndex = 23;
			// 
			// rNGItByWeightButton
			// 
			rNGItByWeightButton.Location = new Point(255, 204);
			rNGItByWeightButton.Name = "rNGItByWeightButton";
			rNGItByWeightButton.Size = new Size(126, 23);
			rNGItByWeightButton.TabIndex = 22;
			rNGItByWeightButton.Text = "RNG it by Weight!";
			rNGItByWeightButton.UseVisualStyleBackColor = true;
			rNGItByWeightButton.Click += rNGItByWeightButton_Click;
			// 
			// rNGItLabel
			// 
			rNGItLabel.AutoSize = true;
			rNGItLabel.Location = new Point(100, 208);
			rNGItLabel.Name = "rNGItLabel";
			rNGItLabel.Size = new Size(0, 15);
			rNGItLabel.TabIndex = 21;
			// 
			// rNGItButton
			// 
			rNGItButton.Enabled = false;
			rNGItButton.Location = new Point(12, 204);
			rNGItButton.Name = "rNGItButton";
			rNGItButton.Size = new Size(82, 23);
			rNGItButton.TabIndex = 20;
			rNGItButton.Text = "RNG it!";
			rNGItButton.UseVisualStyleBackColor = true;
			// 
			// Calculator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(498, 237);
			Controls.Add(rNGItByWeightLabel);
			Controls.Add(rNGItByWeightButton);
			Controls.Add(rNGItLabel);
			Controls.Add(rNGItButton);
			Controls.Add(TotalWeightNumericUpDown);
			Controls.Add(ItemWeightNumericUpDown);
			Controls.Add(label8);
			Controls.Add(ItemWeightLabel);
			Controls.Add(UsingWeightOutcomeLabel);
			Controls.Add(CalculateUsingWeightButton);
			Controls.Add(label6);
			Controls.Add(RerollCheckBox);
			Controls.Add(OutcomeLabel);
			Controls.Add(CalculateButton);
			Controls.Add(DropChanceNumericUpDown);
			Controls.Add(RunsNumericUpDown);
			Controls.Add(MeterPerRunNumericUpDown);
			Controls.Add(MeterMaxNumericUpDown);
			Controls.Add(MeterNowNumericUpDown);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Calculator";
			Text = "Hydar RNG Meter Calculator";
			((System.ComponentModel.ISupportInitialize)MeterNowNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)MeterMaxNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)MeterPerRunNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)RunsNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)DropChanceNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)TotalWeightNumericUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemWeightNumericUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private NumericUpDown MeterNowNumericUpDown;
		private NumericUpDown MeterMaxNumericUpDown;
		private NumericUpDown MeterPerRunNumericUpDown;
		private NumericUpDown RunsNumericUpDown;
		private NumericUpDown DropChanceNumericUpDown;
		private Button CalculateButton;
		private Label OutcomeLabel;
		private CheckBox RerollCheckBox;
		private Label label6;
		private Label UsingWeightOutcomeLabel;
		private Button CalculateUsingWeightButton;
		private NumericUpDown TotalWeightNumericUpDown;
		private NumericUpDown ItemWeightNumericUpDown;
		private Label label8;
		private Label ItemWeightLabel;
		private Label rNGItByWeightLabel;
		private Button rNGItByWeightButton;
		private Label rNGItLabel;
		private Button rNGItButton;
	}
}