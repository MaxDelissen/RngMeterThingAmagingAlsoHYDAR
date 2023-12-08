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
			((System.ComponentModel.ISupportInitialize)MeterNowNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)MeterMaxNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)MeterPerRunNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)RunsNumericUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)DropChanceNumericUpDown).BeginInit();
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
			MeterNowNumericUpDown.Enabled = false;
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
			RunsNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
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
			CalculateButton.Location = new Point(12, 157);
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
			OutcomeLabel.Location = new Point(100, 161);
			OutcomeLabel.Name = "OutcomeLabel";
			OutcomeLabel.Size = new Size(0, 15);
			OutcomeLabel.TabIndex = 11;
			// 
			// Calculator
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(253, 188);
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
	}
}