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
            this.chooseMinerDialog = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            this.gpuDataGrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.globalCurrent = new System.Windows.Forms.Label();
            this.global5m = new System.Windows.Forms.Label();
            this.global1h = new System.Windows.Forms.Label();
            this.appStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentHashRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiveMinHashAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneHourHashAvgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentFanSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentGpuTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpuStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.totalShares = new System.Windows.Forms.Label();
            this.acceptedShares = new System.Windows.Forms.Label();
            this.rejectedShares = new System.Windows.Forms.Label();
            this.invalidShares = new System.Windows.Forms.Label();
            this.outdatedShares = new System.Windows.Forms.Label();
            this.netErrShares = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuStateBindingSource)).BeginInit();
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
            this.startButton.Location = new System.Drawing.Point(12, 269);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(116, 269);
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
            this.consoleLog.Location = new System.Drawing.Point(12, 301);
            this.consoleLog.Multiline = true;
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleLog.Size = new System.Drawing.Size(699, 163);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.statusTimer.Interval = 3000;
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
            this.autoRestartCheck.Location = new System.Drawing.Point(116, 166);
            this.autoRestartCheck.Name = "autoRestartCheck";
            this.autoRestartCheck.Size = new System.Drawing.Size(207, 17);
            this.autoRestartCheck.TabIndex = 18;
            this.autoRestartCheck.Text = "Auto Restart if 5min Rate Drops Below";
            this.autoRestartCheck.UseVisualStyleBackColor = true;
            // 
            // hashRestart
            // 
            this.hashRestart.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::cast_xmr_ui.Properties.Settings.Default, "AutoRestartRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hashRestart.Location = new System.Drawing.Point(116, 189);
            this.hashRestart.Name = "hashRestart";
            this.hashRestart.Size = new System.Drawing.Size(100, 20);
            this.hashRestart.TabIndex = 19;
            this.hashRestart.Text = global::cast_xmr_ui.Properties.Settings.Default.AutoRestartRate;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 192);
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
            // chooseMinerDialog
            // 
            this.chooseMinerDialog.Filter = "Executable Files|*.exe";
            this.chooseMinerDialog.Title = "Locate Cast-XMR Miner Executable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(197, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Note: Settings are saved on successful start.";
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Location = new System.Drawing.Point(102, 92);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(13, 13);
            this.restartLabel.TabIndex = 22;
            this.restartLabel.Text = "0";
            // 
            // gpuDataGrid
            // 
            this.gpuDataGrid.AllowUserToAddRows = false;
            this.gpuDataGrid.AllowUserToDeleteRows = false;
            this.gpuDataGrid.AllowUserToResizeRows = false;
            this.gpuDataGrid.AutoGenerateColumns = false;
            this.gpuDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gpuDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gpuDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.currentHashRateDataGridViewTextBoxColumn,
            this.fiveMinHashAvgDataGridViewTextBoxColumn,
            this.oneHourHashAvgDataGridViewTextBoxColumn,
            this.currentFanSpeedDataGridViewTextBoxColumn,
            this.currentGpuTempDataGridViewTextBoxColumn});
            this.gpuDataGrid.DataSource = this.gpuStateBindingSource;
            this.gpuDataGrid.Location = new System.Drawing.Point(434, 153);
            this.gpuDataGrid.Name = "gpuDataGrid";
            this.gpuDataGrid.ReadOnly = true;
            this.gpuDataGrid.RowHeadersVisible = false;
            this.gpuDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gpuDataGrid.Size = new System.Drawing.Size(277, 138);
            this.gpuDataGrid.TabIndex = 24;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.netErrShares);
            this.groupBox1.Controls.Add(this.outdatedShares);
            this.groupBox1.Controls.Add(this.restartLabel);
            this.groupBox1.Controls.Add(this.invalidShares);
            this.groupBox1.Controls.Add(this.rejectedShares);
            this.groupBox1.Controls.Add(this.acceptedShares);
            this.groupBox1.Controls.Add(this.totalShares);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.global1h);
            this.groupBox1.Controls.Add(this.global5m);
            this.groupBox1.Controls.Add(this.globalCurrent);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(434, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 137);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current Hash Rate:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "5 minute:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "1 hour:";
            // 
            // globalCurrent
            // 
            this.globalCurrent.AutoSize = true;
            this.globalCurrent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "CurrentGlobalRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.globalCurrent.Location = new System.Drawing.Point(102, 20);
            this.globalCurrent.Name = "globalCurrent";
            this.globalCurrent.Size = new System.Drawing.Size(13, 13);
            this.globalCurrent.TabIndex = 3;
            this.globalCurrent.Text = "0";
            // 
            // global5m
            // 
            this.global5m.AutoSize = true;
            this.global5m.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "FiveMinGlobalRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.global5m.Location = new System.Drawing.Point(102, 38);
            this.global5m.Name = "global5m";
            this.global5m.Size = new System.Drawing.Size(13, 13);
            this.global5m.TabIndex = 4;
            this.global5m.Text = "0";
            // 
            // global1h
            // 
            this.global1h.AutoSize = true;
            this.global1h.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "OneHourGlobalRate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.global1h.Location = new System.Drawing.Point(102, 56);
            this.global1h.Name = "global1h";
            this.global1h.Size = new System.Drawing.Size(13, 13);
            this.global1h.TabIndex = 5;
            this.global1h.Text = "0";
            // 
            // appStateBindingSource
            // 
            this.appStateBindingSource.DataSource = typeof(CastXmrLib.AppState);
            // 
            // currentHashRateDataGridViewTextBoxColumn
            // 
            this.currentHashRateDataGridViewTextBoxColumn.DataPropertyName = "CurrentHashRate";
            this.currentHashRateDataGridViewTextBoxColumn.HeaderText = "Curr";
            this.currentHashRateDataGridViewTextBoxColumn.Name = "currentHashRateDataGridViewTextBoxColumn";
            this.currentHashRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiveMinHashAvgDataGridViewTextBoxColumn
            // 
            this.fiveMinHashAvgDataGridViewTextBoxColumn.DataPropertyName = "FiveMinHashAvg";
            this.fiveMinHashAvgDataGridViewTextBoxColumn.HeaderText = "5m";
            this.fiveMinHashAvgDataGridViewTextBoxColumn.Name = "fiveMinHashAvgDataGridViewTextBoxColumn";
            this.fiveMinHashAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oneHourHashAvgDataGridViewTextBoxColumn
            // 
            this.oneHourHashAvgDataGridViewTextBoxColumn.DataPropertyName = "OneHourHashAvg";
            this.oneHourHashAvgDataGridViewTextBoxColumn.HeaderText = "1h";
            this.oneHourHashAvgDataGridViewTextBoxColumn.Name = "oneHourHashAvgDataGridViewTextBoxColumn";
            this.oneHourHashAvgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentFanSpeedDataGridViewTextBoxColumn
            // 
            this.currentFanSpeedDataGridViewTextBoxColumn.DataPropertyName = "CurrentFanSpeed";
            this.currentFanSpeedDataGridViewTextBoxColumn.HeaderText = "RPM";
            this.currentFanSpeedDataGridViewTextBoxColumn.Name = "currentFanSpeedDataGridViewTextBoxColumn";
            this.currentFanSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentGpuTempDataGridViewTextBoxColumn
            // 
            this.currentGpuTempDataGridViewTextBoxColumn.DataPropertyName = "CurrentGpuTemp";
            this.currentGpuTempDataGridViewTextBoxColumn.HeaderText = "Temp";
            this.currentGpuTempDataGridViewTextBoxColumn.Name = "currentGpuTempDataGridViewTextBoxColumn";
            this.currentGpuTempDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gpuStateBindingSource
            // 
            this.gpuStateBindingSource.DataSource = typeof(CastXmrLib.GpuState);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total Shares:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(173, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Accepted:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Rejected:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(188, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Invalid:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Outdated:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(186, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Net Err:";
            // 
            // totalShares
            // 
            this.totalShares.AutoSize = true;
            this.totalShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "TotalShares", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.totalShares.Location = new System.Drawing.Point(226, 20);
            this.totalShares.Name = "totalShares";
            this.totalShares.Size = new System.Drawing.Size(13, 13);
            this.totalShares.TabIndex = 12;
            this.totalShares.Text = "0";
            // 
            // acceptedShares
            // 
            this.acceptedShares.AutoSize = true;
            this.acceptedShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "SharesAccepted", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.acceptedShares.Location = new System.Drawing.Point(226, 38);
            this.acceptedShares.Name = "acceptedShares";
            this.acceptedShares.Size = new System.Drawing.Size(13, 13);
            this.acceptedShares.TabIndex = 13;
            this.acceptedShares.Text = "0";
            // 
            // rejectedShares
            // 
            this.rejectedShares.AutoSize = true;
            this.rejectedShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "SharesRejected", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.rejectedShares.Location = new System.Drawing.Point(226, 57);
            this.rejectedShares.Name = "rejectedShares";
            this.rejectedShares.Size = new System.Drawing.Size(13, 13);
            this.rejectedShares.TabIndex = 14;
            this.rejectedShares.Text = "0";
            // 
            // invalidShares
            // 
            this.invalidShares.AutoSize = true;
            this.invalidShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "SharesInvalid", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.invalidShares.Location = new System.Drawing.Point(226, 74);
            this.invalidShares.Name = "invalidShares";
            this.invalidShares.Size = new System.Drawing.Size(13, 13);
            this.invalidShares.TabIndex = 15;
            this.invalidShares.Text = "0";
            // 
            // outdatedShares
            // 
            this.outdatedShares.AutoSize = true;
            this.outdatedShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "SharesOutdated", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.outdatedShares.Location = new System.Drawing.Point(226, 92);
            this.outdatedShares.Name = "outdatedShares";
            this.outdatedShares.Size = new System.Drawing.Size(13, 13);
            this.outdatedShares.TabIndex = 16;
            this.outdatedShares.Text = "0";
            // 
            // netErrShares
            // 
            this.netErrShares.AutoSize = true;
            this.netErrShares.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appStateBindingSource, "SharesNetworkError", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N0"));
            this.netErrShares.Location = new System.Drawing.Point(226, 110);
            this.netErrShares.Name = "netErrShares";
            this.netErrShares.Size = new System.Drawing.Size(13, 13);
            this.netErrShares.TabIndex = 17;
            this.netErrShares.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Miner Restarts:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpuDataGrid);
            this.Controls.Add(this.label8);
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
            this.Text = "Cast XMR UI";
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpuStateBindingSource)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog chooseMinerDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label restartLabel;
        private System.Windows.Forms.DataGridView gpuDataGrid;
        private System.Windows.Forms.BindingSource gpuStateBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentHashRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiveMinHashAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneHourHashAvgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentFanSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentGpuTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label global1h;
        private System.Windows.Forms.BindingSource appStateBindingSource;
        private System.Windows.Forms.Label global5m;
        private System.Windows.Forms.Label globalCurrent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label netErrShares;
        private System.Windows.Forms.Label outdatedShares;
        private System.Windows.Forms.Label invalidShares;
        private System.Windows.Forms.Label rejectedShares;
        private System.Windows.Forms.Label acceptedShares;
        private System.Windows.Forms.Label totalShares;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
    }
}

