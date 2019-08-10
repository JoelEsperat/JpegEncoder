namespace JpegEncoder
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.inputButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.foundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encodeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.qualityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialogInput
            // 
            this.folderBrowserDialogInput.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // folderBrowserDialogOutput
            // 
            this.folderBrowserDialogOutput.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 438);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(384, 23);
            this.progressBar.TabIndex = 0;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(50, 60);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(100, 30);
            this.inputButton.TabIndex = 1;
            this.inputButton.Text = "Select Folder...";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.InputFolderButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 24);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(154, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "1. Select the images to encode";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(13, 137);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(226, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "2. Select the location to save encoded images";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(50, 175);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(100, 30);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "Select Folder...";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputFolderButton_Click);
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(161, 68);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(93, 13);
            this.inputFolderLabel.TabIndex = 5;
            this.inputFolderLabel.Text = "No folder selected";
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(161, 183);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(93, 13);
            this.outputFolderLabel.TabIndex = 6;
            this.outputFolderLabel.Text = "No folder selected";
            // 
            // foundLabel
            // 
            this.foundLabel.AutoSize = true;
            this.foundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundLabel.Location = new System.Drawing.Point(59, 101);
            this.foundLabel.Name = "foundLabel";
            this.foundLabel.Size = new System.Drawing.Size(87, 13);
            this.foundLabel.TabIndex = 7;
            this.foundLabel.Text = "No images found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "3. Select encoding quality";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(51, 306);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(157, 13);
            this.label90.TabIndex = 10;
            this.label90.Text = "90 : high quality - recommended";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "75 : medium quality - recommended for web galleries";
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(50, 380);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(100, 30);
            this.encodeButton.TabIndex = 12;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 30);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(51, 257);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(252, 45);
            this.trackBar.TabIndex = 14;
            this.trackBar.Value = 90;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(309, 257);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(19, 13);
            this.qualityLabel.TabIndex = 15;
            this.qualityLabel.Text = "90";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foundLabel);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.inputFolderLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Improved JPEG Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.Label foundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label qualityLabel;
    }
}

