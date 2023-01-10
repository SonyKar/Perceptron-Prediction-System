using PerceptronPredictionSystem.Model;

namespace PerceptronPredictionSystem
{
    public class Predictor
    {
        private readonly Perceptron[] perceptrons;
        private readonly HRg hrg;

		public Predictor(int perceptronNumber, int hrgSize)
        {
            perceptrons = new Perceptron[perceptronNumber];
            hrg = new HRg(hrgSize);

            for(int i = 0; i < perceptrons.Length; i++)
            {
				perceptrons[i] = new Perceptron(hrgSize);
            }
        }

        public void Train()
        {
            // while(file)
            int index = 1; // PC % perceptrons.Length;

			int predictedValue = perceptrons[index].Calculate(hrg);
            if (predictedValue != 1) // not equal real value
            {
				perceptrons[index].AdjustWeights(1); // real value
			}
            // hrg.AddValue(realValue);
        }
    }
}
