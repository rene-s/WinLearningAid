using System;
using SpeechLib;
using System.Text.RegularExpressions;
using WLA;
using System.Windows.Forms;

namespace Text2Speech
{
	/**
	 * Handles speech engine
	 */
	class Speech
	{
		/**
		 * Constructor
		 */
		public Speech ()
		{
            
		}
    	
		/**
		 * Export to tts engine
	 	 * Copyright (C) David Futcher 2007
		 * <bobbocanfly at gmail dot com>
		 * http://text2speech.sourceforge.net
		 * This function is part of Text2Speech.
		 */
		public void export (string q, string a, string file)
		{
			if (Settings.getBool ("dumpTooltips") == false) {
				return;
			}
        	
			int pause = Settings.getInt ("speakingPauseInt", 5) * 1000;
			
			file = this.sanitizeFilename (file) + ".wav";
			SpVoice expVoice = new SpVoice ();

			SpeechStreamFileMode SpFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
			SpFileStream SpFileStream = new SpFileStream ();
			SpFileStream.Open (file, SpFileMode, false);
            
			expVoice.AudioOutputStream = SpFileStream;
			expVoice.Volume = 100;
			expVoice.Rate = 0;

			expVoice.Speak ("<speak/><volume level=\"0\">a<volume level=\"100\"><silence msec=\"2000\"/>", SpeechVoiceSpeakFlags.SVSFDefault);
			expVoice.Speak ("<speak/>" + q, SpeechVoiceSpeakFlags.SVSFDefault);
			expVoice.Speak ("<speak/><volume level=\"0\">a<volume level=\"100\"><silence msec=\"" + pause.ToString () + "\"/>", SpeechVoiceSpeakFlags.SVSFDefault);
			expVoice.Speak ("<speak/>" + a, SpeechVoiceSpeakFlags.SVSFDefault);
			expVoice.Speak ("<speak/><volume level=\"0\">a<volume level=\"100\"><silence msec=\"2000\"/>", SpeechVoiceSpeakFlags.SVSFDefault);
            
			SpFileStream.Close ();
			expVoice = null;
		}

		/**
		 * Sanitize file name
		 */
		public string sanitizeFilename (string s)
		{
			s = Regex.Replace (s, "[^a-züäößÜÖÄA-Z0-9-_]", " ");
			return Regex.Replace (s.Trim (), "[^a-züäößÜÖÄA-Z0-9-_]", "_");
		}
        
		/**
		 * Speak balloon tip
		 */
		public void SpeakBalloonTip (string q, string a, bool speak)
		{
			if (!speak) {
				return;
			}

			int pause = Settings.getInt ("speakingPauseInt", 5) * 1000;
			
			SpVoice _voice = new SpVoice ();
			_voice.Speak ("<speak/>" + q, SpeechVoiceSpeakFlags.SVSFDefault);
			_voice.Speak ("<speak/><volume level=\"0\">a<volume level=\"100\"><silence msec=\"" + pause.ToString () + "\"/>", SpeechVoiceSpeakFlags.SVSFDefault);
			_voice.Speak ("<speak/>" + a, SpeechVoiceSpeakFlags.SVSFDefault);
			_voice = null;
			
			try {
				this.export (q, a, q);			
			} catch (Exception ex) {
				MessageBox.Show ("Error: " + ex.Message);
				return;
			}
			
			GC.Collect ();
		}
	}
}
