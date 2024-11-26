using DMU.Basic;
using DMU.Multiprogramming;
using System.Diagnostics.Metrics;

namespace DMU
{
	public class Program
	{

		static void Main(string[] args)
		{
			//Selektion.Opgave1();

			Selektion.Opgave3();

			Counter counter = new Counter();

			Thread tråd = new Thread(counter.Runner);

			tråd.Start();


		}
	}
}
