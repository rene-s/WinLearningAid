/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 14.10.2008
 * Zeit: 19:41
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using System.Text.RegularExpressions;

namespace V_Learning_Aid
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{
		public String body = "Empty";
		public String head = "Empty";
		
		public void Set(string head, string body) {
			this.head = head.Trim();
			this.body = body.Trim();
		}
	}
}



			
