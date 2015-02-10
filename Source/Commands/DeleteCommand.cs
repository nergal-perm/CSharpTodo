/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// del ITEM# [TERM]
	/// rm ITEM# [TERM]
	///   Deletes the task on line ITEM# in todo.txt.
	///   If TERM specified, deletes only TERM from the task.
	/// </summary>
	public class DeleteCommand
	{
		public DeleteCommand()
		{
		}
	}
}
