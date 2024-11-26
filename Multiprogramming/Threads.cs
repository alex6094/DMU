using System.Diagnostics.Metrics;

namespace DMU.Multiprogramming
{
	class Counter
	{
		int value;

		public Counter()
		{
			value = 0;
		}

		public void Runner()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(value + " ");
				value++;
			}
		}
	}
}
