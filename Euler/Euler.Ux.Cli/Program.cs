using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Ux.Cli
{
	class Program
	{
		static void Main(string[] args)
		{
			//int i = 2000000;

			//Console.WriteLine("Is {0} Prime: {1}", i, Euler.Functions.Common.SumPrimeSieve(i));
			
			//foreach (int j in Euler.Functions.Common.Generate.Fibonacci.Upto(21))
			//{
			//	Console.WriteLine("Is {0} Prime: {1}", j, Euler.Functions.Common.IsPrime(21));
			//}

			//Console.WriteLine("Is {0} Prime: {1}", i, Euler.Functions.Common.IsPrime(i));

			//Console.WriteLine("Answer: {0}", Euler.Functions.p0012.NumberOfDivisors(28));

			//Console.WriteLine("Smallest Triangle with 500 Divisors: {0}", Euler.Functions.p0012.Step_Math());

			Console.WriteLine(string.Empty);

			int i = 1000000;

			int c = Euler.Functions.p0014.Step_Brute(i);

			Console.WriteLine("The longest sequence is: {0}", c);


			Console.WriteLine(string.Empty);
			Console.WriteLine("Done!");
			Console.ReadKey();
		}
	}
}
