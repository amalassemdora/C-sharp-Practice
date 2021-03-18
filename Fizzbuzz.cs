/*
 Exercise 3.3 – Practice loops and operators
FizzBuzz is a group word game for children to teach them about division. Players 
take turns to count incrementally, replacing any number divisible by three with 
the word fizz, any number divisible by five with the word buzz, and any number 
divisible by both with fizzbuzz.
*/
using System;

namespace Fizzbuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for(int n=1; n <= 100; n++)
			{
				if (n % 3 == 0 && n%5==0)
				{
					Console.Write("fizzbuzz,");
				}
				else if(n % 3 == 0) 
				{
					Console.Write("fizz,");
				}
				else if (n % 5 == 0)
				{
					Console.Write("buzz,");
				}
				else
				{
					Console.Write(n + ", ");
				}
			}
			Console.ReadKey();
		}
	}
}
