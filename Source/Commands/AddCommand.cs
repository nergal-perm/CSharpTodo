/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using todotxtlib.net;

namespace C_Todo.Commands
{
	/// <summary>
	/// add "THING I NEED TO DO +project @context"
	/// a "THING I NEED TO DO +project @context"
	///   Adds THING I NEED TO DO to your todo.txt file on its own line.
	///   Project and context notation optional.
	///   Quotes optional.
	/// </summary>
	public class AddCommand : ManyConsole.ConsoleCommand
	{
		public AddCommand() {
			this.IsCommand("add", "Добавляет новую задачу в список дел");
			this.HasAdditionalArguments(1, "<Текст задачи>");
			this.CheckRequiredArguments();
		}
		
		public override int Run(string[] remainingArguments) {
			string _filePath = Program._settings.getFilePath("todo");
			try {
				TaskList tl = new TaskList(_filePath);
				tl.Add(new Task(remainingArguments[0]));
				tl.SaveTasks(_filePath);
				return 0;
			} catch (Exception e) {
				Console.Out.WriteLine(e.Message);
				Console.Out.WriteLine(e.StackTrace);
				return 1;
			}
			
			//throw new NotImplementedException();
		}
	}
}
