namespace MetaTaggingOnSoundTrack
{
    partial class MetaTaggingOnSoundTrackPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetaTaggingOnSoundTrackPlayer));
            this.listBoxSounds = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBoxMetaTags = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSounds
            // 
            this.listBoxSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSounds.FormattingEnabled = true;
            this.listBoxSounds.ItemHeight = 16;
            this.listBoxSounds.Location = new System.Drawing.Point(485, 12);
            this.listBoxSounds.Name = "listBoxSounds";
            this.listBoxSounds.Size = new System.Drawing.Size(183, 244);
            this.listBoxSounds.TabIndex = 1;
            this.listBoxSounds.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(485, 263);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(183, 49);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(10, 12);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(467, 300);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // listBoxMetaTags
            // 
            this.listBoxMetaTags.FormattingEnabled = true;
            this.listBoxMetaTags.Location = new System.Drawing.Point(10, 356);
            this.listBoxMetaTags.Name = "listBoxMetaTags";
            this.listBoxMetaTags.Size = new System.Drawing.Size(658, 225);
            this.listBoxMetaTags.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(332, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 32);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MetaTaggingOnSoundTrackPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 596);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMetaTags);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSounds);
            this.Name = "MetaTaggingOnSoundTrackPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSounds;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.ListBox listBoxMetaTags;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

