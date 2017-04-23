using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0001Test
	{
		const int l = 1000;
		const int e = 233168;

		[TestMethod]
		public void SequenceBrute()
		{
			int a = Euler.Functions.p0001.SequenceBrute(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Formula()
		{
			int a = Euler.Functions.p0001.Formula(l);
			Assert.AreEqual(e, a);
		}
	}
}

