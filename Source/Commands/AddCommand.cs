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
	/// Description of AddCommand.
	/// </summary>
	public class AddCommand : ManyConsole.ConsoleCommand
	{
		public bool _appendDate;
		
		public AddCommand()
		{
			this.IsCommand("add", "Добавляет новую задачу в список дел");
			this.HasOption("t|time", "Добавляет дату создания к указанной задаче", t => _appendDate = true);
		}
		
		public override int Run(string[] remainingArguments)
		{
			throw new NotImplementedException();
		}
	}
}
