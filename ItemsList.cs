/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 23.11.2008
 * Zeit: 11:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using System.Collections;
using WLA;
using V_Learning_Aid;
using System.Windows.Forms;

namespace WLA
{
	/**
	 * List of items
	 */
	public class ItemsList
	{
		public ArrayList ytems = new ArrayList();
		public int p = 0;

		/**
		 * Constructor
		 */
		public ItemsList()
		{
		}

		/**
		 * Shuffle items
		 */
		public void Shuffle()
		{
			Random r = new Random();
			for (int cnt = 0; cnt < ytems.Count; cnt++)
			{
				object tmp = ytems[cnt];
				int idx = r.Next(ytems.Count - cnt) + cnt;
				ytems[cnt] = ytems[idx];
				ytems[idx] = tmp;
			}
		}

		/**
		 * Add item
		 */
		public void Add(Item item) 
		{
			ytems.Add(item);
		}

		/**
		 * Get next item
		 */
		public Item Next()
		{
			// Traverse loop
			if(!Settings.getBool("rndSeq") || Settings.getBool("uniqItems")) {
				return ((Item)ytems[p++%ytems.Count]);
			}
			
			// Select random item
			Random rnd = new Random();
			int i = rnd.Next(0, ytems.Count);
			return ((Item)ytems[i]);
		}

		/**
		 * Shuffle
		 */
		public bool Dice ()
		{
			int chance = Settings.getInt ("chanceInt");
			
			if (chance >= 100) {
				return true;
			}

			Random dice = new Random();
			int roll = dice.Next(0, 100);
			
			return roll > chance;
		}
	}
}
