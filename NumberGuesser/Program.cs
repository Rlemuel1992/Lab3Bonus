using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
	class Program
	{
		static void Main()
		{
			Player p = new BruteForce();


			int computerNumber = GetNumber(0, 100);

			string message = "Give me a number between 0 and 100";
			int count = 1;

			int userNumber = GetUserNum(message, 0, 100);
			int difference = DoSubtraction(userNumber, computerNumber);

			while (difference != 0)
			{
				count++;
				message = EvaluateNumbers(userNumber);
				userNumber = GetUserNum(message, 0, 100);
				difference = DoSubtraction(userNumber, computerNumber);
				
			}
			ReturnFinalMessage(count);
		}

		public static void ReturnFinalMessage(int number)
		{
			if (number == 1)
			{
				Console.WriteLine("GJ you guessed in 1 try!");
			}
			else
				Console.WriteLine($"Good work, you did it in {number} tries!");
		}
		public static string EvaluateNumbers(int number)
		{
			string message;
			
				if (number > 0)
				{
					if (number >= 10)
					{
						message = "Way too high!";
					}
					else
					{
						message = "a little high";
					}
				}
				else
				{
					if (number < -10)
					{
						message = "Way too low!";
					}
					else
					{
						message = "a little too low";
					}
				}
			return message;
		}
		public static int DoSubtraction(int number1, int number2)
		{
			return number1 - number2;
		}
		public static int GetNumber(int min, int max)
		{
			Random r = new Random();
			return r.Next(min, max);
		}
		public static int GetUserNum(string message, int min, int max)
		{
			int userNumber = min -1;

			while (userNumber < min || userNumber > max)
			{
				Console.WriteLine(message);
				while (!int.TryParse(Console.ReadLine(), out userNumber)) ;
			}
			return userNumber;
		}

	}
}
