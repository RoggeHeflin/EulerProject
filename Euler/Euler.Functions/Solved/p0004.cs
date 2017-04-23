using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	public class p0004
	{
	
		public static long LargestPalindrome()
		{
			long largestP = 0;
			long val = 0;
			long i = 0;

			for (long a = 999; a >= 100; a--)
			{
				for (long b = a; b >= 100; b--)
				{
					val = a * b;
					i++;

					if(val < largestP)
					{
						break;
					}

					if(val > largestP && IsPalendrome(val))
					{
						largestP = val;
					}
				}
			}

			return largestP;
		}

		public static bool IsPalendrome(long val)
		{
			string x = val.ToString();

			int i = 0;
			int j = x.Length - 1;

			while(i < j)
			{
				if (x[i] != x[j])
				{
					return false;
				}

				i++;
				j--;
			}

			return true;
		}
	}
}
