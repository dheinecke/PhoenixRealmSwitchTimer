/*
 * Copyright 2019 Tamlansoft
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
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
                    Progress.Value = 100 - (int)(expiry - now).TotalSeconds / (12 * 36);
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
