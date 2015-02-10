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
	/// listproj [TERM...]
	/// lsprj [TERM...]  
	///   Lists all the projects (terms that start with a + sign) in todo.txt.  
	///   If TERM specified, considers only tasks that contain TERM(s).
	/// </summary>
	public class ListProjectsCommand
	{
		public ListProjectsCommand()
		{
		}
	}
}
