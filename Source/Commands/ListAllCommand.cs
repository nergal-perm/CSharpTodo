/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// listall [TERM...]
	/// lsa [TERM...]  
	/// Displays all the lines in todo.txt AND done.txt that contain TERM(s)  
	/// sorted by priority with line  numbers.  Hides all tasks that  
	/// contain TERM(s) preceded by a minus sign (i.e. -TERM).  If no  
	/// TERM specified, lists entire todo.txt AND done.txt  
	/// concatenated and sorted.
	/// </summary>
	public class ListAllCommand
	{
		public ListAllCommand()
		{
		}
	}
}
