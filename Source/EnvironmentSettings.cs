/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace CSharpTodo
{
	/// <summary>
	/// Глобально определяемые и существующие на момент выполнения команды
	/// настройки приложения
	/// </summary>
	public class EnvironmentSettings
	{
		private const string PREPEND_DATE="PREPEND_DATE";
		
		public EnvironmentSettings(string args) {
			localSettings = new PropertyCollection();
			
			// @ - не отображать информацию о контексте в списке задач
			// @@ - отображать информацию о контексте (по умолчанию)
			if (args.Contains("@@")) {
				localSettings.Add("SHOW_CONTEXT", true);
			} else if (args.Contains("@")) {
				localSettings.Add("SHOW_CONTEXT", false);
			} else {
				localSettings.Add("SHOW_CONTEXT", System.Configuration.ConfigurationManager.AppSettings["SHOW_CONTEXT"]);
			}
			
			// + - не отображать информацию о проектах в списке задач
			// ++ - отображать информацию о проектах в списке задач (по умолчанию)
			if (args.Contains(@"++")) {
				localSettings.Add("SHOW_PROJECT", true);
			} else if (args.Contains(@"+")) {
				localSettings.Add("SHOW_PROJECT", false);
			} else {
				localSettings.Add("SHOW_PROJECT", System.Configuration.ConfigurationManager.AppSettings["SHOW_PROJECT"]);
			}
			
			// c - режим отображения цветов в консоли (по умолчанию)
			// p - монохромный режим консоли
			if (args.Contains("c")) {
				localSettings.Add("COLOR_MODE", true);
			} else if (args.Contains("p")) {
				localSettings.Add("COLOR_MODE", false);
			} else {
				localSettings.Add("COLOR_MODE", System.Configuration.ConfigurationManager.AppSettings["COLOR_MODE"]);
			}		

			// P - не отображать метки приоритета задач
			// PP - отображать метки приоритета задач (по умолчанию) 			
			if (args.Contains("PP")) {
				localSettings.Add("SHOW_PRIORITY", true);
			} else if (args.Contains("P")) {
				localSettings.Add("SHOW_PRIORITY", false);
			} else{
				localSettings.Add("SHOW_PRIORITY", System.Configuration.ConfigurationManager.AppSettings["SHOW_PRIORITY"]);
			}	

			// a - не архивировать задачи при завершении
			// A - архивировать задачи при завершении (по умолчанию)
			if (args.Contains("A")) {
				localSettings.Add("AUTO_ARCHIVE", true);
			} else if (args.Contains("a")) {
				localSettings.Add("AUTO_ARCHIVE", false);
			} else {
				localSettings.Add("AUTO_ARCHIVE", System.Configuration.ConfigurationManager.AppSettings["AUTO_ARCHIVE"]);
			}

			// t - добавлять к каждой новой задаче дату создания
			// T - не добавлять дату создания к новым задачам (по умолчанию)
			if (args.Contains("t")) {
				localSettings.Add(PREPEND_DATE, true);
			} else if (args.Contains("T")) {
				localSettings.Add(PREPEND_DATE, false);
			} else {
				localSettings.Add(PREPEND_DATE, System.Configuration.ConfigurationManager.AppSettings[PREPEND_DATE]);
			}	

			// n - не сохранять постоянные номера задач, удалять пустые строки (по умолчанию)
			// N - не удалять пустые строки, сохранять постоянные номера задач
			if (args.Contains("N")) {
				localSettings.Add("PRESERVE_LINE_NUMBERS", true);
			} else if (args.Contains("n")) {
				localSettings.Add("PRESERVE_LINE_NUMBERS", false);
			} else {
				localSettings.Add("PRESERVE_LINE_NUMBERS", System.Configuration.ConfigurationManager.AppSettings["PRESERVE_LINE_NUMBERS"]);
			}
		}
		
		private PropertyCollection localSettings;
		
		/// <summary>
		/// На основе данных в файле конфигурации определяет путь к указанному
		/// файлу (список дел, архив, отчет)
		/// </summary>
		/// <param name="fileName">Имя файла, для которого нужно получить путь</param>
		/// <returns>Полный путь к требуемому файлу</returns>
		public string getFilePath(string fileName) {
			String dir_path = System.Configuration.ConfigurationManager.AppSettings["TODO_DIR"];
			return dir_path + fileName + ".txt";
		}
		
		public bool getShowContext() {
			if (!localSettings.ContainsKey("SHOW_CONTEXT")) {
				localSettings.Add("SHOW_CONTEXT", System.Configuration.ConfigurationManager.AppSettings["SHOW_CONTEXT"]);
			}
			return Boolean.Parse(localSettings["SHOW_CONTEXT"].ToString());
		}
		
		public bool getShowProject() {
			if (!localSettings.ContainsKey("SHOW_PROJECT")) {
				localSettings.Add("SHOW_PROJECT", System.Configuration.ConfigurationManager.AppSettings["SHOW_PROJECT"]);
			}
			return Boolean.Parse(localSettings["SHOW_PROJECT"].ToString());
		}		
		
		public bool getShowPriority() {
			if (!localSettings.ContainsKey("SHOW_PRIORITY")) {
				localSettings.Add("SHOW_PRIORITY", System.Configuration.ConfigurationManager.AppSettings["SHOW_PRIORITY"]);
			}
			return Boolean.Parse(localSettings["SHOW_PRIORITY"].ToString());
		}	

		public bool getColorMode() {
			if (!localSettings.ContainsKey("COLOR_MODE")) {
				localSettings.Add("COLOR_MODE", System.Configuration.ConfigurationManager.AppSettings["COLOR_MODE"]);
			}
			return Boolean.Parse(localSettings["COLOR_MODE"].ToString());
		}	
		
		public bool getPrependDate() {
			return Boolean.Parse(localSettings[PREPEND_DATE].ToString());
		}

		public override string ToString() {
			StringBuilder sb = new StringBuilder();
			foreach (string key in localSettings.Keys) {
				sb.Append(key).Append(": ").Append(localSettings[key].ToString()).AppendLine();
			}
				
			return sb.ToString();
		}

			
	}
}
