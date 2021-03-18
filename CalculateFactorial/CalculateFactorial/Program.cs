using System;

namespace CalculateFactorial
{
	class Program
	{
		static int Factorial(int number)
		{
			if (number < 1)
			{
				return 0;
			}
			else if (number == 1)
			{
				return 1;
			}
			else
			{
				return number * Factorial(number - 1);
			}
		}
		static void RunFactorial()
		{

			bool isNumber;
			do
			{
				Console.Write("Enter a number: ");
				isNumber = int.TryParse(
				Console.ReadLine(), out int number);
				if (isNumber)
				{
					Console.WriteLine(
					$"{number:N0}! = {Factorial(number):N0}");
				}
				else
				{
					Console.WriteLine("You did not enter a valid number!");
				}
			}
			while (isNumber);
		}
	
		static void Main(string[] args)
		{
		   RunFactorial();   
		}
	}
}
