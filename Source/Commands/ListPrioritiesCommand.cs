/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// listpri [PRIORITIES] [TERM...]
	/// lsp [PRIORITIES] [TERM...]  
	///   Displays all tasks prioritized PRIORITIES.  
	///   PRIORITIES can be a single one (A) or a range (A-C).  
	///   If no PRIORITIES specified, lists all prioritized tasks.  
	///   If TERM specified, lists only prioritized tasks that contain TERM(s).  
	///   Hides all tasks that contain TERM(s) preceded by a minus sign  
	///   (i.e. -TERM).
	/// </summary>
	public class ListPrioritiesCommand
	{
		public ListPrioritiesCommand()
		{
		}
	}
}
