﻿/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

using C_Todo.Commands;
using ManyConsole;
using NUnit.Framework;

namespace C_Todo.Test
{
	[TestFixture]
	public class AddCommandTest
	{
        private static IEnumerable<ConsoleCommand> GetCommands()
        {
            return ConsoleCommandDispatcher.FindCommandsInSameAssemblyAs(typeof(Program));
        }		
		
		[Test]
		public void TestMethod()
		{
			ConsoleCommand target = new AddCommand();
			string[] args = {"add", "-t", "add sample task"};
			StringWriter sw = new StringWriter();
			ConsoleCommandDispatcher.DispatchCommand(target, args, sw);
			Console.Out.Write(sw.ToString());
		}
	}
}
