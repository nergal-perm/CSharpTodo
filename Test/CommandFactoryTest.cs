/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

using C_Todo.Commands;


namespace C_Todo.Test
{
	[TestFixture]
	public class CommandFactoryTest
	{
		[Test]
		public void TestMethod()
		{
			CommandFactory cf = new CommandFactory(new string[] {"-p", "add","\"Сделать что-то +проект @контекст\""});
			BaseCommand comm = cf.createCommand();
			Assert.IsTrue(typeof(AddCommand).IsInstanceOfType(comm), "Должна была быть создана команда на добавление записи");
			Assert.IsTrue(comm.DatePrepend);
		}
	}
}
