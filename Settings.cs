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
	/**
	 * Handles settings
	 */
	public class Settings
	{
		/**
		 * Constructor
		 */
		public Settings()
		{
		}

		/**
		 * Get int value
		 */
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

		/**
		 * Get int value
		 */
		public static int getInt(string key) {
			return getInt(key, 0);
		}

		/**
		 * Get bool value
		 */
		public static bool getBool(string key) {
			return getBool(key, false);
		}

		/**
		 * Get bool value
		 */
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

		/**
		 * Get string value
		 */
		public static string getString(string key) {
			return getString(key,"");
		}

		/**
		 * Get string value
		 */
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

		/**
		 * Set string value
		 */
		public static void setString(string key, string val) {
			Application.UserAppDataRegistry.SetValue(key, val);
		}
	}
}
