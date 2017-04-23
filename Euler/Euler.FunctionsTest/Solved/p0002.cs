using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0002Test
	{
		const int l = 4000000;
		const int e = 4613732;

		[TestMethod]
		public void SequenceBrute()
		{
			int a = Euler.Functions.p0002.SequenceBrute(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void SequenceSmart()
		{
			int a = Euler.Functions.p0002.SequenceSmart(l);
			Assert.AreEqual(e, a);
		}
	}
}


