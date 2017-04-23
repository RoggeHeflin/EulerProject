using System;
//using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler.FunctionsTest
{
	[TestClass]
	public class TemporaryTest
	{
		long l = 2000000;

		[TestMethod]
		public void TestEnumerable()
		{
			bool[] sieveArray = new bool[l];
			sieveArray = Enumerable.Repeat(true, sieveArray.Length - 1).ToArray();
		}
	}
}