using PerceptronPredictionSystem.Model;

namespace PerceptronPredictionSystem
{
	public partial class Form : System.Windows.Forms.Form
	{
		private Data[]? data;

		public Form()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			if (nrPerceptronTextBox.Text == "" || nrHrBitsTextBox.Text == "")
			{
				MessageBox.Show("Select Nr of perceptrons and Nr of bits in HR");
			}
			else if (data != null)
			{
				Predictor predictor = new Predictor(Int32.Parse(nrPerceptronTextBox.Text),
												Int32.Parse(nrHrBitsTextBox.Text),
												data);
				predictor.Train();

				double accuracyTaken = predictor.totalJumpsTakenPredicted * 1.0 / predictor.totalJumpsTaken;
				double accuracyNotTaken = predictor.totalJumpsNotTakenPredicted * 1.0 / predictor.totalJumpsNotTaken;
				double accuracy = (predictor.totalJumpsTakenPredicted + predictor.totalJumpsNotTakenPredicted) * 1.0 / predictor.totalJumps;

				totalJumpsLabel.Text = "Total Jumps: " + predictor.totalJumps;
				takenTotalLabel.Text = "Taken total: " + predictor.totalJumpsTaken;
				takenPredictedLabel.Text = "Taken predicted: " + predictor.totalJumpsTakenPredicted;
				notTakenTotalLabel.Text = "Not-Taken total: " + predictor.totalJumpsNotTaken;
				notTakenPredictedLabel.Text = "Not-Taken predicted: " + predictor.totalJumpsNotTakenPredicted;
				accuracyLabel.Text = "Accuracy: " + (accuracy * 100.0) + "%";
				accuracyTakenLabel.Text = "Accuracy taken: " + (accuracyTaken * 100.0) + "%";
				accuracyNotTakenLabel.Text = "Accuracy not-taken: " + (accuracyNotTaken * 100.0) + "%";
			}
			else
			{
				MessageBox.Show("The file doesn't contain data");
			}
		}

		private void chooseFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

			if (result == DialogResult.OK) // Test result.
			{
				string file = openFileDialog1.FileName;
				startButton.Enabled = true;
				filenameLabel.Text = file;

				data = Data.GetData(file);
			}
		}
	}
}