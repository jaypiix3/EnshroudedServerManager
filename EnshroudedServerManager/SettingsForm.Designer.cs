namespace EnshroudedServerManager
{
    partial class SettingsForm
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
            btnMinimize = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            lSteamCmdStatus = new Label();
            lServerInstallStatus = new Label();
            label3 = new Label();
            btnSetupServer = new Button();
            btnStartStop = new Button();
            label5 = new Label();
            label2 = new Label();
            groupBoxConfiguration = new GroupBox();
            btnCreateFirewallRule = new Button();
            label13 = new Label();
            tbSlotCount = new TextBox();
            label12 = new Label();
            tbQueryPort = new TextBox();
            label11 = new Label();
            tbGamePort = new TextBox();
            label10 = new Label();
            tbIpAddress = new TextBox();
            label9 = new Label();
            tbLogDirectory = new TextBox();
            label8 = new Label();
            tbSaveDirectory = new TextBox();
            label7 = new Label();
            tbPassword = new TextBox();
            label6 = new Label();
            tbServername = new TextBox();
            btnSaveSettings = new Button();
            button2 = new Button();
            button3 = new Button();
            btnResetAll = new Button();
            groupBox1.SuspendLayout();
            groupBoxConfiguration.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(38, 38, 38);
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.DarkGray;
            btnMinimize.Location = new Point(537, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "_";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(38, 38, 38);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.DarkGray;
            btnClose.Location = new Point(568, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResetAll);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lSteamCmdStatus);
            groupBox1.Controls.Add(lServerInstallStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnSetupServer);
            groupBox1.Controls.Add(btnStartStop);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(25, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(557, 111);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setup";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(16, 86);
            label1.Name = "label1";
            label1.Size = new Size(442, 13);
            label1.TabIndex = 14;
            label1.Text = "When you hit \"Install\" settings will close after 5 seconds. Come back when download is done.";
            // 
            // lSteamCmdStatus
            // 
            lSteamCmdStatus.AutoSize = true;
            lSteamCmdStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lSteamCmdStatus.ForeColor = Color.Red;
            lSteamCmdStatus.Location = new Point(162, 28);
            lSteamCmdStatus.Name = "lSteamCmdStatus";
            lSteamCmdStatus.Size = new Size(126, 17);
            lSteamCmdStatus.TabIndex = 13;
            lSteamCmdStatus.Text = "Installation missing";
            // 
            // lServerInstallStatus
            // 
            lServerInstallStatus.AutoSize = true;
            lServerInstallStatus.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lServerInstallStatus.ForeColor = Color.Red;
            lServerInstallStatus.Location = new Point(162, 54);
            lServerInstallStatus.Name = "lServerInstallStatus";
            lServerInstallStatus.Size = new Size(126, 17);
            lServerInstallStatus.TabIndex = 12;
            lServerInstallStatus.Text = "Installation missing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(26, 54);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 11;
            label3.Text = "Serverfiles Status:";
            // 
            // btnSetupServer
            // 
            btnSetupServer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetupServer.BackColor = Color.FromArgb(38, 38, 38);
            btnSetupServer.FlatStyle = FlatStyle.Flat;
            btnSetupServer.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetupServer.ForeColor = Color.DarkGray;
            btnSetupServer.Location = new Point(438, 37);
            btnSetupServer.Name = "btnSetupServer";
            btnSetupServer.Size = new Size(97, 30);
            btnSetupServer.TabIndex = 10;
            btnSetupServer.Text = "Install";
            btnSetupServer.UseVisualStyleBackColor = false;
            btnSetupServer.Click += btnSetupServer_Click;
            // 
            // btnStartStop
            // 
            btnStartStop.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStartStop.BackColor = Color.FromArgb(38, 38, 38);
            btnStartStop.FlatStyle = FlatStyle.Flat;
            btnStartStop.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStartStop.ForeColor = Color.DarkGray;
            btnStartStop.Location = new Point(1044, 28);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(97, 30);
            btnStartStop.TabIndex = 9;
            btnStartStop.Text = "Starten";
            btnStartStop.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(26, 28);
            label5.Name = "label5";
            label5.Size = new Size(124, 17);
            label5.TabIndex = 7;
            label5.Text = "SteamCmd Status:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 8;
            label2.Text = "Settings";
            // 
            // groupBoxConfiguration
            // 
            groupBoxConfiguration.Controls.Add(btnCreateFirewallRule);
            groupBoxConfiguration.Controls.Add(label13);
            groupBoxConfiguration.Controls.Add(tbSlotCount);
            groupBoxConfiguration.Controls.Add(label12);
            groupBoxConfiguration.Controls.Add(tbQueryPort);
            groupBoxConfiguration.Controls.Add(label11);
            groupBoxConfiguration.Controls.Add(tbGamePort);
            groupBoxConfiguration.Controls.Add(label10);
            groupBoxConfiguration.Controls.Add(tbIpAddress);
            groupBoxConfiguration.Controls.Add(label9);
            groupBoxConfiguration.Controls.Add(tbLogDirectory);
            groupBoxConfiguration.Controls.Add(label8);
            groupBoxConfiguration.Controls.Add(tbSaveDirectory);
            groupBoxConfiguration.Controls.Add(label7);
            groupBoxConfiguration.Controls.Add(tbPassword);
            groupBoxConfiguration.Controls.Add(label6);
            groupBoxConfiguration.Controls.Add(tbServername);
            groupBoxConfiguration.Controls.Add(btnSaveSettings);
            groupBoxConfiguration.Controls.Add(button2);
            groupBoxConfiguration.Controls.Add(button3);
            groupBoxConfiguration.ForeColor = Color.LightGray;
            groupBoxConfiguration.Location = new Point(25, 191);
            groupBoxConfiguration.Name = "groupBoxConfiguration";
            groupBoxConfiguration.Size = new Size(557, 356);
            groupBoxConfiguration.TabIndex = 11;
            groupBoxConfiguration.TabStop = false;
            groupBoxConfiguration.Text = "Configuration (Disabled till setup is finished)";
            // 
            // btnCreateFirewallRule
            // 
            btnCreateFirewallRule.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateFirewallRule.BackColor = Color.FromArgb(38, 38, 38);
            btnCreateFirewallRule.Enabled = false;
            btnCreateFirewallRule.FlatStyle = FlatStyle.Flat;
            btnCreateFirewallRule.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateFirewallRule.ForeColor = Color.DarkGray;
            btnCreateFirewallRule.Location = new Point(335, 304);
            btnCreateFirewallRule.Name = "btnCreateFirewallRule";
            btnCreateFirewallRule.Size = new Size(97, 30);
            btnCreateFirewallRule.TabIndex = 29;
            btnCreateFirewallRule.Text = "Firewall rule";
            btnCreateFirewallRule.UseVisualStyleBackColor = false;
            btnCreateFirewallRule.Click += btnCreateFirewallRule_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(26, 256);
            label13.Name = "label13";
            label13.Size = new Size(99, 17);
            label13.TabIndex = 27;
            label13.Text = "Slot (Max. 16):";
            // 
            // tbSlotCount
            // 
            tbSlotCount.BackColor = Color.FromArgb(24, 24, 24);
            tbSlotCount.BorderStyle = BorderStyle.FixedSingle;
            tbSlotCount.Enabled = false;
            tbSlotCount.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbSlotCount.ForeColor = Color.DarkGray;
            tbSlotCount.Location = new Point(156, 253);
            tbSlotCount.Name = "tbSlotCount";
            tbSlotCount.PlaceholderText = "16";
            tbSlotCount.Size = new Size(294, 25);
            tbSlotCount.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(26, 225);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 25;
            label12.Text = "Queryport:";
            // 
            // tbQueryPort
            // 
            tbQueryPort.BackColor = Color.FromArgb(24, 24, 24);
            tbQueryPort.BorderStyle = BorderStyle.FixedSingle;
            tbQueryPort.Enabled = false;
            tbQueryPort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbQueryPort.ForeColor = Color.DarkGray;
            tbQueryPort.Location = new Point(156, 222);
            tbQueryPort.Name = "tbQueryPort";
            tbQueryPort.PlaceholderText = "15637";
            tbQueryPort.Size = new Size(294, 25);
            tbQueryPort.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(26, 194);
            label11.Name = "label11";
            label11.Size = new Size(75, 17);
            label11.TabIndex = 23;
            label11.Text = "Gameport:";
            // 
            // tbGamePort
            // 
            tbGamePort.BackColor = Color.FromArgb(24, 24, 24);
            tbGamePort.BorderStyle = BorderStyle.FixedSingle;
            tbGamePort.Enabled = false;
            tbGamePort.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbGamePort.ForeColor = Color.DarkGray;
            tbGamePort.Location = new Point(156, 191);
            tbGamePort.Name = "tbGamePort";
            tbGamePort.PlaceholderText = "15636";
            tbGamePort.Size = new Size(294, 25);
            tbGamePort.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(26, 163);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 21;
            label10.Text = "IP Address:";
            // 
            // tbIpAddress
            // 
            tbIpAddress.BackColor = Color.FromArgb(24, 24, 24);
            tbIpAddress.BorderStyle = BorderStyle.FixedSingle;
            tbIpAddress.Enabled = false;
            tbIpAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbIpAddress.ForeColor = Color.DarkGray;
            tbIpAddress.Location = new Point(156, 160);
            tbIpAddress.Name = "tbIpAddress";
            tbIpAddress.PlaceholderText = "127.0.0.1";
            tbIpAddress.Size = new Size(294, 25);
            tbIpAddress.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(26, 132);
            label9.Name = "label9";
            label9.Size = new Size(97, 17);
            label9.TabIndex = 19;
            label9.Text = "Log Directory:";
            // 
            // tbLogDirectory
            // 
            tbLogDirectory.BackColor = Color.FromArgb(24, 24, 24);
            tbLogDirectory.BorderStyle = BorderStyle.FixedSingle;
            tbLogDirectory.Enabled = false;
            tbLogDirectory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogDirectory.ForeColor = Color.DarkGray;
            tbLogDirectory.Location = new Point(156, 129);
            tbLogDirectory.Name = "tbLogDirectory";
            tbLogDirectory.PlaceholderText = "./logs";
            tbLogDirectory.Size = new Size(294, 25);
            tbLogDirectory.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(26, 101);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 17;
            label8.Text = "Save Directory:";
            // 
            // tbSaveDirectory
            // 
            tbSaveDirectory.BackColor = Color.FromArgb(24, 24, 24);
            tbSaveDirectory.BorderStyle = BorderStyle.FixedSingle;
            tbSaveDirectory.Enabled = false;
            tbSaveDirectory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbSaveDirectory.ForeColor = Color.DarkGray;
            tbSaveDirectory.Location = new Point(156, 98);
            tbSaveDirectory.Name = "tbSaveDirectory";
            tbSaveDirectory.PlaceholderText = "./savegame";
            tbSaveDirectory.Size = new Size(294, 25);
            tbSaveDirectory.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(26, 70);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 15;
            label7.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(24, 24, 24);
            tbPassword.BorderStyle = BorderStyle.FixedSingle;
            tbPassword.Enabled = false;
            tbPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.DarkGray;
            tbPassword.Location = new Point(156, 67);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "**********";
            tbPassword.Size = new Size(294, 25);
            tbPassword.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(26, 39);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 13;
            label6.Text = "Servername:";
            // 
            // tbServername
            // 
            tbServername.BackColor = Color.FromArgb(24, 24, 24);
            tbServername.BorderStyle = BorderStyle.FixedSingle;
            tbServername.Enabled = false;
            tbServername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbServername.ForeColor = Color.DarkGray;
            tbServername.Location = new Point(156, 36);
            tbServername.Name = "tbServername";
            tbServername.PlaceholderText = "Test-Server";
            tbServername.Size = new Size(294, 25);
            tbServername.TabIndex = 14;
            // 
            // btnSaveSettings
            // 
            btnSaveSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveSettings.BackColor = Color.FromArgb(38, 38, 38);
            btnSaveSettings.Enabled = false;
            btnSaveSettings.FlatStyle = FlatStyle.Flat;
            btnSaveSettings.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveSettings.ForeColor = Color.DarkGray;
            btnSaveSettings.Location = new Point(438, 304);
            btnSaveSettings.Name = "btnSaveSettings";
            btnSaveSettings.Size = new Size(97, 30);
            btnSaveSettings.TabIndex = 13;
            btnSaveSettings.Text = "Save";
            btnSaveSettings.UseVisualStyleBackColor = false;
            btnSaveSettings.Click += btnSaveSettings_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(38, 38, 38);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkGray;
            button2.Location = new Point(709, 28);
            button2.Name = "button2";
            button2.Size = new Size(97, 30);
            button2.TabIndex = 10;
            button2.Text = "Installieren";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(38, 38, 38);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkGray;
            button3.Location = new Point(1316, 28);
            button3.Name = "button3";
            button3.Size = new Size(97, 30);
            button3.TabIndex = 9;
            button3.Text = "Starten";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnResetAll
            // 
            btnResetAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetAll.BackColor = Color.FromArgb(38, 38, 38);
            btnResetAll.FlatStyle = FlatStyle.Flat;
            btnResetAll.Font = new Font("Arial Unicode MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResetAll.ForeColor = Color.DarkGray;
            btnResetAll.Location = new Point(335, 37);
            btnResetAll.Name = "btnResetAll";
            btnResetAll.Size = new Size(97, 30);
            btnResetAll.TabIndex = 15;
            btnResetAll.Text = "Reset All";
            btnResetAll.UseVisualStyleBackColor = false;
            btnResetAll.Click += btnResetAll_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(605, 575);
            Controls.Add(groupBoxConfiguration);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            MouseDown += SettingsForm_MouseDown;
            MouseMove += SettingsForm_MouseMove;
            MouseUp += SettingsForm_MouseUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxConfiguration.ResumeLayout(false);
            groupBoxConfiguration.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimize;
        private Button btnClose;
        private GroupBox groupBox1;
        private Button btnStartStop;
        private Label label5;
        private Button btnSetupServer;
        private Label label2;
        private GroupBox groupBoxConfiguration;
        private Button button2;
        private Button button3;
        private Label lServerInstallStatus;
        private Label label3;
        private Button btnSaveSettings;
        private Label label11;
        private TextBox tbGamePort;
        private Label label10;
        private TextBox tbIpAddress;
        private Label label9;
        private TextBox tbLogDirectory;
        private Label label8;
        private TextBox tbSaveDirectory;
        private Label label7;
        private TextBox tbPassword;
        private Label label6;
        private TextBox tbServername;
        private Label label13;
        private TextBox tbSlotCount;
        private Label label12;
        private TextBox tbQueryPort;
        public Label lSteamCmdStatus;
        private Label label1;
        private Button btnCreateFirewallRule;
        private Button btnResetAll;
    }
}