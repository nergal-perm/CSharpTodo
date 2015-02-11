/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Text;
using todotxtlib.net;

namespace CSharpTodo.Commands
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
			this.HasAdditionalArguments(1, " <Текст задачи>");
			this.AllowsAnyAdditionalArguments("");
		}
		
		public override int Run(string[] remainingArguments) {
			StringBuilder sb = new StringBuilder();

			// Should we add Date before the Task title?
			if (Program._settings.getPrependDate()) {
				sb.AppendFormat("{0:yyyy-MM-dd} ", DateTime.Today);
			}
			
			sb.Append(string.Join(" ", remainingArguments));
			
			string _filePath = Program._settings.getFilePath("todo");
			try {
				TaskList tl = new TaskList(_filePath);
				Task t = new Task(sb.ToString());
				tl.Add(t);
				tl.SaveTasks(_filePath);
				return tl.IndexOf(t);
			} catch (Exception e) {
				Console.Out.WriteLine(e.Message);
				Console.Out.WriteLine(e.StackTrace);
				return -1;
			}
			
			//throw new NotImplementedException();
		}
	}
}
