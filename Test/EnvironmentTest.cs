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
		private EnvironmentSettings pr;
		
		[TestFixtureSetUp]
		public void setUp() {
			pr = new EnvironmentSettings("");
		}
		
		[Test]
		public void should_get_file_paths()
		{
			Assert.AreEqual("D:/Documents/GD/Todo/todo.txt", pr.getFilePath("todo"), 
			                "Ожидался правильный путь к файлу todo.txt");
			Assert.AreEqual("D:/Documents/GD/Todo/done.txt", pr.getFilePath("done"), 
			                "Ожидался правильный путь к файлу done.txt");
			Assert.AreEqual("D:/Documents/GD/Todo/report.txt", pr.getFilePath("report"), 
			                "Ожидался правильный путь к файлу report.txt");
			
		}
		
		[Test]
		public void should_get_show_context() {
			Assert.IsTrue(pr.getShowContext());
			Assert.IsFalse(new EnvironmentSettings("@").getShowContext());
			Assert.IsTrue(new EnvironmentSettings("@@").getShowContext());
		}

		[Test]
		public void should_get_show_project() {
			Assert.IsTrue(pr.getShowProject());
			Assert.IsFalse(new EnvironmentSettings("+").getShowProject());
			Assert.IsTrue(new EnvironmentSettings("++").getShowProject());
		}		
		
		[Test]
		public void should_get_show_priority() {
			Assert.IsTrue(pr.getShowPriority());
			Assert.IsFalse(new EnvironmentSettings("P").getShowPriority());
			Assert.IsTrue(new EnvironmentSettings("PP").getShowPriority());
		}			
			
		[Test]
		public void should_get_color_mode() {
			Assert.IsTrue(pr.getColorMode());
			Assert.IsFalse(new EnvironmentSettings("p").getColorMode());
			Assert.IsTrue(new EnvironmentSettings("c").getColorMode());
		}			

	
	}
}
