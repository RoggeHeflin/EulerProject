using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	/// </summary>
	public class p0005
	{
		public static long SequenceBrute()
		{
			int i = 1;

			while (DivisibleByAll(i))
			{
				i++;
			}

			return i;
		}

		public static long SequenceSmart()
		{
			int i = 20;

			while (DivisibleByAll(i))
			{
				i+=20;
			}

			return i;
		}

		public static long FormulaPrimes(int l)
		{
			long[] primes = Common.Generate.Primes.Upto(l).ToArray<long>();

			long result = 1;

			foreach(int p in primes)
			{
				int a = (int)Math.Floor(Math.Log(l) / Math.Log(p));
				result *= ((int)Math.Pow(p, a));
			}

			return result;
		}

		private static bool DivisibleByAll(int i)
		{
			return (bool)(i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
				 i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
				 i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
				 i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
				 i % 18 != 0 || i % 19 != 0 || i % 20 != 0);
		}
	}
}
