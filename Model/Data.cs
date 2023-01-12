namespace PerceptronPredictionSystem.Model
{
	public class Data
	{
		public bool isTaken { get; private set; }
		public int PC { get; private set; }

		public Data(bool isTaken, int PC)
		{
			this.isTaken = isTaken;
			this.PC = PC;
		}

		public static Data[] GetData(string fileName)
		{
			string[] lines = File.ReadAllLines(fileName);
			Data[] data = new Data[lines.Length];
			int index = 0;
			foreach (string line in lines)
			{
				string[] lineParts = line.Split(' ');

				data[index++] = new Data(lineParts[0][0] == 'B', Int32.Parse(lineParts[1]));
			}

			return data;
		}
	}
}
