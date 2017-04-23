using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	///	Find the sum of all the primes below two million.
	/// </summary>
	public class p0010
	{
		public static long BruteSequence(int l)
		{
			long s = 0;

			for (int i = (int)s; i <= l; i ++)
			{
				if(Common.IsPrime(i))
				{
					s += i;
				}
			}

			return s;
		}

		public static long BruteSequence_TruncatedLimit(int l)
		{
			long s = 5;

			for (int i = (int)s; i <= l; i += 2)
			{
				if (Common.IsPrime(i))
				{
					s += i;
				}
			}

			return s;
		}

		public static long BruteSequence_TruncatedLimit_MetaNumerics(int l)
		{
			long s = 5;

			for (int i = (int)s; i <= l; i += 2)
			{
				if (Meta.Numerics.Functions.AdvancedIntegerMath.IsPrime(i))
				{
					s += i;
				}
			}

			return s;
		}

		public static long Sieve(int l)
		{
			return Common.Generate.Primes.Sieve.Upto(l).AsParallel().Sum();
		}
	}
}
