/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// list [TERM...]
	/// ls [TERM...]  
	///   Displays all tasks that contain TERM(s) sorted by priority with line  
	///   numbers.  Each task must match all TERM(s) (logical AND); to display  
	///   tasks that contain any TERM (logical OR), use  
	///   "TERM1\|TERM2\|..." (with quotes), or TERM1\\\|TERM2 (unquoted).  
	///   Hides all tasks that contain TERM(s) preceded by a  
	///   minus sign (i.e. -TERM). If no TERM specified, lists entire todo.txt.
	/// </summary>
	public class ListCommand
	{
		public ListCommand()
		{
		}
	}
}
