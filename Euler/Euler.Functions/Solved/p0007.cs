using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
	///	What is the 10 001st prime number?
	/// </summary>
	public class p0007
	{
		public static long SequenceBrute_Primes(int l)
		{
			return Common.Generate.Primes.Items(l).Last();
		}
	}
}
