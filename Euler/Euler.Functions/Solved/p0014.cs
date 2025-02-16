﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Functions
{
	/// <summary>
	/// The following iterative sequence is defined for the set of positive integers:
	///
	///	n → n/2 (n is even)
	///	n → 3n + 1 (n is odd)
	///
	///	Using the rule above and starting with 13, we generate the following sequence:
	///
	///	13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
	///	It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
	///
	///	Which starting number, under one million, produces the longest chain?
	///
	///	NOTE: Once the chain starts the terms are allowed to go above one million.
	/// </summary>
	public class p0014
	{
		public static int Step_Brute(int limit)
		{
			int cCountMax = 0;
			int cCount = 0;
			int j = 0;

			for (int i = 1; i <= limit; i++)
			{
				cCount = Common.Generate.Collatz.Step_Brute(i).Count;

				if (cCount > cCountMax)
				{
					cCountMax = cCount;
					j = i;
				}
			}

			return j;
		}
	}
}