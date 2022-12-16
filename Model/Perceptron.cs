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

		private int ActivationFunction(double value)
		{
			if (value > 0) return 1;
			else return -1;
		}

		public int Calculate(HRg hrg)
		{
			double sum = 0;
			for(int i = 0; i < hrg.hr.Count; i++)
			{
				if (i == 1) sum += wt[i];
				else sum += wnt[i];
			}

			return ActivationFunction(sum);
		}

		public void AdjustWeights(int realValue)
		{
			for(int i = 0; i < wnt.Length; i++)
			{
				if (realValue == 1)
				{
					wnt[i]++;
					wt[i]++;
				}
				else if (realValue == -1)
				{
					wnt[i]--;
					wt[i]--;
				}
			}
		}
	}
}
