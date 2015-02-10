/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// pri ITEM# PRIORITY
	/// p ITEM# PRIORITY
	///   Adds PRIORITY to task on line ITEM#.  If the task is already 
	///   prioritized, replaces current priority with new PRIORITY.
	///   PRIORITY must be a letter between A and Z.
	/// </summary>
	public class PrioritizeCommand
	{
		public PrioritizeCommand()
		{
		}
	}
}
