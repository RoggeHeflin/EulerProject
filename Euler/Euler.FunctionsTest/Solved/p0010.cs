using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0010Test
	{
		const int l = 2000000;
		const long e = 142913828922;

		[TestMethod]
		public void BruteSequence()
		{
			long a = Euler.Functions.p0010.BruteSequence(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void BruteSequence_TruncatedLimits()
		{
			long a = Euler.Functions.p0010.BruteSequence_TruncatedLimit(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void BruteSequence_TruncatedLimit_MetaNumerics()
		{
			long a = Euler.Functions.p0010.BruteSequence_TruncatedLimit_MetaNumerics(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Sieve()
		{
			long a = Euler.Functions.p0010.Sieve(l);
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Sieve_Direct_Byte()
		{
			long a = Euler.Functions.Common.Generate.Primes.Sieve.Upto(l).AsParallel().Sum();
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void Sieve_Direct_Byte_Parallel()
		{
			long a = Euler.Functions.Common.Generate.Primes.Sieve.UptoParallel(l).AsParallel().Sum();
			Assert.AreEqual(e, a);
		}
	}
}