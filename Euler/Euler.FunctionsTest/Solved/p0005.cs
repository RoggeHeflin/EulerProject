using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class p0005Test
	{
		const int l = 20;
		const long e = 232792560;

		[TestMethod]
		public void SequenceBrute()
		{
			long a = Euler.Functions.p0005.SequenceBrute();
			Assert.AreEqual(e, a);
		}

		[TestMethod]
		public void SequenceSmart()
		{
			long a = Euler.Functions.p0005.SequenceSmart();
			Assert.AreEqual(e, a);
		}
	
		[TestMethod]
		public void FormulaPrimes()
		{
			long a = Euler.Functions.p0005.FormulaPrimes(l);
			Assert.AreEqual(e, a);
		}
	}
}