namespace PerceptronPredictionSystem.Model
{
	public class Perceptron
	{
		private int[] wt;
		private int[] wnt;

		public Perceptron(int size = 8)
		{
			wt = new int[size];
			wnt = new int[size];

			for(int i = 0; i < size; i++)
			{
				wt[i] = 1;
				wnt[i] = -1;
			}
		}

		private bool ActivationFunction(double value)
		{
			return value >= 0;
		}

		public bool Calculate(HRg hrg)
		{
			double sum = 0;
			int i = 0;
			foreach (bool realValue in hrg.hr)
			{
				sum += realValue ? wt[i++] : wnt[i++];
			}

			return ActivationFunction(sum);
		}

		public void AdjustWeights(bool realValue)
		{
			int delta = realValue ? 1 : -1;
			for(int i = 0; i < wnt.Length; i++)
			{
				wnt[i] += delta;
				wt[i] += delta;
			}
		}
	}
}
