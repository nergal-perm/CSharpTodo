/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace C_Todo.Commands
{
	/// <summary>
	/// Description of CommandFactory.
	/// </summary>
	public class CommandFactory
	{
		private string _options;
		private string _action;
		private string[] _arguments;
		
		public CommandFactory(string[] args)
		{
			// TODO: Проверить, все ли символы допустимы
			if (args[0].StartsWith("-")) {
				_options = args[0].Substring(1);
			}
			_arguments = args;
		}
		
		public ICommand createCommand()
		{
			BaseCommand comm;
			switch(_action) {
				case "add":
					comm = new AddCommand();
					break;
				default:
					comm = new AddCommand();
					break;
			}
			setOptions(comm);
			return comm;
		}
		
		private void setOptions(BaseCommand comm) {
			foreach(string c in _options) {
				switch(c) {
					case "T":
						comm.DatePrepend=true;
						break;
					default:
						break;
				}
			}
		}
	}
}
