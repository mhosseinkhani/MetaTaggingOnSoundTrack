using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MetaTaggingOnSoundTrack
{
    public partial class MetaTaggingOnSoundTrackPlayer : Form
    {
        List<MetaTagItem> _metaTags = new List<MetaTagItem>();
        public MetaTaggingOnSoundTrackPlayer()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or name of the Tracks and path of the track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to SElect Songs
            OpenFileDialog ofd = new OpenFileDialog();
            //Code to select multiple files
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the names of the track in files array
                paths = ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSounds.Items.Add(files[i]); //Display Songs in Listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            WMPlayer.URL = paths[listBoxSounds.SelectedIndex];
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.currentPosition += 5;

        }

        private void btnAddMetaData_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.pause();
            this.textBoxMetaData.Select();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.currentPosition -= 5;

        }

        private void btnBackwardTwoSecond_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.currentPosition -= 2;

        }

        private void btnForwardTwoSecond_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.currentPosition += 2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newTag = new MetaTagItem
            {
                FileId = this.WMPlayer.Ctlcontrols.currentItem.sourceURL.GetHashCode().ToString(),
                FilePath = this.WMPlayer.Ctlcontrols.currentItem.sourceURL,
                MetaData = textBoxMetaData.Text,
                Position = this.WMPlayer.Ctlcontrols.currentPosition,
                PositionString = WMPlayer.Ctlcontrols.currentPositionString
            };
            this._metaTags.Add(newTag);
            this.dataGridViewMetaTags.Rows.Add("1", newTag.Position, newTag.PositionString, newTag.MetaData);
            this.WMPlayer.Ctlcontrols.play();
            this.textBoxMetaData.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.WMPlayer.Ctlcontrols.play();

        }

        private void textBoxMetaData_Enter(object sender, EventArgs e)
        {
            textBoxMetaData.BackColor = Color.Yellow;
        }

        private void textBoxMetaData_Leave(object sender, EventArgs e)
        {
            textBoxMetaData.BackColor = Color.White;

        }

        private void dataGridViewMetaTags_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var time = dataGridViewMetaTags.Rows[e.RowIndex].Cells["Time"].Value;
                var meta = dataGridViewMetaTags.Rows[e.RowIndex].Cells["MetaData"].Value;
                this.WMPlayer.Ctlcontrols.currentPosition = Convert.ToDouble(time);
                this.textBoxMetaData.Text = meta.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class MetaTagItem
    {
        public string PositionString { get; set; }
        public double Position { get; set; }
        public string FilePath { get; set; }
        public string FileId { get; set; }
        public string MetaData { get; set; }
    }
}
