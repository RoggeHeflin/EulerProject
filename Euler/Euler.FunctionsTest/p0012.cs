using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0012Test
	{
		long e = 76576500;

		//[TestMethod]
		public void Test_StepBrute()
		{
			long a = Euler.Functions.p0012.Step_Brute();

			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Test_StepMath()
		{
			long a = Euler.Functions.p0012.Step_Math();

			Assert.AreEqual(e, a);
		}
	}
}