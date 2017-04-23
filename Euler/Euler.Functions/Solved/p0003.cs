using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class p0003
	{
		public static long LargestPrime(long limit)
		{
			long newnumm = limit;
			long largestFact = 0;

			int counter = 2;

			while (counter * counter <= newnumm)
			{
				if (newnumm % counter == 0)
				{
					newnumm = newnumm / counter;
					largestFact = counter;
				}
				else
				{
					counter++;
				}
			}

			if (newnumm > largestFact)
			{ // the remainder is a prime number
				largestFact = newnumm;
			}

			Console.WriteLine("Largest Prime: {0}", largestFact);
			
			return largestFact;
		}

		public static long LargestPrimeV2(long limit)
		{
			long lastFactor;

			if (limit % 2 == 0)
			{
				limit = limit % 2;
				lastFactor = 2;

				while (limit % 2 ==0)
				{
					limit = limit / 2;
				}
			}
			else
			{
				lastFactor = 1;
			}

			long factor = 3;

			long maxFactor = (long)Math.Sqrt(limit);

			while ((limit > 1) && (factor <=  maxFactor))
			{
				if (limit % factor == 0)
				{
					limit = limit / factor;
					lastFactor = factor;
					while (limit % factor == 0)
					{
						limit = limit / factor;
					}
					maxFactor = (long)Math.Sqrt(limit);
				}
				factor = factor + (long)2;
			}
			if (limit == 1)
			{
				return lastFactor;
			}
			else
			{
				return limit;
			}
		}
	}
}
