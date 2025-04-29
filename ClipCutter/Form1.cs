using AxWMPLib;
using FFMpegCore;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WMPLib;
using ClipCutter.models;
using SQLite;


namespace ClipCutter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mediaPlayer.uiMode = "none";
            mediaPlayer.settings.autoStart = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new OpenFileDialog { Filter = "MP4 Files (*.mp4)|*.mp4" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string videoPath = fileDialog.FileName;
                string fileOnlyName = Path.GetFileName(videoPath);
                mediaPlayer.URL = videoPath;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Play")
            {
                mediaPlayer.Ctlcontrols.play();
                button2.Text = "Pause";
            }
            else if (button2.Text == "Pause")
            {
                mediaPlayer.Ctlcontrols.pause();
                button2.Text = "Play";
            }
        }

        private void mediaPlayer_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
            {
                double durationInSeconds = mediaPlayer.currentMedia.duration;
                TimeSpan time = TimeSpan.FromSeconds(durationInSeconds);
                string formattedTime = time.ToString(@"mm\:ss");

                // Example: display it in a label
                maxLength.Text = formattedTime;
                trackBarTimeline.Maximum = (int)durationInSeconds;
            }
        }

        private void trackBarTimeline_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.currentPosition = trackBarTimeline.Value;
        }


        private void playbackTimer_Tick(object sender, EventArgs e)
        {
            // elapsed time label
            double currentPos = mediaPlayer.Ctlcontrols.currentPosition;
            TimeSpan time = TimeSpan.FromSeconds(currentPos);
            string formattedTime = time.ToString(@"mm\:ss");
            elapsedLength.Text = formattedTime;

            trackBarTimeline.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;
        }

        private void cutOffSecondsStart_Scroll(object sender, EventArgs e)
        {
            int totalSeconds = cutOffSecondsStart.Value;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            cutOffSecondsStartLabel.Text = $"{minutes:D2}:{seconds:D2}";
        }


        private void cutOffSecondsEnd_Scroll(object sender, EventArgs e)
        {
            int totalSeconds = cutOffSecondsEnd.Value;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            cutOffSecondsEndLabel.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection db = new("./clipcutter.db");
            var inputPath = mediaPlayer.URL;

            var config = db.Find<Config>(1);
            if (config == null)
            {
                MessageBox.Show("No output path found, make sure to configure one via the config tab!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var getPathFromDb = config.OutputPath;

            string videoFileName = Path.GetFileNameWithoutExtension(mediaPlayer.URL);

            string outputPath = $"{getPathFromDb}\\{videoFileName}-cropped.mp4";

            int startSeconds = cutOffSecondsStart.Value;
            int endSeconds = cutOffSecondsEnd.Value;

            var mediaInfo = FFProbe.Analyse(inputPath);
            var totalDuration = mediaInfo.Duration;
            var trimmedDuration = totalDuration - TimeSpan.FromSeconds(startSeconds + endSeconds);

            FFMpegArguments
                .FromFileInput(inputPath, verifyExists: true, options => options.Seek(TimeSpan.FromSeconds(startSeconds)))
                .OutputToFile(outputPath, overwrite: true, options => options
                    .WithDuration(trimmedDuration)
                    .CopyChannel())
                .ProcessSynchronously();

            if (MessageBox.Show("Your clip has been successfully saved. Do you want to open the clips directory?", "This", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("explorer.exe", getPathFromDb);
            }
        }
        private void configButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }


}

