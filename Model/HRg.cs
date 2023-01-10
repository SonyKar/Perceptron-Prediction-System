namespace PerceptronPredictionSystem.Model
{
	public class HRg
	{
		public Queue<bool> hr { get; } = new Queue<bool>();

		public HRg(int maxSize = 8)
		{
			for (int i = 0; i < maxSize; i++) 
			{
				hr.Enqueue(false);
			}
		}

		public void AddValue(bool addValue)
		{
			hr.Dequeue();
			hr.Enqueue(addValue);
		}
	}
}
