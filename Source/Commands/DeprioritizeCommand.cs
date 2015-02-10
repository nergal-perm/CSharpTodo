/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// depri ITEM#[, ITEM#, ITEM#, ...]
	/// dp ITEM#[, ITEM#, ITEM#, ...]
	///   Deprioritizes (removes the priority) from the task(s)
	///   on line ITEM# in todo.txt.
	/// </summary>
	public class DeprioritizeCommand
	{
		public DeprioritizeCommand()
		{
		}
	}
}
