namespace ClipCutter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            button2 = new Button();
            trackBarTimeline = new TrackBar();
            playbackTimer = new System.Windows.Forms.Timer(components);
            elapsedLength = new Label();
            maxLength = new Label();
            label3 = new Label();
            button3 = new Button();
            configButton = new Button();
            cutOffSecondsStart = new TrackBar();
            cutOffSecondsEnd = new TrackBar();
            cutOffSecondsStartLabel = new Label();
            cutOffSecondsEndLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTimeline).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutOffSecondsStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutOffSecondsEnd).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 20);
            button1.Name = "button1";
            button1.Size = new Size(85, 28);
            button1.TabIndex = 1;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(55, 54);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(424, 235);
            mediaPlayer.TabIndex = 2;
            mediaPlayer.PlayStateChange += mediaPlayer_PlayStateChange;
            // 
            // button2
            // 
            button2.Location = new Point(55, 297);
            button2.Name = "button2";
            button2.Size = new Size(68, 42);
            button2.TabIndex = 3;
            button2.Text = "Play";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBarTimeline
            // 
            trackBarTimeline.Location = new Point(129, 311);
            trackBarTimeline.Maximum = 100;
            trackBarTimeline.Name = "trackBarTimeline";
            trackBarTimeline.Size = new Size(270, 45);
            trackBarTimeline.TabIndex = 5;
            trackBarTimeline.TickStyle = TickStyle.None;
            trackBarTimeline.Scroll += trackBarTimeline_Scroll;
            // 
            // playbackTimer
            // 
            playbackTimer.Enabled = true;
            playbackTimer.Interval = 500;
            playbackTimer.Tick += playbackTimer_Tick;
            // 
            // elapsedLength
            // 
            elapsedLength.AutoSize = true;
            elapsedLength.Location = new Point(398, 311);
            elapsedLength.Name = "elapsedLength";
            elapsedLength.Size = new Size(34, 15);
            elapsedLength.TabIndex = 6;
            elapsedLength.Text = "00:00";
            // 
            // maxLength
            // 
            maxLength.AutoSize = true;
            maxLength.Location = new Point(438, 311);
            maxLength.Name = "maxLength";
            maxLength.Size = new Size(34, 15);
            maxLength.TabIndex = 7;
            maxLength.Text = "00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 311);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 8;
            label3.Text = "/";
            // 
            // button3
            // 
            button3.Location = new Point(17, 464);
            button3.Name = "button3";
            button3.Size = new Size(500, 42);
            button3.TabIndex = 9;
            button3.Text = "Export";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // configButton
            // 
            configButton.Location = new Point(394, 20);
            configButton.Name = "configButton";
            configButton.Size = new Size(85, 28);
            configButton.TabIndex = 15;
            configButton.Text = "Config";
            configButton.UseVisualStyleBackColor = true;
            configButton.Click += configButton_Click;
            // 
            // cutOffSecondsStart
            // 
            cutOffSecondsStart.Location = new Point(55, 362);
            cutOffSecondsStart.Maximum = 60;
            cutOffSecondsStart.Name = "cutOffSecondsStart";
            cutOffSecondsStart.RightToLeft = RightToLeft.No;
            cutOffSecondsStart.Size = new Size(386, 45);
            cutOffSecondsStart.TabIndex = 18;
            cutOffSecondsStart.TickStyle = TickStyle.None;
            cutOffSecondsStart.Scroll += cutOffSecondsStart_Scroll;
            // 
            // cutOffSecondsEnd
            // 
            cutOffSecondsEnd.Location = new Point(55, 413);
            cutOffSecondsEnd.Maximum = 60;
            cutOffSecondsEnd.Name = "cutOffSecondsEnd";
            cutOffSecondsEnd.RightToLeft = RightToLeft.Yes;
            cutOffSecondsEnd.RightToLeftLayout = true;
            cutOffSecondsEnd.Size = new Size(377, 45);
            cutOffSecondsEnd.TabIndex = 19;
            cutOffSecondsEnd.TickStyle = TickStyle.None;
            cutOffSecondsEnd.Scroll += cutOffSecondsEnd_Scroll;
            // 
            // cutOffSecondsStartLabel
            // 
            cutOffSecondsStartLabel.AutoSize = true;
            cutOffSecondsStartLabel.Location = new Point(438, 362);
            cutOffSecondsStartLabel.Name = "cutOffSecondsStartLabel";
            cutOffSecondsStartLabel.Size = new Size(34, 15);
            cutOffSecondsStartLabel.TabIndex = 20;
            cutOffSecondsStartLabel.Text = "00:00";
            // 
            // cutOffSecondsEndLabel
            // 
            cutOffSecondsEndLabel.AutoSize = true;
            cutOffSecondsEndLabel.Location = new Point(438, 413);
            cutOffSecondsEndLabel.Name = "cutOffSecondsEndLabel";
            cutOffSecondsEndLabel.Size = new Size(34, 15);
            cutOffSecondsEndLabel.TabIndex = 21;
            cutOffSecondsEndLabel.Text = "00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 518);
            Controls.Add(cutOffSecondsEndLabel);
            Controls.Add(cutOffSecondsStartLabel);
            Controls.Add(cutOffSecondsEnd);
            Controls.Add(cutOffSecondsStart);
            Controls.Add(configButton);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(maxLength);
            Controls.Add(elapsedLength);
            Controls.Add(trackBarTimeline);
            Controls.Add(button2);
            Controls.Add(mediaPlayer);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTimeline).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutOffSecondsStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutOffSecondsEnd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private Button button2;
        private TrackBar trackBarTimeline;
        private System.Windows.Forms.Timer playbackTimer;
        private Label elapsedLength;
        private Label maxLength;
        private Label label3;
        private Button button3;
        private Button configButton;
        private TrackBar cutOffSecondsStart;
        private TrackBar cutOffSecondsEnd;
        private Label cutOffSecondsStartLabel;
        private Label cutOffSecondsEndLabel;
    }
}
