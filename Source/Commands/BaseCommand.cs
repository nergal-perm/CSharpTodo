/*
 * Created by SharpDevelop.
 * User: Yosemite
 * Date: 02.02.2015
 * Time: 6:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace C_Todo.Commands
{
	/// <summary>
	/// Description of BaseCommand.
	/// </summary>
	public abstract class BaseCommand: ICommand
	{
		private bool _datePrepend;
		
		public bool DatePrepend {
			get { return _datePrepend; }
			set { _datePrepend = value;}
		}
		
		public BaseCommand()
		{
		}
		
		public string Do()
		{
			throw new NotImplementedException();
		}
	}
}
