using System;
using System.Threading;

namespace SimpleSleuth
{
	internal class Program
	{
		static public int menuAnswer = 0;
		static public char pageAnswer = 'a';
		static void Main()
		{

			MainMenu();
		}

		static void MainMenu()
		{
			
			Console.Clear();
			Console.WriteLine("Welcome to the wonderful MENU!");
			Console.WriteLine("1. Page 1.");
			Console.WriteLine("2. Page 2.");
			Console.WriteLine("3. Page 3.");
			Console.WriteLine("4. Page 4.");

			menuAnswer = Convert.ToInt32(Console.ReadLine());
			switch (menuAnswer)
			{
				case 1:
					Page1();
					break;
				case 2:
					Page2();
					break;
				case 3:
					Page3();
					break;
				case 4:
					Page4();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Sorry that option wasn't one from the Menu!");
					Console.WriteLine("The options were 1, 2, 3 or 4");
					Thread.Sleep(4000);
					Main();
					break;
			}
		}

		static void ExitScreen()
        {
			Console.Clear();
			Console.WriteLine("Thank you for sampling my menu!");
			Console.WriteLine("Goodbye!");
			Thread.Sleep(5000);
        }

		static void Page1()
		{
			Console.Clear();
			Console.WriteLine("Welcome to page 1!");
			Console.WriteLine("Why don't you sit a while and listen?");
			Thread.Sleep(4000);

			Console.Write("Back to Main Menu? y/n: ");

			pageAnswer = Convert.ToChar(Console.ReadLine());

			if (pageAnswer == 'y')
			{
				Main();
			}
			else if (pageAnswer == 'n')
			{
				ExitScreen();
			}


		}
		static void Page2()
		{
			Console.Clear();
			Console.WriteLine("Welcome to page 2!");
			Console.WriteLine("Why don't you sit a while and listen?");
			Thread.Sleep(4000);

			Console.Write("Back to Main Menu? y/n: ");

			pageAnswer = Convert.ToChar(Console.ReadLine());

			if (pageAnswer == 'y')
			{
				Main();
			}
			else if (pageAnswer == 'n')
            {
				ExitScreen();
            }
		}

		static void Page3()
		{
			Console.Clear();
			Console.WriteLine("Welcome to page 3!");
			Console.WriteLine("Why don't you sit a while and listen?");
			Thread.Sleep(4000);

			Console.Write("Back to Main Menu? y/n: ");

			pageAnswer = Convert.ToChar(Console.ReadLine());

			if (pageAnswer == 'y')
			{
				Main();
			}
			else if (pageAnswer == 'n')
			{
				ExitScreen();
			}
		}

		static void Page4()
		{
			Console.Clear();
			Console.WriteLine("Welcome to page 4!");
			Console.WriteLine("Why don't you sit a while and listen?");
			Thread.Sleep(4000);

			Console.Write("Back to Main Menu? y/n: ");

			pageAnswer = Convert.ToChar(Console.ReadLine());

			if (pageAnswer == 'y')
			{
				Main();
			}
			else if (pageAnswer == 'n')
			{
				ExitScreen();
			}

		}
	}
}

