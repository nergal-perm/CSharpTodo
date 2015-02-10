/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// move ITEM# DEST [SRC]
	/// mv ITEM# DEST [SRC]  
	///   Moves a line from source text file (SRC) to destination text file (DEST).  
	///   Both source and destination file must be located in the directory defined  
	///   in the configuration directory.  When SRC is not defined  
	///   it's by default todo.txt.
	/// </summary>
	public class MoveCommand
	{
		public MoveCommand()
		{
		}
	}
}
