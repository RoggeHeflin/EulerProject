using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0004Test
	{
		const int e = 906609;

		[TestMethod]
		public void LargestPalindrome()
		{
			long a = Euler.Functions.p0004.LargestPalindrome();
			Assert.AreEqual(e, a);
		}
	}
}


