using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2 + b^2 = c^2
	///		For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.  (3 + 4 + 5 = 12)
	///	There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	///	Find the product abc.
	/// </summary>
	public class p0009
	{
		public static long SequenceBrute_TruncatedLimit(int t)
		{
			for(int a = 1; a < t; a++)
			{
				for(int b = a + 1; b < t - a; b++)
				{
					int c = t - b - a;

					if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
					{
						return a * b * c;
					}
				}
			}
			return 0;
		}
	}
}
