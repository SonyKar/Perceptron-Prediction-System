namespace PerceptronPredictionSystem.Model
{
	public class HRg
	{
		public Queue<int> hr { get; } = new Queue<int>();

		public HRg(int maxSize = 8)
		{
			for (int i = 0; i < maxSize; i++) 
			{
				hr.Enqueue(-1);
			}
		}

		public void AddValue(int addValue)
		{
			hr.Dequeue();
			hr.Enqueue(addValue);
		}
	}
}
