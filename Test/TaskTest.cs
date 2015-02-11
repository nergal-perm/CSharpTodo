/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 10.02.2015
 * Time: 15:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NUnit.Framework;
using todotxtlib.net;

namespace CSharpTodo.Test
{
	[TestFixture]
	public class TaskTest {
		
		[Test]
		public void should_create_TaskList() {
			List<Task> todos = new List<Task>();
			todos.Add(new Task("A", new List<string> {"+first_project"}, new List<string> {"@only_context"},
			                   "Test task with all the properties set", DateTime.Today, "2015-02-28", 
			                   false, null));
			todos.Add(new Task("B", new List<string> {"+second_project"}, new List<string> {"@another_context"},
			                   "Test completed task with all the properties set", DateTime.Today, "2015-02-28", 
			                   true, DateTime.Today));
			
			TaskList tl = new TaskList(todos,0);
			
			Assert.AreEqual(2, tl.Count);
			
			foreach (string line in tl.ToNumberedOutput()) {
				Console.Out.WriteLine(line);
			}
		}
		
		[Test] 
		public void should_create_task_from_string() {
			string taskDescription = "x 2015-02-11 (B) 2015-02-01 Test completed task within @another_context and all the properties set +second_project due:2015-02-28";
			Task t = new Task(taskDescription);
			
			Assert.AreEqual(true, t.Completed);
			
			DateTime completedDate;
			DateTime.TryParse("2015-02-11",out completedDate);
			Assert.AreEqual(completedDate, t.CompletedDate);
			
			DateTime createdDate;
			DateTime.TryParse("2015-02-01",out createdDate);
			Assert.AreEqual(createdDate, t.CreatedDate);
			
			DateTime dueDate;
			DateTime.TryParse("2015-02-28",out dueDate);
			Assert.AreEqual(dueDate, DateTime.Parse(t.DueDate));
			
			Assert.AreEqual("B",t.Priority);
			// Проекты и контексты возвращаются в виде IEnumerable<string>, поэтому
			// нужно приводить их к конкретной реализации, например List<string>			
			Assert.IsTrue(new List<string>(t.Contexts).Contains("@another_context"));
			Assert.IsTrue(new List<string>(t.Projects).Contains("+second_project"));
			Assert.AreEqual(taskDescription, t.Raw);
			// Тело задачи содержит в себе все контексты, проекты и дату завершения,
			// потому что они могут быть частью описания задачи в понятном человеку
			// виде.
			// HACK: Нужно будет как-то избавляться от внутризадачных метаданных
			// при разных опциях вывода на экран.
			Assert.AreEqual("Test completed task within @another_context and all the properties set +second_project due:2015-02-28", t.Body);
			
		}
	}
}
