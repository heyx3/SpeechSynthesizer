using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.ComponentModel;

using Synthesizer = System.Speech.Synthesis.SpeechSynthesizer;


namespace SpeechSynthesizer
{
	public partial class MainForm : Form
	{
		private Synthesizer s = new Synthesizer();
		VoiceGender gender = VoiceGender.Female;
		VoiceAge age = VoiceAge.Adult;


		public MainForm()
		{
			InitializeComponent();

			s.SelectVoiceByHints(gender, age);
		}

		private void WAVLocationDialog_FileOk(object sender, CancelEventArgs e)
		{
			s.SetOutputToWaveFile(WAVLocationDialog.FileName);
			s.Speak(SpeechText.Text);

			System.Diagnostics.Process.Start(new System.IO.FileInfo(WAVLocationDialog.FileName).DirectoryName);
		}

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			WAVLocationDialog.ShowDialog();
		}

		private void PreviewButton_Click(object sender, EventArgs e)
		{
			s.SetOutputToDefaultAudioDevice();
			s.Speak(SpeechText.Text);
		}

		private void GenderText_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (GenderText.Text)
			{
				case "Male":
					gender = VoiceGender.Male;
					break;
				case "Female":
					gender = VoiceGender.Female;
					break;
				case "Neutral":
					gender = VoiceGender.Neutral;
					break;
			}

			s.SelectVoiceByHints(gender, age);
		}

		private void AgeText_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (AgeText.Text)
			{
				case "Child":
					age = VoiceAge.Child;
					break;
				case "Teen":
					age = VoiceAge.Teen;
					break;
				case "Adult":
					age = VoiceAge.Adult;
					break;
				case "Senior":
					age = VoiceAge.Senior;
					break;
			}

			s.SelectVoiceByHints(gender, age);
		}
	}
}
