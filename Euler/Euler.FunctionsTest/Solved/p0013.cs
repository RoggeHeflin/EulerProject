using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0013Test
	{
		string e = "5537376230";

		[TestMethod]
		public void Test_StepBrute()
		{
			BigInteger a = Euler.Functions.p0013.Step_Brute();

			Assert.AreEqual(e, a.ToString().Substring(0, e.Length));
		}
	}
}