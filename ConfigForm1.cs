/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 11.08.2008
 * Zeit: 13:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */

using System;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using WLA;

namespace V_Learning_Aid
{
	/// <summary>
	/// Description of ConfigForm1.
	/// </summary>
	public partial class ConfigForm1 : Form
	{
		//public ArrayList items = new ArrayList();
		public ItemsList newitems = new ItemsList();
		
		public ConfigForm1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			LoadConfig();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SaveConfig() {
			Settings.setString("RepeatTimes", repeatTimes.Value.ToString());
			Settings.setString("RepeatMode", repeatMode.SelectedIndex.ToString());
			
			if(File.Exists(textBox1.Text))
				Settings.setString("Filename", textBox1.Text);
			else
				Settings.setString("Filename", "");
			
			Settings.setString("dumpTooltips", dumpTooltips.Checked.ToString());
			Settings.setString("intervalInt", intervalInt.Value.ToString());
			Settings.setString("intervalUnit", intervalUnit.SelectedIndex.ToString());
			Settings.setString("chanceInt", chanceInt.Value.ToString());
			Settings.setString("speakingPauseInt", speakingPauseInt.Value.ToString());
			Settings.setString("speakTooltip", speakTooltip.Checked.ToString());
			Settings.setString("uniqItems", uniqItems.Checked.ToString());
			Settings.setString("rndSeq", rndSeq.Checked.ToString());
			Settings.setString("dumpTooltips", dumpTooltips.Checked.ToString());
			
			LoadConfig();
		}
		
		public void LoadConfig() {

			repeatTimes.Value = 999; 
			repeatMode.SelectedIndex = 0;
			textBox1.Text = Settings.getString("Filename", "");
			
			if(textBox1.Text != "" && !File.Exists(textBox1.Text)) 
			{
				MessageBox.Show("File "+textBox1.Text+" not found.");
				textBox1.Text = "";
				openFileDialog1.FileName = "";
			}
			
			intervalInt.Value = Settings.getInt("intervalInt", 10);
			intervalUnit.SelectedIndex = Settings.getInt("intervalUnit", 0);
			chanceInt.Value  = Settings.getInt("chanceInt", 100);
			speakingPauseInt.Value = Settings.getInt("speakingPauseInt", 10);
			speakTooltip.Checked = Settings.getBool("speakTooltip", false);
			uniqItems.Checked = Settings.getBool("uniqItems", false);
			rndSeq.Checked = Settings.getBool("rndSeq", true);
			dumpTooltips.Checked = Settings.getBool("dumpTooltips", false);
			
			// speakingPauseInt nach SpeakTooltip einstellen
			SpeakToolTipChanged(this,new System.EventArgs());
			RandomModeChanged(this,new System.EventArgs());
			
			this.readFile(textBox1.Text);
			
			// Shuffle
			if(rndSeq.Checked && uniqItems.Checked) 
			{
				newitems.Shuffle();
			}
		}
		   
		void traverseFile(XmlNodeList elements, string question) {
			string answer = "";
			foreach (XmlElement element in elements) {
				if(element.Name == "node") {
					if(element.HasChildNodes) {
						question = element.GetAttribute("TEXT");
						traverseFile(element.ChildNodes,question);
					} else {
						answer += element.GetAttribute("TEXT")+" "; 
					}
				}
				
			}
			if(question != "" && answer != "" && answer != " ") {
				Item item = new Item();
				item.Set(question,answer);
				newitems.Add(item);
			}
		}
		void readFile(string filename) {
    
			if(filename == "") 
			{
				return;
			}
			
			if(!File.Exists(filename)) 
			{
				MessageBox.Show("File "+filename+" not found.");
				textBox1.Text = "";
				openFileDialog1.FileName = "";
				return;
			}
			
			newitems.ytems.Clear();
			
			try
			{
				XmlDocument mm = new XmlDocument();
				mm.Load(filename);
				traverseFile(mm.SelectNodes("//map/node"),"");
				statusLabel.Text = newitems.ytems.Count.ToString()+" item(s) read.";
			} catch (Exception ex) {
				MessageBox.Show("Error: Could not read file. Original error: " + ex.Message);
				textBox1.Text = "";
				openFileDialog1.FileName = "";
				return;
			}
			
		}
		
		void ConfigForm1Load(object sender, EventArgs e)
		{
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		}
		
		void OpenFileDialog1FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
		}
		
		void Label1Click(object sender, EventArgs e)
		{
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		}
		
		void SpeakToolTipChanged(object sender, EventArgs e)
		{
			speakingPauseInt.Enabled = speakTooltip.Checked;
			dumpTooltips.Enabled = speakTooltip.Checked;
		}
		
		void RandomModeChanged(object sender, EventArgs e)
		{
			uniqItems.Enabled = rndSeq.Checked;
			if(!uniqItems.Enabled) 
			{
				uniqItems.Checked = true;
			}
		}

		
		void SelectFile(object sender, EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			
			openFileDialog1.InitialDirectory = "Desktop" ;
			openFileDialog1.Filter = "All files (*.*)|*.*|mm files (*.mm)|*.mm";
			openFileDialog1.FilterIndex = 2 ;
			openFileDialog1.RestoreDirectory = true ;
			
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (myStream)
						{
							textBox1.Text = openFileDialog1.FileName;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}
		
		void FileTabClick(object sender, EventArgs e)
		{
		}
		
		void dlgOkBtnClick(object sender, EventArgs e)
		{
			Hide();
			SaveConfig();
		}
		
		void dlgCancelBtnClick(object sender, EventArgs e)
		{
			Hide();
			LoadConfig();
		}
		
		void intervalBoundary(object sender, EventArgs e)
		{
			int i = (int)intervalInt.Value;
			int u = (int)intervalUnit.SelectedIndex;

			switch(u)
			{
				case 0:
					if(i < 30)
						intervalInt.Value = 30;
					break;
				case 1:
					i = i*60; 
					break;
				case 2:
					i = i*60*60; 
					break;
			}
			
		}
		
		void repeatModeChanged(object sender, EventArgs e)
		{
			repeatTimes.Tag = "Test";
			switch(repeatMode.SelectedIndex) {
				case 1:
					repeatTimes.Enabled = true;
					break;
				case 0:
				default:
					repeatTimes.Enabled = false;
					break;
			}
			
		}
	}
}
