/*
 * Erstellt mit SharpDevelop.
 * Benutzer: rschmidt
 * Datum: 11.08.2008
 * Zeit: 13:20
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Diagnostics;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Text2Speech;
using WLA;

namespace V_Learning_Aid
{
	public sealed class NotificationIcon
	{
		private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		private ConfigForm1 cfgform = new ConfigForm1();
		public NotificationIcon notificationIcon;
		private System.Timers.Timer earTimer = new System.Timers.Timer();
		private Speech voice = new Speech();
		
		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon();
			notificationMenu = new ContextMenu(InitializeMenu());

			notifyIcon.DoubleClick += IconDoubleClick;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("$this.Icon");
			notifyIcon.ContextMenu = notificationMenu;
			
			VLA testvla = new VLA();
			
			earTimer.AutoReset = true;
			earTimer.Interval = 5000;
			earTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.t_Elapsed);
			earTimer.Start();	
			this.setInterval();		
		}
		
		private void setInterval() {
			int i = 5;
			int u = 0;

			i = Settings.getInt("intervalInt");
			u = Settings.getInt("intervalUnit");
			
			switch(u) {
				case 1:
					i = i*1000*60;
					break;
				case 2:
					i = i*1000*60*60;
					break;
				case 0:
				default:
					i = i*1000;
					break;
			}
	
			if(earTimer.Interval != i) {
				earTimer.Interval = i+1;	
				earTimer.Stop();
				earTimer.Start();
			}
		}
		
		private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {

			if(cfgform.Visible || cfgform.newitems.ytems.Count == 0)
					return;
			
			this.setInterval();
		
			if(!cfgform.newitems.Dice()) {
				return;
			}
			
			Item item = cfgform.newitems.Next();
			String content = item.head+"\n\n"+item.body;
		
			if(content.Length > 252) {
				content = content.Substring(0,252) + "...";
			}
			notifyIcon.ShowBalloonTip(10000,"V Learning Aid",content,ToolTipIcon.Info);
			voice.SpeakBalloonTip(item.head,item.body,Settings.getBool("speakTooltip"));
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("About", menuAboutClick),
				new MenuItem("Config", menuConfigClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "V_Learning_Aid", out isFirstInstance)) {
				if (isFirstInstance) {

					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
					//notificationIcon.notifyIcon.ShowBalloonTip(100,((Item)items[0]).o,((Item)items[1]).t,ToolTipIcon.Info);
					notificationIcon.notifyIcon.ShowBalloonTip(100,"Message","V Learning Aid started",ToolTipIcon.Info);



					
					
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers
		private void menuAboutClick(object sender, EventArgs e)
		{
			String txt = "Win Learning Aid v0.5.4 Copyright (C) 2009 René Schmidt\n\nWin Learning Aid is a small tray icon tool that periodically shows nodes from Freemind files in a tray icon tooltip. See http://freemind.sourceforge.net/ for information regarding Freemind.\n\nThis program comes with NO WARRANTY, to the extent permitted by applicable law. See the file named GPL.txt for details.";
			String title = "About";
			MessageBox.Show(txt, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		private void menuConfigClick(object sender, EventArgs e)
		{
			earTimer.Interval = 10000;
			cfgform.Show();			
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			earTimer.Interval = 10000;
			cfgform.Show();	
		}
		
		public void Dispose() {
			earTimer.Dispose();
			cfgform.Dispose();
			notificationIcon.Dispose();
			notifyIcon.Dispose();
		}
		#endregion
	}
}
