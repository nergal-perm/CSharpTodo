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

namespace C_Todo
{
	/// <summary>
	/// Глобально определяемые и существующие на момент выполнения команды
	/// настройки приложения
	/// </summary>
	public class EnvironmentSettings
	{
		public EnvironmentSettings(string args) {
			localSettings = new PropertyCollection();
			if (args.Contains("@")) {
				localSettings.Add("SHOW_CONTEXT", false);
			} else {
				localSettings.Add("SHOW_CONTEXT", System.Configuration.ConfigurationManager.AppSettings["SHOW_CONTEXT"]);
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
		
		public void setShowContext() {
			
		}
		
	}
}
