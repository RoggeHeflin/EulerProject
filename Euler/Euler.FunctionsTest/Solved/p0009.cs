using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0009Test
	{
		const int l = 1000;
		const long e = 31875000;

		[TestMethod]
		public void SequenceBrute_TruncatedLimit()
		{
			long a = Euler.Functions.p0009.SequenceBrute_TruncatedLimit(l);
			Assert.AreEqual(e, a);
		}
	}
}