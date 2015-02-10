/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// listfile [SRC [TERM...]]
	/// lf [SRC [TERM...]]  
	///   Displays all the lines in SRC file located in the todo.txt directory,  
	///   sorted by priority with line  numbers.  If TERM specified, lists  
	///   all lines that contain TERM(s) in SRC file.  Hides all tasks that  
	///   contain TERM(s) preceded by a minus sign (i.e. -TERM).  
	///   Without any arguments, the names of all text files in the todo.txt  
	///   directory are listed.
	/// </summary>
	public class ListFileCommand
	{
		public ListFileCommand()
		{
		}
	}
}
