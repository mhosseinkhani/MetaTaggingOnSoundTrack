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
            this.btnBorwse = new System.Windows.Forms.Button();
            this.WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnAddMetaData = new System.Windows.Forms.Button();
            this.textBoxMetaData = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackwardTwoSecond = new System.Windows.Forms.Button();
            this.btnForwardTwoSecond = new System.Windows.Forms.Button();
            this.dataGridViewMetaTags = new System.Windows.Forms.DataGridView();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetaTags)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSounds
            // 
            this.listBoxSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSounds.FormattingEnabled = true;
            this.listBoxSounds.ItemHeight = 16;
            this.listBoxSounds.Location = new System.Drawing.Point(483, 105);
            this.listBoxSounds.Name = "listBoxSounds";
            this.listBoxSounds.Size = new System.Drawing.Size(183, 244);
            this.listBoxSounds.TabIndex = 1;
            this.listBoxSounds.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnBorwse
            // 
            this.btnBorwse.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBorwse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorwse.ForeColor = System.Drawing.Color.White;
            this.btnBorwse.Location = new System.Drawing.Point(483, 50);
            this.btnBorwse.Name = "btnBorwse";
            this.btnBorwse.Size = new System.Drawing.Size(183, 49);
            this.btnBorwse.TabIndex = 2;
            this.btnBorwse.Text = "Browse";
            this.btnBorwse.UseVisualStyleBackColor = false;
            this.btnBorwse.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // WMPlayer
            // 
            this.WMPlayer.Enabled = true;
            this.WMPlayer.Location = new System.Drawing.Point(8, 49);
            this.WMPlayer.Name = "WMPlayer";
            this.WMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPlayer.OcxState")));
            this.WMPlayer.Size = new System.Drawing.Size(467, 300);
            this.WMPlayer.TabIndex = 3;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(8, 355);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 32);
            this.btnBackward.TabIndex = 5;
            this.btnBackward.Text = "5s   <<";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(330, 354);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 32);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = ">>  5s";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnAddMetaData
            // 
            this.btnAddMetaData.Location = new System.Drawing.Point(168, 355);
            this.btnAddMetaData.Name = "btnAddMetaData";
            this.btnAddMetaData.Size = new System.Drawing.Size(75, 32);
            this.btnAddMetaData.TabIndex = 7;
            this.btnAddMetaData.Text = "+ Add";
            this.btnAddMetaData.UseVisualStyleBackColor = true;
            this.btnAddMetaData.Click += new System.EventHandler(this.btnAddMetaData_Click);
            // 
            // textBoxMetaData
            // 
            this.textBoxMetaData.Location = new System.Drawing.Point(411, 393);
            this.textBoxMetaData.Multiline = true;
            this.textBoxMetaData.Name = "textBoxMetaData";
            this.textBoxMetaData.Size = new System.Drawing.Size(250, 189);
            this.textBoxMetaData.TabIndex = 10;
            this.textBoxMetaData.Enter += new System.EventHandler(this.textBoxMetaData_Enter);
            this.textBoxMetaData.Leave += new System.EventHandler(this.textBoxMetaData_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(411, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(497, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(583, 586);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(78, 32);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Meta Data";
            // 
            // btnBackwardTwoSecond
            // 
            this.btnBackwardTwoSecond.Location = new System.Drawing.Point(87, 355);
            this.btnBackwardTwoSecond.Name = "btnBackwardTwoSecond";
            this.btnBackwardTwoSecond.Size = new System.Drawing.Size(75, 32);
            this.btnBackwardTwoSecond.TabIndex = 5;
            this.btnBackwardTwoSecond.Text = "2s   <<";
            this.btnBackwardTwoSecond.UseVisualStyleBackColor = true;
            this.btnBackwardTwoSecond.Click += new System.EventHandler(this.btnBackwardTwoSecond_Click);
            // 
            // btnForwardTwoSecond
            // 
            this.btnForwardTwoSecond.Location = new System.Drawing.Point(249, 354);
            this.btnForwardTwoSecond.Name = "btnForwardTwoSecond";
            this.btnForwardTwoSecond.Size = new System.Drawing.Size(75, 32);
            this.btnForwardTwoSecond.TabIndex = 6;
            this.btnForwardTwoSecond.Text = ">>  2s";
            this.btnForwardTwoSecond.UseVisualStyleBackColor = true;
            this.btnForwardTwoSecond.Click += new System.EventHandler(this.btnForwardTwoSecond_Click);
            // 
            // dataGridViewMetaTags
            // 
            this.dataGridViewMetaTags.AllowUserToAddRows = false;
            this.dataGridViewMetaTags.AllowUserToDeleteRows = false;
            this.dataGridViewMetaTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetaTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNumber,
            this.Time,
            this.TimeString,
            this.MetaData});
            this.dataGridViewMetaTags.Location = new System.Drawing.Point(8, 393);
            this.dataGridViewMetaTags.MultiSelect = false;
            this.dataGridViewMetaTags.Name = "dataGridViewMetaTags";
            this.dataGridViewMetaTags.ReadOnly = true;
            this.dataGridViewMetaTags.RowHeadersVisible = false;
            this.dataGridViewMetaTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMetaTags.Size = new System.Drawing.Size(397, 225);
            this.dataGridViewMetaTags.TabIndex = 12;
            this.dataGridViewMetaTags.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMetaTags_CellDoubleClick);
            // 
            // RowNumber
            // 
            this.RowNumber.FillWeight = 20F;
            this.RowNumber.Frozen = true;
            this.RowNumber.HeaderText = "#";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            this.RowNumber.Width = 20;
            // 
            // Time
            // 
            this.Time.FillWeight = 80F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 80;
            // 
            // TimeString
            // 
            this.TimeString.FillWeight = 80F;
            this.TimeString.HeaderText = "TimeString";
            this.TimeString.Name = "TimeString";
            this.TimeString.ReadOnly = true;
            this.TimeString.Width = 80;
            // 
            // MetaData
            // 
            this.MetaData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MetaData.HeaderText = "MetaData";
            this.MetaData.Name = "MetaData";
            this.MetaData.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(153)))), ((int)(((byte)(185)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 34);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sound Track Meta Test Adder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // MetaTaggingOnSoundTrackPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(674, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMetaTags);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMetaData);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddMetaData);
            this.Controls.Add(this.btnForwardTwoSecond);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackwardTwoSecond);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.WMPlayer);
            this.Controls.Add(this.btnBorwse);
            this.Controls.Add(this.listBoxSounds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetaTaggingOnSoundTrackPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetaTags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSounds;
        private System.Windows.Forms.Button btnBorwse;
        private AxWMPLib.AxWindowsMediaPlayer WMPlayer;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnAddMetaData;
        private System.Windows.Forms.TextBox textBoxMetaData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackwardTwoSecond;
        private System.Windows.Forms.Button btnForwardTwoSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeString;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetaData;
        private System.Windows.Forms.DataGridView dataGridViewMetaTags;
        private System.Windows.Forms.Label label2;
    }
}

