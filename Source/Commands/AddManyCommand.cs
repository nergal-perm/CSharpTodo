/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpTodo.Commands
{
	/// <summary>
	/// addm "FIRST THING I NEED TO DO +project1 @context
	///	SECOND THING I NEED TO DO +project2 @context"
	///	  Adds FIRST THING I NEED TO DO to your todo.txt on its own line and
	///   Adds SECOND THING I NEED TO DO to you todo.txt on its own line.
	///   Project and context notation optional.
	/// </summary>
	public class AddManyCommand
	{
		public AddManyCommand()
		{
		}
	}
}
