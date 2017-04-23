using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0014Test
	{
		int limit = 1000000;
		int e = 837799;

		[TestMethod]
		public void Test_StepMath()
		{
			int a = Euler.Functions.p0014.Step_Brute(limit);

			Assert.AreEqual(e, a);
		}
	}
}