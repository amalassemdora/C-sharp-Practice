using System;

namespace ConvertingNumbersFromOrdinalToCardinal
{
	class Program
	{
		static String CardinalToOrdinal(int number)
		{
			switch (number)
			{
				case 11:
				case 12:
				case 13:
					return $"{number}th";
					
				default:
					String numberAsText = number.ToString();
					int index = numberAsText.Length - 1;
					char lastDigit = numberAsText[index];
					String suffix;
					switch (lastDigit)
					{
						case '1':
							suffix = "st";
							break;
						case '2':
							suffix = "nd";
							break;
						case '3':
							suffix = "rd";
							break;
						default:
							suffix = "th";
							break;
					}
					return $"{number}{suffix}";
			}	
		}
		static void RunCardinalToOrdinal()
		{
			for(int i = 1; i <= 40; i++)
			{
				Console.Write(CardinalToOrdinal(i)+"  ");
			}
			Console.WriteLine();
		}
		static void Main()
		{
		    RunCardinalToOrdinal();
			Console.ReadKey();
		}
		
	}
}
