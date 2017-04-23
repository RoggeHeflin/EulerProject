using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	public class p0001
	{
		public static int SequenceBrute(int target)
		{
			int t = 0;

			for (int i = 3; i < target; i++)
			{
				if ((i % 3 == 0) || (i % 5 == 0))
				{
					t = t + i;
				}
			}

			return t;
		}

		public static int Formula(int target)
		{
			target = target - 1;

			int t = 3;
			int f = 5;

			int a = Common.SumDivisibleBy(target, t);
			int b = Common.SumDivisibleBy(target, f);
			int c = Common.SumDivisibleBy(target, t * f);

			return a + b - c;
		}
	}
}
