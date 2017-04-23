using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	public class Common
	{
		/// <summary>
		/// Euler 0001
		/// </summary>
		public static int SumDivisibleBy(int target, int n)
		{
			int p = target / n;

			return n * (p * (p + 1)) / 2;
		}

		/// <summary>
		/// Euler 0002
		/// </summary>
		public static bool IsEven(int number)
		{
			return (number % 2 == 0);
		}

		public static class Generate
		{
			public static class Collatz
			{
				public static List<long> Step_Brute(long limit)
				{
					List<long> collatz = new List<long>();

					long i = limit;
					collatz.Add(i);

					while(i > 1)
					{
						i = NextValue(i);
						collatz.Add(i);
					}

					return collatz;
				}

				private static long NextValue(long i)
				{
					return (i % 2 == 0) ? i / 2 : 3 * i + 1;
				}
			}

			public static class Fibonacci
			{
				public static List<int> Upto(int limit)
				{
					List<int> fibs = new List<int>();

					int a = 1;
					int b = 1;

					fibs.Add(0);
					fibs.Add(a);
					fibs.Add(b);

					while (a + b <= limit)
					{
						a = a + b;
						b = a + b;
						fibs.Add(a);
						fibs.Add(b);
					}

					return fibs;
				}
			}

			public static class Primes
			{
				/// <summary>
				/// Euler 0005
				/// </summary>
				public static List<long> Upto(int limit)
				{
					List<long> primes = new List<long>();

					bool isPrime;
					int j;

					primes.Add(2);

					for (int i = 3; i <= limit; i += 2)
					{
						j = 0;
						isPrime = true;

						while (primes[j] * primes[j] <= i)
						{
							if (i % primes[j] == 0)
							{
								isPrime = false;
								break;
							}
							j++;
						}
						if (isPrime)
						{
							primes.Add(i);
						}
					}

					return primes;
				}

				/// <summary>
				/// Euler 0007
				/// </summary>
				public static List<long> Items(int items)
				{
					List<long> primes = new List<long>();

					bool isPrime;
					int j;

					primes.Add(2);

					int i = 3;

					while (primes.Count < items)
					{

						j = 0;
						isPrime = true;

						while (primes[j] * primes[j] <= i)
						{
							if (i % primes[j] == 0)
							{
								isPrime = false;
								break;
							}
							j++;
						}
						if (isPrime)
						{
							primes.Add(i);
						}

						i += 2;
					}

					return primes;
				} 

				public static class Sieve
				{
					public static List<long> Upto(int limit)
					{
						int sieveBound = (int)(limit - 1) / 2;
						int crossLimit = ((int)(Math.Sqrt(limit) - 1)) / 2;

						bool[] sieveArray = new bool[sieveBound];

						for (int i = 1; i <= crossLimit; i++)
						{
							if (sieveArray[i] == false)
							{
								for (int j = 2 * i * (i + 1); j < sieveBound; j += (2 * i) + 1)
								{
									sieveArray[j] = true;
								}
							}
						}

						List<long> sieve = new List<long>();

						sieve.Add(2);

						for (int i = 1; i < sieveBound; i++)
						{
							if (sieveArray[i] == false)
							{
								sieve.Add(2 * i + 1);
							}
						}

						return sieve;
					}

					public static List<long> UptoParallel(int limit)
					{
						int sieveBound = (int)(limit - 1) / 2;
						int crossLimit = ((int)(Math.Sqrt(limit) - 1)) / 2;

						bool[] sieveArray = new bool[sieveBound];

						Parallel.For(1, crossLimit, (i) =>
						{
							if (sieveArray[i] == false)
							{
								for (int j = 2 * i * (i + 1); j < sieveBound; j += (2 * i) + 1)
								{
									sieveArray[j] = true;
								}
							}
						});

						System.Collections.Concurrent.ConcurrentBag<long> sieve = new System.Collections.Concurrent.ConcurrentBag<long>();

						sieve.Add(2);

						Parallel.For(1, sieveBound, (i) =>
						{
							if (sieveArray[i] == false)
							{
								sieve.Add(2 * i + 1);
							}
						});

						return sieve.AsParallel().OrderBy(c => c).ToList<long>();
					}
				}
			}
		}

		/// <summary>
		/// Euler 0006
		/// </summary>
		public static int SumToN(int n)
		{
			return (n * (n + 1)) / 2;
		}

		/// <summary>
		/// Euler 0006
		/// </summary>
		public static int SumSqToN(int n)
		{
			return (2 * n + 1) * (n + 1) * n / 6;
		}

		/// <summary>
		/// Euler 0007, 0010
		/// </summary>
		public static bool IsPrime(int n)
		{
			if (n <= 1)
			{
				return false;
			}
			else if (n < 4)
			{
				return true;
			}
			else if (n % 2 == 0)
			{
				return false;
			}
			else if (n < 9)
			{
				return true;
			}
			else if (n % 3 == 0)
			{
				return false;
			}
			else
			{
				int r = (int)Math.Floor(Math.Sqrt(n));
				int f = 5;

				while (f <= r)
				{
					if (n % f == 0) return false;
					if (n % (f + 2) == 0) return false;
					f += 6;
				}
				return true;
			}
		}
	}
}

public static class ArrayExtensions
{
	public static T[] Init<T>(this T[] array, T defaultVaue) where T : struct
	{
		if ((array != null) || (array.Length > 0))
		{
			Enumerable.Repeat(defaultVaue, array.Length - 1).AsParallel().ToArray();
		}

		return array;
	}
}

