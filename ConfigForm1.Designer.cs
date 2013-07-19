/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 11.08.2008
 * Zeit: 13:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace V_Learning_Aid
{
	partial class ConfigForm1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.fileTab = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusLabel = new System.Windows.Forms.Label();
			this.repeatTimes = new System.Windows.Forms.NumericUpDown();
			this.repeatMode = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.openFileBtn = new System.Windows.Forms.Button();
			this.popupCfg = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.rndSeq = new System.Windows.Forms.CheckBox();
			this.uniqItems = new System.Windows.Forms.CheckBox();
			this.speakTooltip = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.intervalUnit = new System.Windows.Forms.ComboBox();
			this.speakingPauseInt = new System.Windows.Forms.NumericUpDown();
			this.chanceInt = new System.Windows.Forms.NumericUpDown();
			this.intervalInt = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dlgCancelBtn = new System.Windows.Forms.Button();
			this.dlgOkBtn = new System.Windows.Forms.Button();
			this.dumpTooltips = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.fileTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.repeatTimes)).BeginInit();
			this.popupCfg.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.speakingPauseInt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chanceInt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.intervalInt)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.fileTab);
			this.tabControl1.Controls.Add(this.popupCfg);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(6, 6);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(400, 337);
			this.tabControl1.TabIndex = 0;
			// 
			// fileTab
			// 
			this.fileTab.Controls.Add(this.groupBox1);
			this.fileTab.Location = new System.Drawing.Point(4, 22);
			this.fileTab.Name = "fileTab";
			this.fileTab.Padding = new System.Windows.Forms.Padding(3);
			this.fileTab.Size = new System.Drawing.Size(392, 311);
			this.fileTab.TabIndex = 0;
			this.fileTab.Text = "File settings";
			this.fileTab.UseVisualStyleBackColor = true;
			this.fileTab.Click += new System.EventHandler(this.FileTabClick);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.statusLabel);
			this.groupBox1.Controls.Add(this.repeatTimes);
			this.groupBox1.Controls.Add(this.repeatMode);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.openFileBtn);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(372, 125);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File name and repeat settings";
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// statusLabel
			// 
			this.statusLabel.Location = new System.Drawing.Point(6, 90);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(342, 19);
			this.statusLabel.TabIndex = 7;
			this.statusLabel.Text = "-";
			// 
			// repeatTimes
			// 
			this.repeatTimes.Enabled = false;
			this.repeatTimes.Location = new System.Drawing.Point(243, 56);
			this.repeatTimes.Maximum = new decimal(new int[] {
									999,
									0,
									0,
									0});
			this.repeatTimes.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.repeatTimes.Name = "repeatTimes";
			this.repeatTimes.Size = new System.Drawing.Size(105, 20);
			this.repeatTimes.TabIndex = 6;
			this.repeatTimes.Tag = "";
			this.repeatTimes.Value = new decimal(new int[] {
									999,
									0,
									0,
									0});
			// 
			// repeatMode
			// 
			this.repeatMode.Enabled = false;
			this.repeatMode.FormattingEnabled = true;
			this.repeatMode.Items.AddRange(new object[] {
									"Infinite",
									"Finite"});
			this.repeatMode.Location = new System.Drawing.Point(122, 55);
			this.repeatMode.Name = "repeatMode";
			this.repeatMode.Size = new System.Drawing.Size(113, 21);
			this.repeatMode.TabIndex = 5;
			this.repeatMode.SelectedIndexChanged += new System.EventHandler(this.repeatModeChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Repeat mode";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 11);
			this.label1.TabIndex = 2;
			this.label1.Text = "File to traverse";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(122, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(145, 20);
			this.textBox1.TabIndex = 1;
			// 
			// openFileBtn
			// 
			this.openFileBtn.Location = new System.Drawing.Point(273, 22);
			this.openFileBtn.Name = "openFileBtn";
			this.openFileBtn.Size = new System.Drawing.Size(75, 23);
			this.openFileBtn.TabIndex = 0;
			this.openFileBtn.Text = "Open File";
			this.openFileBtn.UseVisualStyleBackColor = true;
			this.openFileBtn.Click += new System.EventHandler(this.SelectFile);
			// 
			// popupCfg
			// 
			this.popupCfg.Controls.Add(this.groupBox3);
			this.popupCfg.Controls.Add(this.groupBox2);
			this.popupCfg.Location = new System.Drawing.Point(4, 22);
			this.popupCfg.Name = "popupCfg";
			this.popupCfg.Padding = new System.Windows.Forms.Padding(3);
			this.popupCfg.Size = new System.Drawing.Size(392, 311);
			this.popupCfg.TabIndex = 1;
			this.popupCfg.Text = "Tooltip Settings";
			this.popupCfg.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this.dumpTooltips);
			this.groupBox3.Controls.Add(this.rndSeq);
			this.groupBox3.Controls.Add(this.uniqItems);
			this.groupBox3.Controls.Add(this.speakTooltip);
			this.groupBox3.Location = new System.Drawing.Point(6, 151);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(372, 161);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Other settings";
			// 
			// rndSeq
			// 
			this.rndSeq.Location = new System.Drawing.Point(6, 88);
			this.rndSeq.Name = "rndSeq";
			this.rndSeq.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.rndSeq.Size = new System.Drawing.Size(336, 24);
			this.rndSeq.TabIndex = 2;
			this.rndSeq.Text = "Random sequence";
			this.rndSeq.UseVisualStyleBackColor = true;
			this.rndSeq.CheckStateChanged += new System.EventHandler(this.RandomModeChanged);
			// 
			// uniqItems
			// 
			this.uniqItems.Location = new System.Drawing.Point(6, 58);
			this.uniqItems.Name = "uniqItems";
			this.uniqItems.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.uniqItems.Size = new System.Drawing.Size(336, 24);
			this.uniqItems.TabIndex = 1;
			this.uniqItems.Text = "Unique items per loop";
			this.uniqItems.UseVisualStyleBackColor = true;
			// 
			// speakTooltip
			// 
			this.speakTooltip.Location = new System.Drawing.Point(6, 28);
			this.speakTooltip.Name = "speakTooltip";
			this.speakTooltip.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.speakTooltip.Size = new System.Drawing.Size(336, 24);
			this.speakTooltip.TabIndex = 0;
			this.speakTooltip.Text = "Speak Tooltips";
			this.speakTooltip.UseVisualStyleBackColor = true;
			this.speakTooltip.CheckStateChanged += new System.EventHandler(this.SpeakToolTipChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.intervalUnit);
			this.groupBox2.Controls.Add(this.speakingPauseInt);
			this.groupBox2.Controls.Add(this.chanceInt);
			this.groupBox2.Controls.Add(this.intervalInt);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(372, 139);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Time settings";
			// 
			// intervalUnit
			// 
			this.intervalUnit.FormattingEnabled = true;
			this.intervalUnit.Items.AddRange(new object[] {
									"seconds",
									"minutes",
									"hours"});
			this.intervalUnit.Location = new System.Drawing.Point(263, 27);
			this.intervalUnit.Name = "intervalUnit";
			this.intervalUnit.Size = new System.Drawing.Size(79, 21);
			this.intervalUnit.TabIndex = 6;
			this.intervalUnit.Text = "minutes";
			this.intervalUnit.SelectedIndexChanged += new System.EventHandler(this.intervalBoundary);
			// 
			// speakingPauseInt
			// 
			this.speakingPauseInt.Location = new System.Drawing.Point(196, 80);
			this.speakingPauseInt.Maximum = new decimal(new int[] {
									20,
									0,
									0,
									0});
			this.speakingPauseInt.Name = "speakingPauseInt";
			this.speakingPauseInt.Size = new System.Drawing.Size(146, 20);
			this.speakingPauseInt.TabIndex = 5;
			this.speakingPauseInt.Value = new decimal(new int[] {
									10,
									0,
									0,
									0});
			// 
			// chanceInt
			// 
			this.chanceInt.Location = new System.Drawing.Point(196, 54);
			this.chanceInt.Name = "chanceInt";
			this.chanceInt.Size = new System.Drawing.Size(146, 20);
			this.chanceInt.TabIndex = 4;
			// 
			// intervalInt
			// 
			this.intervalInt.Location = new System.Drawing.Point(196, 28);
			this.intervalInt.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.intervalInt.Name = "intervalInt";
			this.intervalInt.Size = new System.Drawing.Size(61, 20);
			this.intervalInt.TabIndex = 3;
			this.intervalInt.Value = new decimal(new int[] {
									10,
									0,
									0,
									0});
			this.intervalInt.ValueChanged += new System.EventHandler(this.intervalBoundary);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(194, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Pause between headline and body (s)";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "Chance (%)";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Interval";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dlgCancelBtn);
			this.panel1.Controls.Add(this.dlgOkBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(6, 358);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 29);
			this.panel1.TabIndex = 2;
			// 
			// dlgCancelBtn
			// 
			this.dlgCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dlgCancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dlgCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.dlgCancelBtn.Location = new System.Drawing.Point(321, 3);
			this.dlgCancelBtn.Name = "dlgCancelBtn";
			this.dlgCancelBtn.Size = new System.Drawing.Size(72, 23);
			this.dlgCancelBtn.TabIndex = 2;
			this.dlgCancelBtn.Text = "&Cancel";
			this.dlgCancelBtn.UseVisualStyleBackColor = true;
			this.dlgCancelBtn.Click += new System.EventHandler(this.dlgCancelBtnClick);
			// 
			// dlgOkBtn
			// 
			this.dlgOkBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dlgOkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dlgOkBtn.Location = new System.Drawing.Point(245, 3);
			this.dlgOkBtn.Name = "dlgOkBtn";
			this.dlgOkBtn.Size = new System.Drawing.Size(70, 23);
			this.dlgOkBtn.TabIndex = 1;
			this.dlgOkBtn.Text = "&OK";
			this.dlgOkBtn.UseVisualStyleBackColor = true;
			this.dlgOkBtn.Click += new System.EventHandler(this.dlgOkBtnClick);
			// 
			// dumpTooltips
			// 
			this.dumpTooltips.Location = new System.Drawing.Point(6, 118);
			this.dumpTooltips.Name = "dumpTooltips";
			this.dumpTooltips.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.dumpTooltips.Size = new System.Drawing.Size(336, 24);
			this.dumpTooltips.TabIndex = 3;
			this.dumpTooltips.Text = "Dump as WAV to current directory";
			this.dumpTooltips.UseVisualStyleBackColor = true;
			// 
			// ConfigForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 393);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(420, 420);
			this.MinimumSize = new System.Drawing.Size(420, 420);
			this.Name = "ConfigForm1";
			this.Padding = new System.Windows.Forms.Padding(6);
			this.Text = "Win Learning Aid";
			this.Load += new System.EventHandler(this.ConfigForm1Load);
			this.tabControl1.ResumeLayout(false);
			this.fileTab.ResumeLayout(false);
			this.fileTab.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.repeatTimes)).EndInit();
			this.popupCfg.ResumeLayout(false);
			this.popupCfg.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.speakingPauseInt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chanceInt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.intervalInt)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox dumpTooltips;
		private System.Windows.Forms.Label statusLabel;
		public System.Windows.Forms.NumericUpDown speakingPauseInt;
		private System.Windows.Forms.CheckBox rndSeq;
		private System.Windows.Forms.CheckBox uniqItems;
		private System.Windows.Forms.CheckBox speakTooltip;
		public System.Windows.Forms.ComboBox intervalUnit;
		private System.Windows.Forms.NumericUpDown chanceInt;
		public System.Windows.Forms.NumericUpDown intervalInt;
		private System.Windows.Forms.NumericUpDown repeatTimes;
		private System.Windows.Forms.ComboBox repeatMode;
		private System.Windows.Forms.Button dlgOkBtn;
		private System.Windows.Forms.Button dlgCancelBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button openFileBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage fileTab;
		private System.Windows.Forms.TabPage popupCfg;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		
	}
}
