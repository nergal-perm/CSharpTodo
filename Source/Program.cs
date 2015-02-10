/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Security.Cryptography;
using ManyConsole;

namespace C_Todo
{
	class Program
	{
		public static EnvironmentSettings _settings;
		private static string _parameters = "";
		private static string _command = "";
		private static string[] _arguments;
		
		public static void Main(string[] args)
		{
			int index = 0;
			if (args.Length > 0) {
				try {
					if (args[0].StartsWith("-")) {
						_parameters = args[0].Substring(1);
						index = 1;
					}
					if (index < args.Length) {
						if (_command== null) { 
							_command = args[index]; 
							index +=1;
						}
						_arguments = new string[args.Length - index];
						System.Array.Copy(args, index, _arguments, 0, args.Length-index);
					}
				} catch (Exception e) {
					Console.Out.WriteLine(e.Message);
					Console.Out.WriteLine(e.StackTrace);
				}
			} else {
				// Показать справочную систему
				Console.Out.Write(showUsageHelp());
				return;
			}
			
			// Если есть ключи, то соответствующим образом изменить настройки
			_settings = new EnvironmentSettings(_parameters);
			// Создать команду, используя оставшиеся аргументы
			
			//TODO: Выполнить команду
			
		}
		
		private static string showUsageHelp() {
			return "TODO: Write short help system\n";
		}

	}
}