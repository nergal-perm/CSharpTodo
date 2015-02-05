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
		private static EnvironmentSettings _settings;
		
		public static void Main(string[] args)
		{
			if (args.Length > 0) {
				//TODO: Распарсить аргументы
				// Если есть ключи, то соответствующим образом изменить настройки
				if (args[0].StartsWith("-")) {
					_settings = new EnvironmentSettings(args[0].Substring(1));
					
				} else {
					_settings = new EnvironmentSettings("");
				}
				// Создать команду, используя оставшиеся аргументы
				Console.Out.WriteLine(args.ToString());
				//TODO: Выполнить команду
			} else {
				// Показать справочную систему
			}
		}

	}
}