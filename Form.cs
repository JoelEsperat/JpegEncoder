using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpegEncoder
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Encoder encoder;

        public Form()
        {
            InitializeComponent();
        }

        private async void InputFolderButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialogInput.ShowDialog();
            if (result == DialogResult.OK)
            {
                var inputFolderName = folderBrowserDialogInput.SelectedPath;
                inputFolderLabel.Text = inputFolderName;

                //Display image count
                var count = 0;
                await Task.Run(() => count = Encoder.CountJpegFiles(inputFolderName));
                if (count == -1) foundLabel.Text = "Error while searching the specified directory.";
                else if (count == 0) foundLabel.Text = "No image found.";
                else if (count == 1) foundLabel.Text = count + " image found.";
                else foundLabel.Text = count + " images found.";
            }
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialogOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                var outputFolderName = folderBrowserDialogOutput.SelectedPath;
                outputFolderLabel.Text = outputFolderName;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            qualityLabel.Text = "" + trackBar.Value;
        }

        private async void EncodeButton_Click(object sender, EventArgs e)
        {
            var inputFolderPath = folderBrowserDialogInput.SelectedPath;
            var outputFolderPath = folderBrowserDialogOutput.SelectedPath;
            var quality = trackBar.Value;

            encoder = new Encoder(inputFolderPath, outputFolderPath, quality);
            encoder.ProgressChanged += OnProgressChanged;

            Cursor.Current = Cursors.WaitCursor;
            encodeButton.Enabled = false;
            progressBar.Value = 0;
            progressBar.Maximum = encoder.TotalFilesCount;

            var stopWatch = Stopwatch.StartNew();
            await Task.Run(() => encoder.Encode());
            stopWatch.Stop();

            Cursor.Current = Cursors.Default;
            encodeButton.Enabled = true;
        }

        private void OnProgressChanged(int progress)
        {
            progressBar.Invoke((Action)(() => progressBar.Value = progress));
        }
    }
}
