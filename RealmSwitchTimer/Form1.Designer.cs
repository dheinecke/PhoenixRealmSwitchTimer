namespace RealmSwitchTimer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.RunningStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.CurrentTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharacterName = new System.Windows.Forms.Label();
            this.CharacterTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Expiry = new System.Windows.Forms.Label();
            this.SetAlarm = new System.Windows.Forms.Button();
            this.ClearAlarm = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunningStateLabel,
            this.Progress,
            this.CurrentTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 82);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(379, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RunningStateLabel
            // 
            this.RunningStateLabel.Name = "RunningStateLabel";
            this.RunningStateLabel.Size = new System.Drawing.Size(108, 17);
            this.RunningStateLabel.Text = "Phoenix is Running";
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(100, 16);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(75, 17);
            this.CurrentTimeLabel.Text = "System Time";
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSize = true;
            this.CharacterName.Location = new System.Drawing.Point(99, 13);
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.Size = new System.Drawing.Size(84, 13);
            this.CharacterName.TabIndex = 2;
            this.CharacterName.Text = "Character Name";
            // 
            // CharacterTime
            // 
            this.CharacterTime.AutoSize = true;
            this.CharacterTime.Location = new System.Drawing.Point(99, 35);
            this.CharacterTime.Name = "CharacterTime";
            this.CharacterTime.Size = new System.Drawing.Size(30, 13);
            this.CharacterTime.TabIndex = 6;
            this.CharacterTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last played:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Updated at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Can switch at:";
            // 
            // Expiry
            // 
            this.Expiry.AutoSize = true;
            this.Expiry.Location = new System.Drawing.Point(99, 57);
            this.Expiry.Name = "Expiry";
            this.Expiry.Size = new System.Drawing.Size(35, 13);
            this.Expiry.TabIndex = 10;
            this.Expiry.Text = "Expiry";
            // 
            // SetAlarm
            // 
            this.SetAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetAlarm.Location = new System.Drawing.Point(283, 12);
            this.SetAlarm.Name = "SetAlarm";
            this.SetAlarm.Size = new System.Drawing.Size(84, 23);
            this.SetAlarm.TabIndex = 3;
            this.SetAlarm.Text = "Set Alarm";
            this.SetAlarm.UseVisualStyleBackColor = true;
            this.SetAlarm.Click += new System.EventHandler(this.SetAlarm_Click);
            // 
            // ClearAlarm
            // 
            this.ClearAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAlarm.Enabled = false;
            this.ClearAlarm.Location = new System.Drawing.Point(283, 41);
            this.ClearAlarm.Name = "ClearAlarm";
            this.ClearAlarm.Size = new System.Drawing.Size(84, 23);
            this.ClearAlarm.TabIndex = 11;
            this.ClearAlarm.Text = "Clear Alarm";
            this.ClearAlarm.UseVisualStyleBackColor = true;
            this.ClearAlarm.Click += new System.EventHandler(this.ClearAlarm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 104);
            this.Controls.Add(this.ClearAlarm);
            this.Controls.Add(this.Expiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CharacterTime);
            this.Controls.Add(this.SetAlarm);
            this.Controls.Add(this.CharacterName);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Phoenix Realm-Switch Timer Estimator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel RunningStateLabel;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.Label CharacterName;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTimeLabel;
        private System.Windows.Forms.Label CharacterTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Expiry;
        private System.Windows.Forms.Button SetAlarm;
        private System.Windows.Forms.Button ClearAlarm;
    }
}

