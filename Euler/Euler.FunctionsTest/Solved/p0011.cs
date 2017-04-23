using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0011Test
	{
		const long e = 70600674;

		[TestMethod]
		public void SequenceBrute()
		{
			long a = Euler.Functions.p0011.SequenceBrute();
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void SequenceBrute_IfThen()
		{
			long a = Euler.Functions.p0011.SequenceBrute_IfThen();
			Assert.AreEqual(e, a);
		}
	}
}