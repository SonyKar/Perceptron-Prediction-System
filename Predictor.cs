using PerceptronPredictionSystem.Model;

namespace PerceptronPredictionSystem
{
    public class Predictor
    {
        private readonly Perceptron[] perceptrons;
        private readonly HRg hrg;
        private readonly Data[] data;

        public int totalJumps { get; private set; }
        public int totalJumpsTaken { get; private set; }
        public int totalJumpsTakenPredicted { get; private set; }
		public int totalJumpsNotTaken { get; private set; }
		public int totalJumpsNotTakenPredicted { get; private set; }

		public Predictor(int perceptronNumber, int hrgSize, Data[] data)
        {
            perceptrons = new Perceptron[perceptronNumber];
            hrg = new HRg(hrgSize);
            this.data = data;
            totalJumps = data.Length;

            for(int i = 0; i < perceptrons.Length; i++)
            {
				perceptrons[i] = new Perceptron(hrgSize);
            }
        }

        public void Train()
        {
            foreach (Data dataPiece in data)
            {
				int index = dataPiece.PC % perceptrons.Length;

				bool predictedValue = perceptrons[index].Calculate(hrg);

                if (dataPiece.isTaken) totalJumpsTaken++;
				else totalJumpsNotTaken++;

				if (predictedValue != dataPiece.isTaken) // not equal real value
				{
					perceptrons[index].AdjustWeights(dataPiece.isTaken); // real value
				}
                else
                {
					if (predictedValue) totalJumpsTakenPredicted++;
					else totalJumpsNotTakenPredicted++;
				}
				hrg.AddValue(dataPiece.isTaken);
			}
		}
    }
}
