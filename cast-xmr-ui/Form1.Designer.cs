namespace cast_xmr_ui
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.useNicehash = new System.Windows.Forms.CheckBox();
            this.intensity = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.consoleLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.processRunner = new System.Diagnostics.Process();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.fastJobCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpuText = new System.Windows.Forms.TextBox();
            this.autoRestartCheck = new System.Windows.Forms.CheckBox();
            this.hashRestart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.exePath = new System.Windows.Forms.TextBox();
            this.workerPassword = new System.Windows.Forms.TextBox();
            this.walletAddress = new System.Windows.Forms.TextBox();
            this.poolAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pool Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wallet Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Worker Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Intensity";
            // 
            // useNicehash
            // 
            this.useNicehash.AutoSize = true;
            this.useNicehash.Checked = global::cast_xmr_ui.Properties.Settings.Default.UseNicehash;
            this.useNicehash.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useNicehash.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::cast_xmr_ui.Properties.Settings.Default, "UseNicehash", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useNicehash.Location = new System.Drawing.Point(116, 141);
            this.useNicehash.Name = "useNicehash";
            this.useNicehash.Size = new System.Drawing.Size(130, 17);
            this.useNicehash.TabIndex = 5;
            this.useNicehash.Text = "Use NiceHash Nonce";
            this.useNicehash.UseVisualStyleBackColor = true;
            // 
            // intensity
            // 
            this.intensity.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::cast_xmr_ui.Properties.Settings.Default, "Intensity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.intensity.Location = new System.Drawing.Point(116, 115);
            this.intensity.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.intensity.Name = "intensity";
            this.intensity.Size = new System.Drawing.Size(37, 20);
            this.intensity.TabIndex = 8;
            this.intensity.Value = global::cast_xmr_ui.Properties.Settings.Default.Intensity;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 164);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(116, 164);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // consoleLog
            // 
            this.consoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleLog.Location = new System.Drawing.Point(12, 193);
            this.consoleLog.Multiline = true;
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleLog.Size = new System.Drawing.Size(699, 202);
            this.consoleLog.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Select...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // processRunner
            // 
            this.processRunner.EnableRaisingEvents = true;
            this.processRunner.StartInfo.Domain = "";
            this.processRunner.StartInfo.LoadUserProfile = false;
            this.processRunner.StartInfo.Password = null;
            this.processRunner.StartInfo.StandardErrorEncoding = null;
            this.processRunner.StartInfo.StandardOutputEncoding = null;
            this.processRunner.StartInfo.UserName = "";
            this.processRunner.SynchronizingObject = this;
            this.processRunner.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.processRunner_OutputDataReceived);
            this.processRunner.ErrorDataReceived += new System.Diagnostics.DataReceivedEventHandler(this.processRunner_ErrorDataReceived);
            this.processRunner.Exited += new System.EventHandler(this.processRunner_Exited);
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 10000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // fastJobCheck
            // 
            this.fastJobCheck.AutoSize = true;
            this.fastJobCheck.Checked = global::cast_xmr_ui.Properties.Settings.Default.FastJobSwitching;
            this.fastJobCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fastJobCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::cast_xmr_ui.Properties.Settings.Default, "FastJobSwitching", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fastJobCheck.Location = new System.Drawing.Point(267, 141);
            this.fastJobCheck.Margin = new System.Windows.Forms.Padding(1);
            this.fastJobCheck.Name = "fastJobCheck";
            this.fastJobCheck.Size = new System.Drawing.Size(115, 17);
            this.fastJobCheck.TabIndex = 15;
            this.fastJobCheck.Text = "Fast Job Switching";
            this.fastJobCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "GPUs";
            // 
            // gpuText
            // 
            this.gpuText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "GPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.gpuText.Location = new System.Drawing.Point(204, 116);
            this.gpuText.Margin = new System.Windows.Forms.Padding(1);
            this.gpuText.Name = "gpuText";
            this.gpuText.Size = new System.Drawing.Size(40, 20);
            this.gpuText.TabIndex = 17;
            this.gpuText.Text = global::cast_xmr_ui.Properties.Settings.Default.GPU;
            // 
            // autoRestartCheck
            // 
            this.autoRestartCheck.AutoSize = true;
            this.autoRestartCheck.Checked = global::cast_xmr_ui.Properties.Settings.Default.AutoRestart;
            this.autoRestartCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRestartCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::cast_xmr_ui.Properties.Settings.Default, "AutoRestart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoRestartCheck.Location = new System.Drawing.Point(457, 15);
            this.autoRestartCheck.Name = "autoRestartCheck";
            this.autoRestartCheck.Size = new System.Drawing.Size(207, 17);
            this.autoRestartCheck.TabIndex = 18;
            this.autoRestartCheck.Text = "Auto Restart if 5min Rate Drops Below";
            this.autoRestartCheck.UseVisualStyleBackColor = true;
            // 
            // hashRestart
            // 
            this.hashRestart.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "AutoRestartRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hashRestart.Location = new System.Drawing.Point(457, 38);
            this.hashRestart.Name = "hashRestart";
            this.hashRestart.Size = new System.Drawing.Size(100, 20);
            this.hashRestart.TabIndex = 19;
            this.hashRestart.Text = global::cast_xmr_ui.Properties.Settings.Default.AutoRestartRate;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "H/s (per card)";
            // 
            // exePath
            // 
            this.exePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "MinerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exePath.Location = new System.Drawing.Point(116, 12);
            this.exePath.Name = "exePath";
            this.exePath.Size = new System.Drawing.Size(231, 20);
            this.exePath.TabIndex = 12;
            this.exePath.Text = global::cast_xmr_ui.Properties.Settings.Default.MinerPath;
            // 
            // workerPassword
            // 
            this.workerPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "WorkerPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.workerPassword.Location = new System.Drawing.Point(116, 90);
            this.workerPassword.Name = "workerPassword";
            this.workerPassword.Size = new System.Drawing.Size(312, 20);
            this.workerPassword.TabIndex = 7;
            this.workerPassword.Text = global::cast_xmr_ui.Properties.Settings.Default.WorkerPassword;
            // 
            // walletAddress
            // 
            this.walletAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "WalletAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.walletAddress.Location = new System.Drawing.Point(116, 64);
            this.walletAddress.Name = "walletAddress";
            this.walletAddress.Size = new System.Drawing.Size(312, 20);
            this.walletAddress.TabIndex = 6;
            this.walletAddress.Text = global::cast_xmr_ui.Properties.Settings.Default.WalletAddress;
            // 
            // poolAddress
            // 
            this.poolAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "PoolAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.poolAddress.Location = new System.Drawing.Point(116, 38);
            this.poolAddress.Name = "poolAddress";
            this.poolAddress.Size = new System.Drawing.Size(312, 20);
            this.poolAddress.TabIndex = 0;
            this.poolAddress.Text = global::cast_xmr_ui.Properties.Settings.Default.PoolAddress;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 407);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hashRestart);
            this.Controls.Add(this.autoRestartCheck);
            this.Controls.Add(this.gpuText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fastJobCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exePath);
            this.Controls.Add(this.consoleLog);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.intensity);
            this.Controls.Add(this.workerPassword);
            this.Controls.Add(this.walletAddress);
            this.Controls.Add(this.useNicehash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poolAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poolAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useNicehash;
        private System.Windows.Forms.TextBox walletAddress;
        private System.Windows.Forms.TextBox workerPassword;
        private System.Windows.Forms.NumericUpDown intensity;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox consoleLog;
        private System.Windows.Forms.TextBox exePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.Process processRunner;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.CheckBox fastJobCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gpuText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hashRestart;
        private System.Windows.Forms.CheckBox autoRestartCheck;
    }
}

