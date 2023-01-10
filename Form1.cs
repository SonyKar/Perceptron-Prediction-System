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
			if (data != null)
			{
				Predictor predictor = new Predictor(Int32.Parse(nrPerceptronTextBox.Text),
												Int32.Parse(nrHrBitsTextBox.Text),
												data);
				predictor.Train();
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
				startButton.Enabled = true;

				string file = openFileDialog1.FileName;
				data = Data.GetData(file);
			}
		}
	}
}