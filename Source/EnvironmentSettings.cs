/*
 * Created by SharpDevelop.
 * User: terekhov-ev
 * Date: 30.01.2015
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace C_Todo
{
	/// <summary>
	/// Description of EnvironmentSettings.
	/// </summary>
	public class EnvironmentSettings
	{
		public EnvironmentSettings() {
		}
		
			public string getFilePath(string fileName) {
				String dir_path = System.Configuration.ConfigurationManager.AppSettings["TODO_DIR"];
				return dir_path + fileName + ".txt";
			}		
	}
}
