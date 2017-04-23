using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0003Test
	{
		const long l = 600851475143;
		const long e = 6857;
		
		[TestMethod]
		public void LargestPrimeTest()
		{
			long a = Euler.Functions.p0003.LargestPrime(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void LargestPrimeV2Test()
		{
			long a = Euler.Functions.p0003.LargestPrimeV2(l);
			Assert.AreEqual(e, a);
		}
	}
}


