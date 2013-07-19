/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 21.11.2008
 * Zeit: 19:26
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using System.Windows.Forms;

namespace WLA
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings
	{
		public Settings()
		{
		}
		
		public static int getInt(string key, int def) 
		{
			try {
				switch(key) {
					case "speakingPauseInt":
					case "chanceInt":
					case "intervalInt":
					case "intervalUnit":
						return Int32.Parse(Application.UserAppDataRegistry.GetValue(key).ToString());
					default:
						//MessageBox.Show(key);
						return def;
				}
			} catch(Exception) {
				//MessageBox.Show(key);
				return def;
			}
		}
		
		public static int getInt(string key) {
			return getInt(key, 0);
		}
		
		public static bool getBool(string key) {
			return getBool(key, false);
		}
		
		public static bool getBool(string key, bool def) {
			try {
				switch(key) {
					case "dumpTooltips":
					case "speakTooltip":
					case "uniqItems":
					case "rndSeq":
						return Convert.ToBoolean(Application.UserAppDataRegistry.GetValue(key).ToString());
					default:
						//MessageBox.Show(key);
						return def;
				}
			} catch(Exception) {
				//MessageBox.Show(key);
				return def;
			}
		}
		
		public static string getString(string key) {
			return getString(key,"");
		}
		
		public static string getString(string key, string def) {
			try {
				switch(key) {
					case "Filename":
						return Application.UserAppDataRegistry.GetValue(key).ToString();
					default:
						//MessageBox.Show(key);
						return def;
				}
			} catch(Exception) {
				//MessageBox.Show(key);
				return def;
			}
		}
		
		public static void setString(string key, string val) {
			Application.UserAppDataRegistry.SetValue(key, val);
		}
	}
}
