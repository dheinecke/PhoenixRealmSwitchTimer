using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealmSwitchTimer
{
    public partial class MainForm : Form
    {
        private FileSystemInfo lastCharacterFile;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLastCharacterState();
            UpdatePhoenixRunningState();
            UpdateTimeState();
        }

        private void UpdateTimeState()
        {
            if (lastCharacterFile != null)
            {
                DateTime expiry = lastCharacterFile.LastAccessTime.AddHours(12);
                DateTime now = DateTime.Now;
                if( now > expiry )
                {
                    Expiry.Text = "Now";
                    Progress.Value = 100;
                    if(ClearAlarm.Enabled)
                    {
                        SystemSounds.Exclamation.Play();
                    }
                }
                else
                {
                    Progress.Value = (int)(now.Ticks / expiry.Ticks * 100);
                    Expiry.Text = (expiry - now).ToString("hh'h 'mm'm'");
                }
            }
            else
            {
                Progress.Value = 0;
                Expiry.Text = "-- Undetermined --";
            }                
        }

        private void UpdateLastCharacterState()
        {
            DirectoryInfo DirInfo = new DirectoryInfo(
                Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "Electronic Arts",
                    "Dark Age of Camelot",
                    "phoenix"));
            if ( !DirInfo.Exists )
                return;
            lastCharacterFile = DirInfo.GetFileSystemInfos("*.ini").OrderByDescending(fi => fi.LastWriteTime).First();
            if ( lastCharacterFile != null )
            {
                CharacterName.Text = lastCharacterFile.Name.Split('-')[0];
                CharacterTime.Text = lastCharacterFile.LastWriteTime.ToString();
            }
            else
            {
                CharacterName.Text = "-- Undetermined --";
                CharacterTime.Text = "-- Undetermined --";
            }
        }

        private void UpdatePhoenixRunningState()
        {
            Process[] processes = Process.GetProcessesByName("game.dll");
            if (processes.Length == 0)
            {
                RunningStateLabel.Text = "Phoenix is Not Running";
            }
            else
            {
                RunningStateLabel.Text = "Phoenix is Running";
            }
            if (lastCharacterFile != null)
                Expiry.Text = lastCharacterFile.LastAccessTime.AddHours(12).ToString();
            else
                Expiry.Text = "-- Undetermined --";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            CurrentTimeLabel.Text = Now.ToString();
            if(Now.Second % 10 == 0)
            {
                UpdateLastCharacterState();
                UpdatePhoenixRunningState();
                UpdateTimeState();
            }
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            SetAlarm.Enabled = false;
            ClearAlarm.Enabled = true;
        }

        private void ClearAlarm_Click(object sender, EventArgs e)
        {
            SetAlarm.Enabled = true;
            ClearAlarm.Enabled = false;
        }
    }
}
