using System;
using System.Threading;

namespace SimpleSleuth
{
    internal class Program
    {
	
        static void Main(string[] args)
        {
			public string answer = "";
			mainMenu();
        }

		static void mainMenu()
		{
			Console.Clear();
			Console.WriteLine("Welcome to the wonderful MENU!");
			Console.WriteLine("1. Page 1.");
			Console.WriteLine("2. Page 2.");
			Console.WriteLine("3. Page 3.");
			Console.WriteLine("4. Page 4.");
	
			answer = Console.ReadLine();
			switch(answer)
			{
				case 1:
				page1();
				break;
			case 2:
				page2();
				break;
			case 3:
				page3();
				break;
			case 4:
				page4();
				break;
			default:
				Console.Clear();
				Console.WriteLine("Sorry that option wasn't one from the Menu!");
				Console.WriteLine("The options were 1, 2, 3 or 4");
				Thread.Sleep(4000);
				mainMenu();
				break;
			}
		}

	static void page1(mainMenu())
	{
	    Console.WriteLine("Welcome to page 1!");
	    Console.WriteLine("Why don't you sit a while and listen?");
	    Thread.Sleep(4000);

			Console.Write("Back to Main Menu? y/n: ");

		answer = Console.ReadLine();

		if (answer == 'y') 
			{mainMenu()};
	}
}

