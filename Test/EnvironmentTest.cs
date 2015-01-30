/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 15:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace C_Todo.Test
{
	[TestFixture]
	public class EnvironmentTest
	{
		[Test]
		public void should_get_file_paths()
		{
			EnvironmentSettings pr = new EnvironmentSettings();
			Assert.AreEqual("D:/Documents/GD/Todo/todo.txt", pr.getFilePath("todo"), 
			                "Ожидался правильный путь к файлу todo.txt");
			Assert.AreEqual("D:/Documents/GD/Todo/done.txt", pr.getFilePath("done"), 
			                "Ожидался правильный путь к файлу done.txt");
			Assert.AreEqual("D:/Documents/GD/Todo/report.txt", pr.getFilePath("report"), 
			                "Ожидался правильный путь к файлу report.txt");
			
		}
	}
}
