using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0007Test
	{
		const int l = 10001;
		const long e = 104743;

		[TestMethod]
		public void SequenceBrute_Primes()
		{
			long a = Euler.Functions.p0007.SequenceBrute_Primes(l);
			Assert.AreEqual(e, a);
		}
	}
}