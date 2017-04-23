using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0006Test
	{
		const int l = 100;
		const long e = 25164150;

		[TestMethod]
		public void SequenceBrute()
		{
			long a = Euler.Functions.p0006.SequenceBrute(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Formula()
		{
			long a = Euler.Functions.p0006.Formula(l);
			Assert.AreEqual(e, a);
		}
	}
}