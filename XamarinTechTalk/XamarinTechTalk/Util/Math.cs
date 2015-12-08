using System;
using System.Threading.Tasks;

namespace XamarinTechTalk
{
	public static class Math
	{
		public static long Sum(long number1, long number2)
		{
			return number1 + number2;
		}

		public static async Task<long> SumAsync(long number1, long number2)
		{
			await Task.Delay(2500);
			return number1 + number2;
		}
	}
}

