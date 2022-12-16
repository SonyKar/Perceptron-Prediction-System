using PerceptronPredictionSystem.Model;

namespace PerceptronPredictionSystem
{
    public class Predictor
    {
        private readonly Perceptron[] perceptrons;
        private readonly HRg hrg;
        private readonly int perceptronNumber;

        public int 

		public Predictor(int perceptronNumber, int hrgSize)
        {
            this.perceptronNumber = perceptronNumber;
            perceptrons = new Perceptron[perceptronNumber];
            hrg = new HRg(hrgSize);

            for(int i = 0; i < perceptronNumber; i++)
            {
				perceptrons[i] = new Perceptron(hrgSize);
            }
        }

        public void Train()
        {
            // while(file)
            int index = 1; // PC % perceptronNumber;

            int predictedValue = perceptrons[index].Calculate(hrg);
            if (predictedValue != 1) // not equal real value
            {
				perceptrons[index].AdjustWeights(1); // real value
			}
            // hrg.AddValue(realValue);
        }
    }
}
