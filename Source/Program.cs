/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace C_Todo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//TODO: Распарсить аргументы и создать команду
			
			//TODO: Выполнить команду 
			if (args.Length > 0) {
				Console.WriteLine("Hello World!");				
				Console.WriteLine("Command: " + args[0]);
				Console.ReadKey();
			} else {
				Console.WriteLine("Input command:");
				string userInput = Console.ReadLine();
				while (userInput != "exit") {
					userInput = Console.ReadLine();
				}				
			}
		}
	}
}