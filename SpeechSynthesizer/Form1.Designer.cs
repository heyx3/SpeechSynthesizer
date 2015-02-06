namespace SpeechSynthesizer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.WAVLocationDialog = new System.Windows.Forms.SaveFileDialog();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.SpeechText = new System.Windows.Forms.TextBox();
			this.PreviewButton = new System.Windows.Forms.Button();
			this.GenderText = new System.Windows.Forms.ComboBox();
			this.GenderLabel = new System.Windows.Forms.Label();
			this.AgeLabel = new System.Windows.Forms.Label();
			this.AgeText = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// WAVLocationDialog
			// 
			this.WAVLocationDialog.DefaultExt = "wav";
			this.WAVLocationDialog.FileName = "soundFile";
			this.WAVLocationDialog.Filter = "WAV Files|*.wav";
			this.WAVLocationDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.WAVLocationDialog_FileOk);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.GenerateButton.Location = new System.Drawing.Point(12, 75);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(156, 47);
			this.GenerateButton.TabIndex = 0;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// SpeechText
			// 
			this.SpeechText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SpeechText.Location = new System.Drawing.Point(12, 12);
			this.SpeechText.Name = "SpeechText";
			this.SpeechText.Size = new System.Drawing.Size(389, 20);
			this.SpeechText.TabIndex = 1;
			this.SpeechText.Text = "Enter speech here!";
			// 
			// PreviewButton
			// 
			this.PreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.PreviewButton.Location = new System.Drawing.Point(245, 75);
			this.PreviewButton.Name = "PreviewButton";
			this.PreviewButton.Size = new System.Drawing.Size(156, 47);
			this.PreviewButton.TabIndex = 2;
			this.PreviewButton.Text = "Preview";
			this.PreviewButton.UseVisualStyleBackColor = true;
			this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
			// 
			// GenderText
			// 
			this.GenderText.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.GenderText.FormattingEnabled = true;
			this.GenderText.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Neutral"});
			this.GenderText.Location = new System.Drawing.Point(63, 42);
			this.GenderText.MaxDropDownItems = 2;
			this.GenderText.Name = "GenderText";
			this.GenderText.Size = new System.Drawing.Size(121, 21);
			this.GenderText.TabIndex = 3;
			this.GenderText.Text = "Female";
			this.GenderText.SelectedIndexChanged += new System.EventHandler(this.GenderText_SelectedIndexChanged);
			// 
			// GenderLabel
			// 
			this.GenderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.GenderLabel.AutoSize = true;
			this.GenderLabel.Location = new System.Drawing.Point(12, 45);
			this.GenderLabel.Name = "GenderLabel";
			this.GenderLabel.Size = new System.Drawing.Size(45, 13);
			this.GenderLabel.TabIndex = 4;
			this.GenderLabel.Text = "Gender:";
			// 
			// AgeLabel
			// 
			this.AgeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.AgeLabel.AutoSize = true;
			this.AgeLabel.Location = new System.Drawing.Point(245, 45);
			this.AgeLabel.Name = "AgeLabel";
			this.AgeLabel.Size = new System.Drawing.Size(29, 13);
			this.AgeLabel.TabIndex = 6;
			this.AgeLabel.Text = "Age:";
			// 
			// AgeText
			// 
			this.AgeText.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.AgeText.FormattingEnabled = true;
			this.AgeText.Items.AddRange(new object[] {
            "Child",
            "Teen",
            "Adult",
            "Senior"});
			this.AgeText.Location = new System.Drawing.Point(280, 42);
			this.AgeText.MaxDropDownItems = 2;
			this.AgeText.Name = "AgeText";
			this.AgeText.Size = new System.Drawing.Size(121, 21);
			this.AgeText.TabIndex = 5;
			this.AgeText.Text = "Adult";
			this.AgeText.SelectedIndexChanged += new System.EventHandler(this.AgeText_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(413, 134);
			this.Controls.Add(this.AgeLabel);
			this.Controls.Add(this.AgeText);
			this.Controls.Add(this.GenderLabel);
			this.Controls.Add(this.GenderText);
			this.Controls.Add(this.PreviewButton);
			this.Controls.Add(this.SpeechText);
			this.Controls.Add(this.GenerateButton);
			this.Name = "MainForm";
			this.Text = "Speech Synthesizer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SaveFileDialog WAVLocationDialog;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.TextBox SpeechText;
		private System.Windows.Forms.Button PreviewButton;
		private System.Windows.Forms.ComboBox GenderText;
		private System.Windows.Forms.Label GenderLabel;
		private System.Windows.Forms.Label AgeLabel;
		private System.Windows.Forms.ComboBox AgeText;
	}
}

