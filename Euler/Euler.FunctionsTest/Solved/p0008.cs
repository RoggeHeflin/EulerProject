using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0008Test
	{
		[TestMethod]
		public void SequenceBrute_04()
		{
			int l = 4;
			long e = 5832;

			long a = Euler.Functions.p0008.SequenceBrute(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void SequenceBrute_13()
		{
			int l = 13;
			long e = 23514624000;

			long a = Euler.Functions.p0008.SequenceBrute(l);
			Assert.AreEqual(e, a);
		}
	}
}