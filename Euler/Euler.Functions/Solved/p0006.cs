using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// The sum of the squares of the first ten natural numbers is,
	///			1^2 + 2^2 + ... + 10^2 = 385
	///	The square of the sum of the first ten natural numbers is,
	///			(1 + 2 + ... + 10)2 = 552 = 3025
	///	Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
	///	Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
	/// </summary>
	public class p0006
	{
		public static long SequenceBrute(int l)
		{
			int a = 0;
			int b = 0;

			for(int i = 1; i<= l ; i++)
			{
				a = a + i * i;
				b = b + i;
			}
			
			b = b * b;

			return b - a;
		}

		public static long Formula(int l)
		{
			long a = Common.SumSqToN(l);
			long b = (long)Math.Pow(Common.SumToN(l), 2);

			return b - a;
		}
	}
}
